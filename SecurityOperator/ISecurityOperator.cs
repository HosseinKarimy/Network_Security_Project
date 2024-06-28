namespace SecurityOperations;

public interface ISecurityOperator
{
    public string Hasher(string input, string salt);
    public string Encryptor(string plainText, string key);
    public string Decryptor(string cypherText, string key);
    public string Sign(string text, string key);
}
