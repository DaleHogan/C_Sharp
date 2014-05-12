using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexerWithWindowsForms
{
    class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string MaritalStatus { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }

        public Person(string lastName, string firstName, int age, string address, string maritalStatus, string email, string dOB)
        {
            LastName = lastName.Trim();
            FirstName = firstName.Trim();
            Age = age;
            Address = address.Trim();
            MaritalStatus = maritalStatus.Trim();
            Email = email.Trim();
            DOB = Convert.ToDateTime(dOB);
        }
    }
}
