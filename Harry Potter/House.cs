using System;
using System.Collections.Generic;
using System.Text;

namespace Harry_Potter
{
    public abstract class House
    {
        public string HouseGhost { get; set; }
        public string Mascot { get; set; }       
        public string Password { get; set; }

        public bool CorrectPassword(string inputPass)
        {
            if (inputPass == Password)
            {
                return true;
            }
            return false; 
        }

        public virtual bool IsCorrectPasswordLength(string inputPass)
        {
            if (inputPass.Length >= 5)
            {
                return true;
            }
            return false;
        }

        public virtual bool IsFirstLetterCorrect(string inputPass)
        {
            string vowels = "aeiouyåäöAEIOUYÅÄÖ";
            char[] passToChar = inputPass.ToLower().ToCharArray();

            foreach (char c in vowels)
            {
                if (inputPass[0] == c)
                {
                    return true;
                }
            }
            return false;
        }
        public virtual bool HasPasswordConsonant(string inputPass)
        {
            string consonant = "BbCcDdFfGgHhJjKkLlMmNnPpQqRrSsTtVvWwXxZz";
            char[] passToChar = inputPass.ToLower().ToCharArray();

            foreach (char c in consonant)
            {
                if (inputPass[inputPass.Length - 1] == c)
                {
                    return true;
                }
            }
            return false;
        }
        public virtual string SetPassword(string inputPass, string oldPass)
        {
            if (CorrectPassword(oldPass) == true && IsFirstLetterCorrect(inputPass) == true && HasPasswordConsonant(inputPass) == true && IsCorrectPasswordLength(inputPass) == true)
            {
               Password = inputPass;
            }
            return Password;
        }
    }
}
