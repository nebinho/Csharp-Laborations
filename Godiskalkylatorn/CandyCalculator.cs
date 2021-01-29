using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Godiskalkylatorn
{
    public class CandyCalculator
    {
        public List<Person> personList {get; set;}

        public CandyCalculator()
        {
            personList = new List<Person>();
        }

        public void AddPerson(string inputFirst, string inputLast, int inputAge)
        {
            Person person = new Person()
            {
                FirstName = inputFirst,
                LastName = inputLast,
                Age = inputAge,
                Candies = 0
            };
            personList.Add(person);
        }

        public void DistributeCandies(int inputCandies, bool byLastName, bool byFirstName, bool byAge)
        {
            if (byLastName == true)
            {
                DistributeByLastName();
            }
            else if (byFirstName == true)
            {
                DistributeByFirstName();
            }
            else if (byAge == true)
            {
                DistributeByAge();
            }

            int result = 0, rest = 0;
            result = (inputCandies / personList.Count);
            rest = (inputCandies % personList.Count);

            foreach (Person person in personList)
            {
                person.Candies = 0;
                person.Candies += result;
                if (rest > 0)
                {
                    person.Candies++;
                    rest--;
                }
            }
        }

        #region Public sorting methods
        public List<Person> DistributeByLastName(bool byLastName = false)
        {
            personList = personList.OrderBy(x => x.LastName).ToList();            
            return personList;
        }

        public List<Person> DistributeByFirstName(bool byFirstName = false)
        {
            personList = personList.OrderBy(x => x.FirstName).ToList();
            return personList;
        }

        public List<Person> DistributeByAge(bool byAge = false)
        {
            personList = personList.OrderBy(x => x.Age).ToList();
            return personList;
        }
        #endregion
    }
}
