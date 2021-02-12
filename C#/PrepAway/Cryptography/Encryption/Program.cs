using System;
using System.Text;
using System.Security.Cryptography;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Secret Message";
            byte[] messageInByte = Encoding.UTF8.GetBytes(message);

            SymmetricAlgorithm symmetricAlgo = SymmetricAlgorithm.Create();

            ICryptoTransform encrypter = symmetricAlgo.CreateEncryptor(symmetricAlgo.Key,symmetricAlgo.IV);

            byte[] cipherMessage = encrypter.TransformFinalBlock(messageInByte,0,messageInByte.Length);
            
            string cipherMessageString = Encoding.UTF8.GetString(cipherMessage);

            System.Console.WriteLine(cipherMessageString);
        }
    }
}
