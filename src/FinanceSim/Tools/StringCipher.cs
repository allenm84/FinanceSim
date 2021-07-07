using System;
using System.Security.Cryptography;
using System.Text;
using CredentialManagement;

namespace FinanceSim
{
  public static class StringCipher
  {
    static readonly char Id;
    static StringCipher()
    {
      Id = Convert.ToChar(1337);
    }

    public static string Decrypt(string key, string content)
    {
      if (content[0] != Id)
      {
        return content;
      }

      var password = GetPassword(key);
      return DecryptString(password, content.Substring(1));
    }

    public static string Encrypt(string key, string content)
    {
      var password = GetPassword(key);
      var text = EncryptString(password, content);
      return $"{Id}{text}";
    }

    private static TripleDESCryptoServiceProvider CreateProvider(string password)
    {
      var bytes = Encoding.UTF8.GetBytes(password);
      using (var md5 = new MD5CryptoServiceProvider())
      {
        return new TripleDESCryptoServiceProvider
        {
          Key = md5.ComputeHash(bytes),
          Mode = CipherMode.ECB,
          Padding = PaddingMode.PKCS7
        };
      }
    }

    public static string EncryptString(string password, string plainInput)
    {
      using (var tdes = CreateProvider(password))
      {
        var toEncryptArray = Encoding.UTF8.GetBytes(plainInput);
        var encryptor = tdes.CreateEncryptor();
        var resultArray = encryptor.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
        return Convert.ToBase64String(resultArray, 0, resultArray.Length);
      }
    }

    public static string DecryptString(string password, string cipherText)
    {
      using (var tdes = CreateProvider(password))
      {
        var toDecryptArray = Convert.FromBase64String(cipherText);
        var decryptor = tdes.CreateDecryptor();
        var resultArray = decryptor.TransformFinalBlock(toDecryptArray, 0, toDecryptArray.Length);
        return Encoding.UTF8.GetString(resultArray);
      }
    }

    private static void SavePassword(string key, string password)
    {
      using (var cred = new Credential())
      {
        cred.Password = password;
        cred.Target = key;
        cred.Type = CredentialType.Generic;
        cred.PersistanceType = PersistanceType.LocalComputer;
        cred.Save();
      }
    }

    private static string GetPassword(string key)
    {
      using (var cred = new Credential())
      {
        cred.Target = key;
        if (!cred.Load())
        {
          var prompt = new VistaPrompt();
          prompt.GenericCredentials = true;
          prompt.ShowDialog();

          var password = prompt.Password;
          SavePassword(key, password);
          return password;
        }
        else
        {
          return cred.Password;
        }
      }
    }
  }
}
