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

        public override bool IsInputCorrect(string inputPass, string oldPass)
        {
            string consonant = "BbCcDdFfGgHhJjKkLlMmNnPpQqRrSsTtVvWwXxZz";
            char[] passToChar = inputPass.ToUpper().ToCharArray();

            if (oldPass == Password && inputPass.Length >= 8)
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

        //public override bool IsCorrectPasswordLength(string inputPass)
        //{
        //    if (inputPass.Length >= 8)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public override bool IsFirstLetterCorrect(string inputPass)
        //{
        //    string consonant = "BbCcDdFfGgHhJjKkLlMmNnPpQqRrSsTtVvWwXxZz";
        //    char[] passToChar = inputPass.ToLower().ToCharArray();

        //    foreach (char c in consonant)
        //    {
        //        if (inputPass[0] == c)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
}
