using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStoreManagementSystem.Helpers
{
    public static class CryptingHelper
    {
        public const string ALPHABET = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%-_*+=";
        public static string Encrypt(string text)
        {
            string cryptedText = string.Empty;

            foreach (var ch in text)
            {
                int index = ALPHABET.IndexOf(ch);
                cryptedText += index;
                cryptedText += "#";
            }

            return cryptedText.Remove(cryptedText.Length - 1);
        }

        public static string Decrypt(string text)
        {
            var splittedText = text.Split('#');
            string result = string.Empty;

            for (int i = 0; i < splittedText.Length; i++)
            {
                int index = int.Parse(splittedText[i]);
                result += ALPHABET[index];
            }

            return result;
        }
    }
}
