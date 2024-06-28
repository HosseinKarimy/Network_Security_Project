using System.Security.Cryptography;
using System.Text;

namespace SecurityOperations;

public class SecurityOperator : ISecurityOperator
{
    public string Decryptor(string cypherText, string key)
    {
        using Aes aesAlg = Aes.Create();
        var hashedKey = Hasher(key);
        var expandedKey = Encoding.UTF8.GetBytes(hashedKey[..32]);
        aesAlg.Key = expandedKey;
        aesAlg.Mode = CipherMode.CBC;
        aesAlg.IV = expandedKey[..16];

        //var realCypherText = cypherText[16..];
        //var iv = Convert.FromBase64String(cypherText[..16]);
        //aesAlg.IV = iv;

        ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

        using MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cypherText));
        using CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
        using StreamReader srDecrypt = new StreamReader(csDecrypt);
        return srDecrypt.ReadToEnd();
    }

    public string Encryptor(string plainText, string key)
    {
        using Aes aesAlg = Aes.Create();
        var hashedKey = Hasher(key);
        var expandedKey = Encoding.UTF8.GetBytes(hashedKey[..32]);
        aesAlg.Key = expandedKey;
        aesAlg.Mode = CipherMode.CBC;
        aesAlg.IV = expandedKey[..16];

        ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

        using MemoryStream msEncrypt = new();
        using (CryptoStream csEncrypt = new(msEncrypt, encryptor, CryptoStreamMode.Write))
        {
            using StreamWriter swEncrypt = new(csEncrypt);
            swEncrypt.Write(plainText);
        }
        byte[] encryptedBytes = msEncrypt.ToArray();
        return Convert.ToBase64String(encryptedBytes);
    }

    public string Hasher(string input, string salt = "")
    {
        byte[] bytes = Encoding.UTF8.GetBytes(salt + input);
        byte[] hash = SHA256.HashData(bytes);
        return BitConverter.ToString(hash).Replace("-", "").ToLower();
    }

    public string Sign(string text, string key)
    {
        return Encryptor(Hasher(text), key);
    }
}


