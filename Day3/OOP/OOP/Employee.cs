using OOP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //derived from superclass 'Person'
    //employee is a person. Since person is an object employee is an object
    class Employee : Person
    {
        public string Position { get; set; }
        public DateTime hireDate { get; set; }

        //constructors
        public Employee() { }

        public Employee(string fn, string ln, DateTime bd, string pos, DateTime hd)
            : base(fn,ln,bd)
        {
            this.Position = pos;
            this.hireDate = hd;
        }

        public override string talk()
        {
            return string.Format("Employe {0} say hello!", this.Firstname);
        }
    }
}
