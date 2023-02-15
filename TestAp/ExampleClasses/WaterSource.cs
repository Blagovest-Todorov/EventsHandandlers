using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    internal class WaterSource
    {
        private string s;
        internal WaterSource()
        {
            Console.WriteLine("WaterSource()");
            s = "Constructed";
        }

        public override string ToString()
        {
            return s;
        }
    }
}
