using System.Security.Cryptography;
using System.Text;

namespace Operations.SecurityOperations;

public class SecurityOperator : ISecurityOperator
{
    public string? Decryptor(string cypherText, string key)
    {        
        try
        {
            using Aes aesAlg = Aes.Create();
            var hashedKey = Hasher(key);
            var expandedKey = Encoding.UTF8.GetBytes(hashedKey[..32]);
            aesAlg.Key = expandedKey;

            var cypherByte = Convert.FromBase64String(cypherText);
            aesAlg.Mode = CipherMode.CBC;
            aesAlg.IV = cypherByte[..16];


            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using MemoryStream msDecrypt = new MemoryStream(cypherByte[16..]);
            using CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
            using StreamReader srDecrypt = new StreamReader(csDecrypt);
            return srDecrypt.ReadToEnd();
        }
        catch (Exception)
        {
            return null;
        }

    }

    public string Encryptor(string plainText, string key)
    {
        using Aes aesAlg = Aes.Create();
        var hashedKey = Hasher(key);
        var expandedKey = Encoding.UTF8.GetBytes(hashedKey[..32]);
        aesAlg.Key = expandedKey;
        aesAlg.Mode = CipherMode.CBC;
        aesAlg.GenerateIV();

        ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

        using MemoryStream msEncrypt = new();
        using (CryptoStream csEncrypt = new(msEncrypt, encryptor, CryptoStreamMode.Write))
        {
            using StreamWriter swEncrypt = new(csEncrypt);
            swEncrypt.Write(plainText);
        }
        byte[] encryptedBytes = msEncrypt.ToArray();
        return Convert.ToBase64String(aesAlg.IV.Concat(encryptedBytes).ToArray());
    }

    public string Hasher(string input, string salt = "")
    {
        byte[] bytes = Encoding.UTF8.GetBytes(salt + input);
        byte[] hash = SHA256.HashData(bytes);
        return BitConverter.ToString(hash).Replace("-", "").ToLower();
    }

    public bool IsSameSign(string signedText, string checkText, string key)
    {
        var decryptedSignedText = Decryptor(signedText, key);

        if (decryptedSignedText == Hasher(checkText))
            return true;
        return false;
    }

    public string Sign(string text, string key)
    {
        return Encryptor(Hasher(text), key);
    }
}



