using System;
using System.Security.Cryptography;
using System.Text;

namespace FinanceSim
{
  public static class StringCipher
  {
    private static string GetKey()
      => Environment.GetEnvironmentVariable("STRING_CIPHER_KEY");

    private static TripleDESCryptoServiceProvider CreateProvider(string password)
    {
      var bytes = Encoding.UTF8.GetBytes(password);
      using var md5 = new MD5CryptoServiceProvider();
      return new TripleDESCryptoServiceProvider
      {
        Key = md5.ComputeHash(bytes),
        Mode = CipherMode.ECB,
        Padding = PaddingMode.PKCS7
      };
    }

    public static string Encrypt(string content)
      => Encrypt(GetKey(), content);

    public static string Encrypt(string key, string content)
    {
      using var tdes = CreateProvider(key);
      var toEncryptArray = Encoding.UTF8.GetBytes(content);
      var encryptor = tdes.CreateEncryptor();
      var resultArray = encryptor.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
      return Convert.ToBase64String(resultArray);
    }

    public static string Decrypt(string content)
      => Decrypt(GetKey(), content);

    public static string Decrypt(string key, string content)
    {
      using var tdes = CreateProvider(key);
      var toDecryptArray = Convert.FromBase64String(content);
      var decryptor = tdes.CreateDecryptor();
      var resultArray = decryptor.TransformFinalBlock(toDecryptArray, 0, toDecryptArray.Length);
      return Encoding.UTF8.GetString(resultArray);
    }
  }
}
