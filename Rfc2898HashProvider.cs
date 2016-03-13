namespace CodeLib.PwdHashProvider
{
    using System;
    using System.Security.Cryptography;

    public class Rfc2898HashProvider : IHashProvider
    {
        private const int hashSize = 25;
        private const int saltSize = 8;

        public string GenerateHash(string password, byte[] salt)
        {
            using (var hasher = new Rfc2898DeriveBytes(password ?? string.Empty, salt))
            {
                return Convert.ToBase64String(hasher.GetBytes(hashSize));
            }
        }

        public byte[] GenerateSalt()
        {
            using (var hasher = new Rfc2898DeriveBytes(string.Empty, saltSize))
            {
                return hasher.Salt;
            }
        }
    }
}
