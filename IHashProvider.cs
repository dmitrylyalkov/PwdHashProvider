namespace CodeLib.PwdHashProvider
{
    public interface IHashProvider
    {
        string GenerateHash(string password, byte[] salt);

        byte[] GenerateSalt();
    }
}
