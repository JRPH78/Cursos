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
        string encrypted = "4UyG06RhVVsyuD+mGwGR1Q==";
        string decrypted = StringCipher.Instance.Decrypt(encrypted);
        string nueva = new Contrasenas().Generar();


        Console.WriteLine($"nueva contra {nueva}");
        Console.WriteLine($"🔓 Contraseña Encryptada: {encrypted}");
        Console.WriteLine($"🔓 Contraseña desencriptada: {decrypted}");
    }
}

public class OpcionesContrasena
{
    public int LonguitudMinima { get; set; }
    public int CaracteresUnicosRequeridos { get; set; }
    public bool DigitoRequerido { get; set; }
    public bool MinusculaRequerida { get; set; }
    public bool CaracterEspecialRequerido { get; set; }
    public bool MayusculaRequerida { get; set; }
}
public class Contrasenas
{
    public string Generar(OpcionesContrasena opts = null)
    {
        if (opts == null) opts = new OpcionesContrasena()
        {
            LonguitudMinima = 8,
            CaracteresUnicosRequeridos = 4,
            DigitoRequerido = true,
            MinusculaRequerida = true,
            CaracterEspecialRequerido = true,
            MayusculaRequerida = true
        };

        string[] randomChars = new[] {
                    "ABCDEFGHJKLMNOPQRSTUVWXYZ",    // uppercase 
                    "abcdefghijkmnopqrstuvwxyz",    // lowercase
                    "0123456789",                   // digits
                    "!@$?_-"                        // non-alphanumeric
                };

        Random rand = new Random(Environment.TickCount);
        List<char> chars = new List<char>();

        if (opts.MayusculaRequerida)
            chars.Insert(rand.Next(0, chars.Count),
                randomChars[0][rand.Next(0, randomChars[0].Length)]);

        if (opts.MinusculaRequerida)
            chars.Insert(rand.Next(0, chars.Count),
                randomChars[1][rand.Next(0, randomChars[1].Length)]);

        if (opts.DigitoRequerido)
            chars.Insert(rand.Next(0, chars.Count),
                randomChars[2][rand.Next(0, randomChars[2].Length)]);

        if (opts.CaracterEspecialRequerido)
            chars.Insert(rand.Next(0, chars.Count),
                randomChars[3][rand.Next(0, randomChars[3].Length)]);

        for (int i = chars.Count; i < opts.LonguitudMinima
            || chars.Distinct().Count() < opts.CaracteresUnicosRequeridos; i++)
        {
            string rcs = randomChars[rand.Next(0, randomChars.Length)];
            chars.Insert(rand.Next(0, chars.Count),
                rcs[rand.Next(0, rcs.Length)]);
        }

        return new string(chars.ToArray());
    }
}