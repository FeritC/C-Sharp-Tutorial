using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exp3
{
    internal class Encrypt
    {
        public static string Rot2(string text)
        {
            char[] array = text.ToCharArray();
            int index = 0;
            foreach (var character in array)
            {
                int val = (int)character;

                array[index] = (char)(val + 2);
                index++;
            }

            return new string(array);
        }

        public static void Encipher(char[] input, int key, out bool success, Label successLabel, ref string encryptedMessage)
        {
            encryptedMessage = string.Empty;
            if (input.Length < 2)
            {
                success = false;
                successLabel.Text = "Failed";
                return;
            }
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                Cipher(ref ch, key);
                encryptedMessage += ch;
            }
            success = true;
            successLabel.Text = "Success";
        }

        public static void Cipher(ref char ch, int key)
        {
            if (char.IsLetter(ch))
            {
                char d = char.IsUpper(ch) ? 'A' : 'a';
                ch = (char)((((ch + key) - d) % 26) + d);
            }
        }
    }
}