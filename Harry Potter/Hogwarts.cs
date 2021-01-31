using System;
using System.Collections.Generic;
using System.Text;

namespace Harry_Potter
{
    public class Hogwarts
    {
        public Gryffindor gryffindor { get; set; }
        public Hufflepuff hufflepuff { get; set; }
        public Ravenclaw ravenclaw { get; set; }
        public Slytherin slytherin { get; set; }

        public Hogwarts()
        {
            gryffindor = new Gryffindor();
            hufflepuff = new Hufflepuff();
            ravenclaw = new Ravenclaw();
            slytherin = new Slytherin();
        }

        int count = 0;
        public House SortingHat(Wizard wizard)
        {
            if (count == 0)
            {
                hufflepuff.Members.Add(wizard);
                count++;
                return hufflepuff;
            }
            else if (count == 1)
            {
                ravenclaw.Members.Add(wizard);
                count++;
                return ravenclaw;
            }
            else if (count == 2)
            {
                gryffindor.Members.Add(wizard);
                count++;
                return gryffindor;
            }
            else
            {
                slytherin.Members.Add(wizard);
                count = 0;
                return slytherin;
            }
        }
    }
}
