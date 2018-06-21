using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.EncryptAndDecrypt
{
    class encrypt
    {
        //Write a program that encrypts a text by applying XOR (excluding or) operation between the given source characters and given cipher code. The encryption should be done by applying XOR between the first letter of the text and the first letter of the code, the second letter of the text and the second letter of the code, etc. until the last letter of the code, then goes back to the first letter of the code and the next letter of the text. Print the result as a series of Unicode escape characters \xxxx.Sample source text: "Test". Sample cipher code: "ab". The result should be the following: "\u0035\u0007\u0012\u0016".
        public static string Encrypt(string value, string key)
        {
            var encryptedValue = new StringBuilder(value.Length);
            for (int i = 0; i < value.Length; i++)
            {
                encryptedValue.Append((char)(value[i] ^ key[i % key.Length]));
            }
            return encryptedValue.ToString();
        }


        static void Main(string[] args)
        {
            string message = "If you're acquainted with regular expressions from some other venue, we should warn you that regular expressions are a bit different in Perl. ";
            string key = "perl";

            Console.WriteLine("{0:x4}",Encrypt(message, key));

        }


    }
}
