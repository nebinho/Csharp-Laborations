using System;
using System.Collections.Generic;
using System.Text;

namespace Harry_Potter
{
    class Slytherin : House
    {
        public Slytherin()
        {
            HouseGhost = "Blodige Baronen";
            Mascot = "Orm";
            Password = "Superior Slytherin";
        }

        public override bool IsCorrectPasswordLength(string inputPass)
        {
            if (inputPass.Length >= 8)
            {
                return true;
            }
            return false;
        }

        public override bool IsFirstLetterCorrect(string inputPass)
        {
            string consonant = "BbCcDdFfGgHhJjKkLlMmNnPpQqRrSsTtVvWwXxZz";
            char[] passToChar = inputPass.ToLower().ToCharArray();

            foreach (char c in consonant)
            {
                if (inputPass[0] == c)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
