using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexExample1
{
    class Person
    {
        public string FirstName;
        public String LastName;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //value types
            int a = 5;
            int b = 10;

            //reference types
            Person p = new Person();
            Person p2 = new Person();

            //boxing - wrapper (val -> ref)
            object obj1 = a;

            //unboxing (ref -> val)
            int result = (int)obj1;

            //Lists accept reference type
            List<Person> people = new List<Person>();

            Dictionary<int, Person> aPeople = new Dictionary<int, Person>();
            Person alex = new Person();
            alex.FirstName = "Alex";
            alex.LastName = "Kennedy";
            aPeople.Add(1, alex);

            Console.WriteLine(aPeople.TryGetValue(1, out alex));
        }
    }
}
