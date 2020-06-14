using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_De_Dades___Diccionari
{
    public class DictionaryClass
    {
        public Dictionary <char, string> CreateDictionary()
        {
            Dictionary <char, string> diccionary = new Dictionary <char, string>();
            char letter = 'A';
            int numbers;
            bool repeatedNumber; 

            for (int i = 0; i < 26; i++)
            {
                numbers = RandomInt(0, 9999);

                repeatedNumber = CheckRepeated(numbers, diccionary);

                while (repeatedNumber)
                {
                    numbers = RandomInt(0, 9999);
                    repeatedNumber = CheckRepeated(numbers, diccionary);
                }

                diccionary.Add(letter, numbers.ToString().PadLeft(4, '0'));

                letter++;   
            }
           
            return diccionary; 
        }

        private bool CheckRepeated(int number, Dictionary <char, string> dictionary)
        {
            bool repeated = false;
            int dictionaryNumber; 

            foreach (var item in dictionary)
            {
                dictionaryNumber = int.Parse(item.Value);

                if (dictionaryNumber == number)
                {
                    repeated = true; 
                }
            }
            return repeated; 
        }

        private int RandomInt (int min, int max)
        {
            RNGCryptoServiceProvider RandomNumber = new RNGCryptoServiceProvider();

            uint scale = uint.MaxValue;
            while (scale == uint.MaxValue)
            {
                // Get four random bytes.
                byte[] four_bytes = new byte[4];
                RandomNumber.GetBytes(four_bytes);

                // Convert that into an uint.
                scale = BitConverter.ToUInt32(four_bytes, 0);
            }

            // Add min to the scaled difference between max and min.
            return (int)(min + (max - min) * (scale / (double)uint.MaxValue));
        }
    }
}
