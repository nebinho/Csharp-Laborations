using System;
using System.Collections.Generic;
using System.Text;

namespace Harry_Potter
{
    public class Gryffindor : House
    {
        public Gryffindor()
        {
            HouseGhost = "Nästan Huvudlöse Nick";
            Mascot = "Lejon";
            Password = "Älskade Gryffindor";
            Members = new List<Wizard>();
        }
    }
}
