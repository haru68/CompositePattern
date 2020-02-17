using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Person : CompositePerson
    {
        /*public string name;
        public List<Person> persons = new List<Person>();*/

        public Person(string name)
        {
            this.name = name;
        }
        

        public override string ToString()
        {
            string family = name + "\n";
            foreach (Person child in persons)
            {
                family += child.ToString();
            }
            return family;
        }
    }
}
