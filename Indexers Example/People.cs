using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexerWithWindowsForms
{
    class People : LinkedList<Person>
    {
        public Person[] this[int age]
        {
            get
            {
                LinkedList<Person> list = new LinkedList<Person>();
                foreach (Person p in this)
                {
                    if (p.Age == age)
                    {
                        list.AddLast(p);
                    }
                }
                return list.ToArray<Person>();
            }
        }

        public Person[] this[string maritalStatus]
        {
            get
            {
                LinkedList<Person> list = new LinkedList<Person>();
                foreach (Person p in this)
                {
                    if (p.MaritalStatus.ToLower().Equals(maritalStatus.ToLower()))
                    {
                        list.AddLast(p);
                    }
                }
                return list.ToArray<Person>();
            }
        }
    }
}
