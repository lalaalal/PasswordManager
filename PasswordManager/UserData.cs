using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PasswordManager
{
    public class UserData : Dictionary<string, string>
    {
        private static readonly string USER_DATA_PATH = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"PasswordManager\user.txt");

        private static UserData userData;

        public static UserData GetInstance()
        {
            if (userData == null)
                userData = new UserData();
            return userData;
        }

        private UserData()
        {
            if (!System.IO.File.Exists(USER_DATA_PATH))
                System.IO.File.Create(USER_DATA_PATH).Close();
                
            string[] lines = System.IO.File.ReadAllLines(USER_DATA_PATH);
            foreach (string line in lines)
            {
                string[] data = line.Split(';');
                base.Add(data[0], data[1]);
            }
        }

        // May not used
        public string GetPassword(string id)
        {
            string pw;
            if (TryGetValue(id, out pw))
                throw new KeyNotFoundException();

            return pw;
        }

        public void Save()
        {
            using (System.IO.TextWriter writer = new System.IO.StreamWriter(USER_DATA_PATH))
                foreach (var user in this)
                    writer.WriteLine(user.Key + ';' + user.Value);
        }

        public bool IdExists(string id)
        {
            return ContainsKey(id);
        }

        public bool Authorize(string id, string pw)
        {
            if (!TryGetValue(id, out string cmp_pw))
                throw new Exception("No such ID");
            string salt = cmp_pw.Split('@')[0];
            return cmp_pw == SHA256Hash(pw, salt);
        }

        public new void Add(string id, string pw)
        {
            string salt = Guid.NewGuid().ToString();
            base.Add(id, SHA256Hash(pw, salt));
        }

        public static string SHA256Hash(string data, string salt)
        {
            SHA256 sha = new SHA256Managed();
            byte[] hash = sha.ComputeHash(Encoding.ASCII.GetBytes(data + salt));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in hash)
            {
                stringBuilder.AppendFormat("{0:x2}", b);
            }
            return salt + "@" + stringBuilder.ToString();
        }
    }
}
