using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift15
{
    class JibberishTranslator
    {
        public int NumberOfVowels(string input)
        {
            string allVowels = "aAeEiIoOuUyYåÅäÄöÖ";
            
            int nmbrOfVowels = 0;

            foreach (char c in input)
            {
                foreach (char d in allVowels)
                {
                    if (c == d)
                    {
                        nmbrOfVowels++;
                    }
                }
            }
            return nmbrOfVowels;
        }

        public bool IsLowerVowel(char c)
        {
            string lowerVowels = "aeiouyåäö";

            foreach (char d in lowerVowels)
            {
                if (c == d)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsUpperVowel(char c)
        {
            string upperVowels = "AEIOUYÅÄÖ";

            foreach (char d in upperVowels)
            {
                if (c == d)
                {
                    return true;
                }
            }
            return false;
        }

        public string Jibberish(string input)
        {
            char[] cInput = input.ToCharArray();

            for (int i = 0; i < cInput.Length; i++)
            {
                if (IsLowerVowel(cInput[i]))
                {
                    cInput[i] = 'ö';
                }
                else if (IsUpperVowel(cInput[i]))
                {
                    cInput[i] = 'Ö';
                }
            }
            string rootWelsh = new string(cInput);
            return rootWelsh;
        }
    }
}
