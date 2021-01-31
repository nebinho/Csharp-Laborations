using System;
using System.Collections.Generic;
using System.Text;

namespace Harry_Potter
{
    public class Wizard
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
            BloodStatus = GetBloodStatus();
            DeathEater = GetDeathEater();
            DumbledoresArmy = GetDumbledoresArmy();
            Name = ""; 
        }

        public override string ToString()
        {
            return $"{Name}";
        }

        public string GetBloodStatus ()
        {
            int r = random.Next(1, 101);

            if (r >= 1 && r <= 60)
            {
                BloodStatus = "Halvblod";
            }
            else if (r >= 61 && r <= 85)
            {
                BloodStatus = "Mugglarfödd";
            }
            else if (r >= 86 && r <= 95)
            {
                BloodStatus = "Fullblod";
            }
            else if (r >= 96 && r <= 100)
            {
                BloodStatus = "Okänt";
            }
            return BloodStatus;
        }

        public bool GetDeathEater ()
        {
            int r = random.Next(1, 101);

            if (BloodStatus == "Halvblod")
            {
                if (r >= 1 && r <= 25)
                {
                    return true;
                }
            }
            else if (BloodStatus == "Mugglarfödd")
            {
                if (r >= 1 && r <= 15)
                {
                    return true;
                }
            }
            else if (BloodStatus == "Fullblod")
            {
                if (r >= 1 && r <= 60)
                {
                    return true;
                }
            }
            else if (BloodStatus == "Okänt")
            {
                if (r >= 1 && r  <= 25)
                {
                    return true;
                }
            }
            return false;
        }

        public bool GetDumbledoresArmy()
        {
            int r = random.Next(1, 101);

            if (!DeathEater)
            {
                if (r >= 1 && r <= 45)
                {
                    return true;
                }
            }
            else if (DeathEater)
            {
                if (r >= 1 && r <= 25)
                {
                    return true;
                }
            }
            return false;       
        }

    }
}
