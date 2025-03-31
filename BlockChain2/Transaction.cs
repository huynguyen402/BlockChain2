using System;
using System.Security.Cryptography;
using System.Text;

namespace BlockChain2
{
    public class Transaction
    {
        public string ToChucCap { get; set; }
        public string TenNguoiNhan { get; set; }
        public string CCCD { get; set; }
        public DateTime NgayCap { get; set; }
        public DateTime NgayHetHan { get; set; }
        public string Hash { get; set; }
        public string DigitalSignature { get; set; }

        public Transaction(string ToChucCap, string TenNguoiNhan, string CCCD, DateTime NgayCap, DateTime NgayHetHan)
        {
            this.ToChucCap = ToChucCap;
            this.TenNguoiNhan = TenNguoiNhan;
            this.CCCD = CCCD;
            this.NgayCap = NgayCap;
            this.NgayHetHan = NgayHetHan;
            Hash = ComputeHash();
            DigitalSignature = SignTransaction();
        }

        public string ComputeHash()
        {
            string input = $"{ToChucCap}{TenNguoiNhan}{CCCD}{NgayCap.ToString("o")}{NgayHetHan.ToString("o")}";
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(bytes).Replace("-", "");
            }
        }

        private string SignTransaction()
        {
            // Ví dụ minh họa: Tạo chữ ký số bằng cách sử dụng RSA.
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                byte[] dataBytes = Encoding.UTF8.GetBytes(Hash);
                // Dùng SHA256 để tính toán chữ ký
                byte[] signatureBytes = rsa.SignData(dataBytes, new SHA256CryptoServiceProvider());
                return Convert.ToBase64String(signatureBytes);
            }
        }

        public string PrintTransaction()
        {
            return $"{ToChucCap}-{TenNguoiNhan}-{CCCD}-{NgayCap}-{NgayHetHan}-{DigitalSignature}";
        }
    }
}
