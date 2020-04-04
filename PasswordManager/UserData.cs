using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PasswordManager
{
    public class UserData
    {
        private const string USER_DATA_PATH = @"user.txt";

        private Dictionary<string, string> users;
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
                
            users = new Dictionary<string, string>();
            string[] lines = System.IO.File.ReadAllLines(USER_DATA_PATH);
            foreach (string line in lines)
            {
                string[] data = line.Split(';');
                users.Add(data[0], data[1]);
            }
        }

        // May not used
        public string GetPassword(string id)
        {
            string pw;
            if (users.TryGetValue(id, out pw))
                throw new KeyNotFoundException();

            return pw;
        }

        public void Save()
        {
            System.IO.TextWriter writer = new System.IO.StreamWriter(USER_DATA_PATH);

            foreach (var user in users)
                writer.WriteLine(user.Key + ';' + user.Value);

            writer.Close();
        }

        public bool IdExists(string id)
        {
            return users.ContainsKey(id);
        }

        public bool Authorize(string id, string pw)
        {
            string cmp_pw;
            return users.TryGetValue(id, out cmp_pw) && cmp_pw == HashString(pw);
        }

        // Add password hash
        public void AddUser(string id, string pw)
        {
            users.Add(id, HashString(pw));
        }

        public byte[] Hash(string str)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(str));
        }

        public string HashString(string inputString)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in Hash(inputString))
                stringBuilder.Append(b.ToString("X2"));

            return stringBuilder.ToString();
        }
    }
}
