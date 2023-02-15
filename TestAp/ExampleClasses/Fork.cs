using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    internal class Fork : Silverware
    {
        public override void GetFood()
        {
            Console.WriteLine("Spear");
        }
    }
}
