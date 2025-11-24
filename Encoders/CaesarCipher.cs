using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Encoders
{
    internal class CaesarCipher
    {
        public static string AlphabetUkrainian = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";
        public static string AlphabetEnglish = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string Alphabet = AlphabetUkrainian + AlphabetEnglish;

        public static string Encode(string input, int shift, string alphabet)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                result.Append(ShiftChar(c, shift, alphabet));
            }

            return result.ToString();
        }

        public static string Decode(string input, int shift, string alphabet)
        {
            return Encode(input, alphabet.Length - (shift % alphabet.Length), alphabet);
        }

        private static char ShiftChar(char c, int shift, string alphabet)
        {
            int index = alphabet.IndexOf(char.ToUpper(c));
            if (index == -1)
                return c;

            int shiftedIndex = (index + shift) % alphabet.Length;
            if (shiftedIndex < 0)
                shiftedIndex += alphabet.Length;

            char shiftedChar = alphabet[shiftedIndex];
            return char.IsUpper(c) ? shiftedChar : char.ToLower(shiftedChar);
        }
    }
}
