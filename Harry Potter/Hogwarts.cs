using System;
using System.Collections.Generic;
using System.Text;

namespace Harry_Potter
{
    public class Hogwarts
    {
        public Gryffindor Gryffindor { get; set; }
        public Hufflepuff Hufflepuff { get; set; }
        public Ravenclaw Ravenclaw { get; set; }
        public Slytherin Slytherin { get; set; }

        public List<Wizard> wizards { get; set; }



        public Hogwarts()
        {
            Gryffindor = new Gryffindor();
            Hufflepuff = new Hufflepuff();
            Ravenclaw = new Ravenclaw();
            Slytherin = new Slytherin();

            wizards = new List<Wizard>();
        }

        public House SortingHat(Wizard wizard)
        {
            int count = 0;

            if (count == 0)
            {

                count++;
                //return gryff
            }
            else if (count == 1)
            {

                count++;
                //return huff
            }
            else if (count == 2)
            {

                count++;
                //return rave
            }
            else
            {

                count = 0;
                //return slyth
            }

            return null;
        }
    }
}
