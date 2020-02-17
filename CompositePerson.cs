using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    abstract class CompositePerson
    {
        public string name;
        public List<Person> persons;

        public abstract override string ToString();
    }
}
