using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        int id;
        string firstName;
        string lastName;
        string adress;
        int age;
        string gender;

        public Person()
        {
            id = 1;
            firstName = "Adam";
            lastName = "Abacki";
            age = 14;
        }

        public Person(int id, string firstName, string lastName, string adress, int age, string gender)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.adress = adress;
            this.age = age;
            this.gender = gender;
        }

        public Person(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            adress = "Katowice";
            age = 18;
        }

        public Person(int id, string firstName)
        {
            this.id = id;
            this.firstName = firstName;
        }
    }
}
