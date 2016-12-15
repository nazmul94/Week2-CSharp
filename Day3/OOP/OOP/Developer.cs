using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Developer : Employee
    {
        public string Devtalk()
        {
            return base.talk();
        }
    }
}
