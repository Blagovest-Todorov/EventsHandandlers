using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    internal class SuperSpork : Spork
    {
        public override void GetFood()
        {
            Console.WriteLine("Spear and Scoop! "); 
        }

        public override void Wash()
        {
            base.Wash();
            Console.WriteLine("Polish with shirt");
        }
    }
}
