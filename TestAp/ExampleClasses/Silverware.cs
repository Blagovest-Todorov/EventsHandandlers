using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    internal class Silverware : Utensil
    {
        public override void Wash() 
        {
           base.Wash();
            Console.WriteLine("Polish the silver Cleaner");
        }
    }
}
