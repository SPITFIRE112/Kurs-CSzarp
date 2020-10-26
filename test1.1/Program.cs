using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace test1._1
{
   
        
    class Program
    {
     


        static void Main(string[] args)
        {
               //char[,] tablica = new char[400, 2];
           
            
        
            //string klucz = "D^LGZM\"vEm~.V)2FxqcsX6@Y=3;Q-UW8{[j4dh5N#<b?/],pyK"; // 50 characters to full security
                            


             /*for (int i = 0; i < klucz.Length; i++)
			{
                    tablica[i, 0] = (char)(i+33);
                tablica[i, 1]= klucz[i];
            }
           */
            



      
			
        
            Console.WriteLine("Wpisz tekst");
            string tekst = Console.ReadLine();


            using (Aes myAes = Aes.Create())
            {

                // Szyfrowanie
                byte[] zaszyfrowane = EncryptStringToBytes_Aes(tekst, myAes.Key, myAes.IV);

                // Deszyfrowanie
                string odszyfrowane = DecryptStringFromBytes_Aes(zaszyfrowane, myAes.Key, myAes.IV);
                  string zakodowane = System.Text.Encoding.UTF8.GetString(zaszyfrowane);
                //Display the original data and the decrypted data.
                Console.WriteLine("Zaszyfrowane:   {0}", zakodowane);
                Console.WriteLine("Odszyfrowane: {0}", odszyfrowane);
            }

          

         /*
            for (int i = 0; i < tablica.Length/2; i++)
			{
                Console.Write("Zamieniam" + tablica [ i, 1]);
                Console.WriteLine("na" + tablica[ i, 0]);
                tekst = tekst.Replace(tablica[i, 0], tablica[i, 1]);
            }
           Console.WriteLine("Zaszyfrowany");
            Console.WriteLine(tekst);
            Console.WriteLine("Odszyfrowany");

              for (int i = 0; i < tablica.Length/2; i++)
			{
                
              //  Console.Write("Zamieniam" + tablica [ i, 1]);
               // Console.WriteLine("na" + tablica[ i, 0]);
                tekst = tekst.Replace(tablica[i, 1], tablica[i, 0]);
            }
           */
                Console.WriteLine(tekst);


            Main(args);
           
    
       }
         static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }




    }




}
