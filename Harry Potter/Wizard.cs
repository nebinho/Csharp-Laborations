using System;
using System.Collections.Generic;
using System.Text;

namespace Harry_Potter
{
    class Wizard : House
    {
        public string[] BloodStatus { get; set; }
        public bool DeathEater { get; set; }
        public bool DumbledoresArmy { get; set; }
        public string Name { get; set; }
        
        public Wizard()
        {
            BloodStatus = new string[4] { "Renblod", "Halvblod", "Mugglarfödd", "Okänd" };
            DeathEater = false;
            DumbledoresArmy = false;
            Name = ""; 
        }
    }
}
