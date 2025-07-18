using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class StringCipher
{
    public static readonly StringCipher Instance;

    private static readonly byte[] DefaultSalt;
    private static readonly byte[] DefaultInitVectorBytes;
    private static readonly string DefaultPassPhrase;

    private readonly byte[] InitVectorBytes;
    private const int Keysize = 256;

    static StringCipher()
    {
        DefaultPassPhrase = "R2y3N54Av6vgy866";
        DefaultInitVectorBytes = Encoding.ASCII.GetBytes("f3p5U3vgUaR5XM89");
        DefaultSalt = Encoding.ASCII.GetBytes("5O!RJdl6");
        Instance = new StringCipher();
    }

    public StringCipher()
    {
        InitVectorBytes = DefaultInitVectorBytes;
    }

    public string Decrypt(string cipherText, string passPhrase = null, byte[] salt = null)
    {
        if (string.IsNullOrEmpty(cipherText)) return null;

        passPhrase ??= DefaultPassPhrase;
        salt ??= DefaultSalt;

        var cipherTextBytes = Convert.FromBase64String(cipherText);
        using var password = new Rfc2898DeriveBytes(passPhrase, salt);
        var keyBytes = password.GetBytes(Keysize / 8);

        using var symmetricKey = Aes.Create();
        symmetricKey.Mode = CipherMode.CBC;

        using var decryptor = symmetricKey.CreateDecryptor(keyBytes, InitVectorBytes);
        using var memoryStream = new MemoryStream(cipherTextBytes);
        using var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);

        var plainTextBytes = new byte[cipherTextBytes.Length];
        var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);

        return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        string encrypted = "kbn/ji6m3SHxCplqeMyIbA==";
        string decrypted = StringCipher.Instance.Decrypt(encrypted);

        Console.WriteLine($"🔓 Contraseña desencriptada: {decrypted}");
    }
}
