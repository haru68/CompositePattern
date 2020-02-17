using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Person enfant3 = new Person("anne");
            Person enfant2 = new Person("benjamin");
            Person enfant1 = new Person("cécile");
            enfant1.persons = new List<Person>();
            enfant2.persons = new List<Person>();
            enfant3.persons = new List<Person>();

            List<Person> enfants = new List<Person>();
            enfants.Add(enfant1);
            enfants.Add(enfant2);
            enfants.Add(enfant3);

            Person parent1 = new Person("parent1");
            parent1.persons = enfants;

            Person parent2 = new Person("parent2");
            parent2.persons = enfants;

            List<Person> parents = new List<Person>();
            parents.Add(parent1);
            parents.Add(parent2);

            Person grdParent1 = new Person("papy");
            grdParent1.persons = parents;

            string arborescence = grdParent1.ToString();
            Console.WriteLine(arborescence);
        }
    }
}
