using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    class Person
    {
        //attributes - properties (like fields with getters and setters
        public string Firstname { get; set; } 
        public string LastName { get; set; } 
        public DateTime BirthDate { get; set; }
        private Boolean isSleeping;

        //behaviours

        //constructor overloading
        public Person() { } //defaulr constructor

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            this.Firstname = firstName;
            this.LastName = lastName;
            this.BirthDate = BirthDate;
        }

        public Person(string fn, string ln)
        {
            this.Firstname = fn;
            this.LastName = ln;
        }
        public Person(string fn)
        {
            this.Firstname = fn;
        }

        //methods (functions)
        public int getAge()
        {
            if (BirthDate == null)
                return 0;

            return (DateTime.Now.Subtract(BirthDate).Days / 365);
        }

        public virtual string talk()
        {
            if (isSleeping)
                throw new Exception(string.Format("{0} is sleeping", Firstname));

            return string.Format("{0} {1} says I'm awake", Firstname, LastName);
        }

        public void sleep()
        {
            this.isSleeping = true;
        }

        public void wakeUp()
        {
            if (isSleeping)
                isSleeping = false;
        }
    }
}
