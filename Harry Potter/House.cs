using System;
using System.Collections.Generic;
using System.Text;

namespace Harry_Potter
{
    public abstract class House
    {
        #region Properties for student homes
        public string HouseGhost { get; set; }
        public string Mascot { get; set; }
        public string Password { get; set; }
        public List<Wizard> Members { get; set; }
        #endregion

        public House()
        {
            Members = new List<Wizard>();
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }

        #region Public password methods
        public virtual bool IsInputCorrect(string inputPass, string oldPass)
        {
            string consonant = "BbCcDdFfGgHhJjKkLlMmNnPpQqRrSsTtVvWwXxZz";
            string vowels = "aeiouyåäöAEIOUYÅÄÖ";
            char[] passToChar = inputPass.ToUpper().ToCharArray();

            if (oldPass == Password && inputPass.Length >= 5)
            {
                foreach (char c in vowels)
                {
                    if (inputPass[0] == c)
                    {
                        foreach (char d in consonant)
                        {
                            if (inputPass[inputPass.Length - 1] == d)
                            {
                                return true;
                            }
                        }                       
                    }
                }
            }
            return false;
        }

        public string SetPassword(bool IsInputCorrect, string inputPass)
        {
            if (IsInputCorrect == true)
            {
                Password = inputPass;
            }
            return Password;
        }

        //public virtual bool IsCorrectPasswordLength(string inputPass)
        //{
        //    if (inputPass.Length >= 5)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public virtual bool IsFirstLetterCorrect(string inputPass)
        //{
        //    string vowels = "aeiouyåäöAEIOUYÅÄÖ";
        //    char[] passToChar = inputPass.ToLower().ToCharArray();

        //    foreach (char c in vowels)
        //    {
        //        if (inputPass[0] == c)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //public bool HasPasswordConsonant(string inputPass)
        //{
        //    string consonant = "BbCcDdFfGgHhJjKkLlMmNnPpQqRrSsTtVvWwXxZz";
        //    char[] passToChar = inputPass.ToUpper().ToCharArray();

        //    foreach (char c in consonant)
        //    {
        //        if (inputPass[inputPass.Length - 1] == c)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        #endregion
    }
}
