using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    internal class DinnerPlate : Plate
    {
        internal DinnerPlate(int i) : base(i)
        {
            Console.WriteLine("Dinnerplate Constructor");
        }
    }
}
