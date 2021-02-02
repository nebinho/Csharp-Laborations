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

        public override string ToString()
        {
            return this.GetType().Name;
        }

        #region Public password methods
        public virtual bool IsInputCorrect(string inputPass)
        {
            string consonant = "BbCcDdFfGgHhJjKkLlMmNnPpQqRrSsTtVvWwXxZz";
            string vowels = "aeiouyåäöAEIOUYÅÄÖ";
            char[] passToChar = inputPass.ToUpper().ToCharArray();

            if (inputPass.Length >= 5)
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

        public bool IsPasswordCorrect(string oldPass)
        {
            if (oldPass == Password)
            {
                return true;
            }
            return false;
        }

        public bool SetPassword(string inputPass, string oldPass)
        {
            if (IsPasswordCorrect(oldPass) && IsInputCorrect(inputPass))
            {
                Password = inputPass;
                return true;
            }
            return false;
        }
        #endregion
    }
}
