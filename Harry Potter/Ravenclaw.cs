using System;
using System.Collections.Generic;
using System.Text;

namespace Harry_Potter
{
    public class Ravenclaw : House
    {
        public Ravenclaw()
        {
            HouseGhost = "Grå Damen";
            Mascot = "Örn";
            Password = "Onödiga Ravenclaw";
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }

    }
}
