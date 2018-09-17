using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppMail
{
    static class Encryption
    {
        static public byte[] Salt { get; set; }

        static public string GetSalt()
        {
            return Encoding.Default.GetString(Salt);
        }

        static public string GetPasswordHash(string password)
        {
            var hashFunc = new Rfc2898DeriveBytes(password, Salt, 10);
            var hash = hashFunc.GetBytes(20);
            var passwordHash = Encoding.Default.GetString(hash);
            return passwordHash;
        }
    }
}
