﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Harry_Potter
{
    public class Hufflepuff : House
    {
        public Hufflepuff()
        {
            HouseGhost = "Den Tjocke Munkbrodern";
            Mascot = "Grävling";
            Password = "Original Hufflepuff";
            Members = new List<Wizard>();
        }
    }
}
