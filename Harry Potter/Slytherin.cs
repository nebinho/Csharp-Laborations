using System;
using System.Collections.Generic;
using System.Text;

namespace Harry_Potter
{
    public class Slytherin : House
    {
        public Slytherin()
        {
            HouseGhost = "Blodige Baronen";
            Mascot = "Orm";
            Password = "Superior Slytherin";
            Members = new List<Wizard>();
        }

        #region Public password method override
        public override bool IsInputCorrect(string inputPass)
        {
            string consonant = "BbCcDdFfGgHhJjKkLlMmNnPpQqRrSsTtVvWwXxZz";
            char[] passToChar = inputPass.ToUpper().ToCharArray();

            if (inputPass.Length >= 8)
            {
                foreach (char c in consonant)
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
        #endregion
    }
}
