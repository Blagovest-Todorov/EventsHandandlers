using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    internal class Spork : Silverware
    {
        public override void GetFood()
        {
            Console.WriteLine("Spear or Scoop!");
        }

        public new virtual void Wash()
        {
            Console.WriteLine("Wipe with napkin");
        }
    }
}
