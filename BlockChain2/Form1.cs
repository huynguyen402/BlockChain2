using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;


namespace BlockChain2
{
    public partial class Form1 : Form
    {
        private int _blockCount = 1;
        // List to keep track of all added block panels.
        private List<Transaction> pendingTransactions = new List<Transaction>();

        private BlockChain ChungChiChain;
        public Form1()
        {
            InitializeComponent();
            ChungChiChain = new BlockChain();
        }

        //Nút thêm giao dịch
        private void button1_Click(object sender, EventArgs e)
        {


            string ToChuc = textBox1.Text.Trim();
            string TenNhan = textBox2.Text.Trim();
            string CCCD = textBox3.Text.Trim();
            DateTime ngayCap = dateTimePicker1.Value;
            DateTime ngayHet = dateTimePicker2.Value;


            // Tạo một đối tượng Transaction mới
            Transaction tx = new Transaction(ToChuc, TenNhan, CCCD, ngayCap, ngayHet);

            // Thêm transaction vào danh sách điểm chờ
            pendingTransactions.Add(tx);

            // Cập nhật DataGridView: thêm dòng mới với các giá trị nhập
            PopulateDataGridView(pendingTransactions);

            // Xóa dữ liệu nhập sau khi thêm (nếu cần)
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }


        private void PopulateDataGridView(List<Transaction> transactions)
        {
            // Xóa hết các dòng hiện có
            dataGridView1.Rows.Clear();
            foreach (var tx in transactions)
            {
                // Giả sử Transaction có các thuộc tính: StudentId, SubjectId, RecordDate, AttemptNumber
                dataGridView1.Rows.Add(
                    tx.ToChucCap,
                    tx.TenNguoiNhan,
                    tx.CCCD,
                    tx.NgayCap.ToShortDateString(),
                    tx.NgayHetHan.ToShortDateString()
                );
            }
        }

        private void AddOneBlockToGridView(Block newBlock)
        {
            
            // Giả sử Transaction có các thuộc tính: StudentId, SubjectId, RecordDate, AttemptNumber
            dataGridView2.Rows.Add(
                newBlock.Index,
                newBlock.PreviousHash,
                newBlock.Nonce,
                newBlock.Difficulty,
                newBlock.MerkleRootHash,
                newBlock.TimeStamp
            );
            
        }




        // Nút hiện danh sách giao dịch chờ
        private void button2_Click(object sender, EventArgs e)
        {
            PopulateDataGridView(pendingTransactions);
        }
        // Nút Nhập block
        private void button3_Click(object sender, EventArgs e)
        {
            //import the blockchain from a json file and ask the user to select the file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files|*.json";
            openFileDialog.Title = "Select a JSON file to import the blockchain";
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                // Read the JSON string from the file
                string json = System.IO.File.ReadAllText(openFileDialog.FileName);
                // Deserialize the JSON string to a List<Block>
                List<Block> chain = JsonConvert.DeserializeObject<List<Block>>(json);
                // Update the blockchain with the imported chain
                ChungChiChain.Chain = chain;
                //clear panel 
                dataGridView2.Rows.Clear();
                _blockCount = 0;
                // Update the block panel with the imported 

                foreach (Block block in chain)
                {
                    if (block.Index == 0)
                    {
                        continue;
                    }
                    AddOneBlockToGridView(block);
                }
            }
        }
        // Nút xuất block
        private void button4_Click(object sender, EventArgs e)
        {
            //export the blockchain to a json file and ask the user where to save it
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files|*.json";
            saveFileDialog.Title = "Save the blockchain to a JSON file";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                // Inside the button4_Click method, replace the problematic line with:
                string json = JsonConvert.SerializeObject(ChungChiChain.Chain, Newtonsoft.Json.Formatting.Indented);
                // Write the JSON string to the file
                System.IO.File.WriteAllText(saveFileDialog.FileName, json);
            }
        }
        // nút xác minh block
        private void button5_Click(object sender, EventArgs e)
        {
            // Validate whether the data in blockchain is valid
            if (ValidateChain(ChungChiChain.Chain))
            {
                MessageBox.Show("The blockchain is valid.");
            }
            else
            {
                MessageBox.Show("The blockchain is not valid.");
            }
        }

        private bool ValidateChain(List<Block> chain)
        {
            for (int i = 1; i < chain.Count; i++)
            {
                Block currentBlock = chain[i];
                Block previousBlock = chain[i - 1];
                // Validate the hash of the current block
                if (currentBlock.MerkleRootHash.Equals(currentBlock.CalculateMRootWNonce()))
                {
                    return false;
                }
                // Validate the previous hash of the current block
                if (currentBlock.PreviousHash.Equals(previousBlock.MerkleRootHash))
                {
                    return false;
                }
            }
            return true;
        }
        //Tạo khối mới và thêm khối vô chuỗi
        private void button6_Click(object sender, EventArgs e)
        {
            int num = (int)numericUpDown1.Value;
            if (pendingTransactions.Count < num)
            {
                MessageBox.Show($"There must be at least {num} transactions to create a block.");
                return;
            }
            // Create a new block.
            Block newBlock = new Block(DateTime.Now, "PreviousHash", pendingTransactions.GetRange(0, num));
            // Add the block to the blockchain.
            ChungChiChain.AddBlock(newBlock);
            // Update the block panel with the new block details.
            AddOneBlockToGridView(newBlock);
            // Remove the transaction from the pending list.
            pendingTransactions.RemoveRange(0, num);
            PopulateDataGridView(pendingTransactions);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected block index
                int selectedBlockIndex = e.RowIndex;
                

                // Get the block from the blockchain
                Block selectedBlock = ChungChiChain.Chain[selectedBlockIndex+1];

                // Display the transactions of the selected block

                PopulateDataGridView(selectedBlock.Transactions);


            }
        }
    }
}
