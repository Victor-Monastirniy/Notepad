using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Encoders
{
    internal class GammaCipher
    {
        public static string AlphabetUkrainian = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";
        public static string AlphabetEnglish = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string Alphabet = AlphabetUkrainian + AlphabetEnglish;


        public static string GenerateGammaKey(int length, string alphabet)
        {
            Random rnd = new Random();
            StringBuilder gamma = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                gamma.Append(alphabet[rnd.Next(0, alphabet.Length)]);
            }
            return gamma.ToString();
        }

        public static string Encode(string input, string key, string alphabet)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                int cIndex = alphabet.IndexOf(char.ToUpper(c));
                if (cIndex != -1)
                {
                    int gIndex = alphabet.IndexOf(char.ToUpper(key[i % key.Length]));
                    int encodedIndex = (cIndex + gIndex) % alphabet.Length;
                    result.Append(char.IsUpper(c) ? alphabet[encodedIndex] : char.ToLower(alphabet[encodedIndex]));
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        public static string Decode(string encodedInput, string key, string alphabet)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < encodedInput.Length; i++)
            {
                char c = encodedInput[i];
                int cIndex = alphabet.IndexOf(char.ToUpper(c));
                if (cIndex != -1)
                {
                    int gIndex = alphabet.IndexOf(char.ToUpper(key[i % key.Length]));
                    int decodedIndex = (cIndex - gIndex) % alphabet.Length;
                    if (decodedIndex < 0)
                        decodedIndex += alphabet.Length;
                    result.Append(char.IsUpper(c) ? alphabet[decodedIndex] : char.ToLower(alphabet[decodedIndex]));
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}
