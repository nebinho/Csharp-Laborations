using System;
using System.Collections.Generic;
using System.Text;

namespace Harry_Potter
{
    public class Wizard : House
    {
        #region Properties for wizard
        public string BloodStatus { get; set; }
        public bool DeathEater { get; set; }
        public bool DumbledoresArmy { get; set; }
        public string Name { get; set; }

        #endregion
        public static readonly Random random = new Random();

        public Wizard()
        {
            BloodStatus = new string[4] { "Renblod", "Halvblod", "Mugglarfödd", "Okänd" };
            DeathEater = false;
            DumbledoresArmy = false;
            Name = ""; 
        }

        public override string ToString()
        {
            return $"({Name})";
        }

        public string GetBloodStatus ()
        {
            int r = random.Next(1, 100);

            if (r <= 60)
            {
                BloodStatus = "Halvblod";
            }
            else if (r > 60 && r <= 85)
            {
                BloodStatus = "Mugglarfödd";
            }
            else if (r > 85 && r <= 95)
            {
                BloodStatus = "Fullblod";
            }
            else if (r > 95 && r <= 100)
            {
                BloodStatus = "Okänt";
            }
            return BloodStatus;
        }

        public bool GetDeathEater ()
        {
            int r = random.Next(1, 100);

            if (BloodStatus == "Halvblod")
            {
                if (r <= 25)
                {
                    return true;
                }
            }
            else if (BloodStatus == "Mugglarfödd")
            {
                if (r <= 15)
                {
                    return true;
                }
            }
            else if (BloodStatus == "Fullblod")
            {
                if (r <= 60)
                {
                    return true;
                }
            }
            else if (BloodStatus == "Okänt")
            {
                if (r  <= 25)
                {
                    return true;
                }
            }
            return false;
        }

        public bool GetDumbledoresArmy()
        {
            int r = random.Next(1, 100);

            if (!DeathEater)
            {
                if (r <= 45)
                {
                    return true;
                }
            }
            else if (DeathEater)
            {
                if (r <= 25)
                {
                    return true;
                }
            }
            return false;       
        }

    }
}
