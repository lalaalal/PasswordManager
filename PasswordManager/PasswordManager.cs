using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Cryptography;
using System.IO;

namespace PasswordManager
{
    public class PasswordManager : Dictionary<string, string>
    {
        private readonly string PASSWORD_DATA_PATH;
        private readonly string key;

        public PasswordManager(string userID, string userPW)
        {
            key = userPW;
            if (!UserData.GetInstance().Authorize(userID, userPW))
                throw new Exception("Authorize Failed");
            PASSWORD_DATA_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"PasswordManager\" + userID + ".pw");

            Load();
        }

        public new void Add(string name, string password)
        {   
            string encryptedPassword = Encrypt(password, key);
            base.Add(name, encryptedPassword);
        }

        // TODO: Handle Exception 
        public new bool TryGetValue(string name, out string password)
        {
            bool res = base.TryGetValue(name, out string encryptedPassword);
            password = Decrypt(encryptedPassword, key);
            return res;
        }

        public static string Decrypt(string textToDecrypt, string key)
        {
            byte[] pwdBytes = Encoding.UTF8.GetBytes(key);
            byte[] keyBytes = new byte[16];
            int len = pwdBytes.Length;
            if (len > keyBytes.Length)
                len = keyBytes.Length;
            Array.Copy(pwdBytes, keyBytes, len);

            RijndaelManaged rijndaelCipher = new RijndaelManaged
            {
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7,
                KeySize = 128,
                BlockSize = 128,
                Key = keyBytes,
                IV = keyBytes
            };

            byte[] encryptedData = Convert.FromBase64String(textToDecrypt);
            byte[] plainText = rijndaelCipher.CreateDecryptor().TransformFinalBlock(encryptedData, 0, encryptedData.Length);
            return Encoding.UTF8.GetString(plainText);
        }

        public static string Encrypt(string textToEncrypt, string key)
        {
            byte[] pwdBytes = Encoding.UTF8.GetBytes(key);
            byte[] keyBytes = new byte[16];
            int len = pwdBytes.Length;
            if (len > keyBytes.Length)
                len = keyBytes.Length;
            Array.Copy(pwdBytes, keyBytes, len);

            RijndaelManaged rijndaelCipher = new RijndaelManaged
            {
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7,
                KeySize = 128,
                BlockSize = 128,
                Key = keyBytes,
                IV = keyBytes
            };
            
            ICryptoTransform transform = rijndaelCipher.CreateEncryptor();
            byte[] plainText = Encoding.UTF8.GetBytes(textToEncrypt);
            return Convert.ToBase64String(transform.TransformFinalBlock(plainText, 0, plainText.Length));
        }

        public void Load()
        {
            if (!File.Exists(PASSWORD_DATA_PATH))
                File.Create(PASSWORD_DATA_PATH).Close();

            string[] lines = File.ReadAllLines(PASSWORD_DATA_PATH);
            foreach (string line in lines)
            {
                string[] data = line.Split(';');
                base.Add(data[0], data[1]);
            }
        }

        public void Save()
        {
            using (TextWriter textWriter = new StreamWriter(PASSWORD_DATA_PATH)) 
                foreach (var data in this)
                    textWriter.WriteLine(data.Key + ';' + data.Value);
        }
    }
}
