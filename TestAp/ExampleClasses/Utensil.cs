using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    internal class Utensil
    {
        public virtual void GetFood() { }
        public virtual void Wash()
        {
            Console.WriteLine("Washing in a dishwasher");
        }
    }
}


