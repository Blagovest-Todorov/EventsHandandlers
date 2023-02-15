using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    public class Cookie
    {
        public Cookie()
        {
            Console.WriteLine("Cookie constructor");
        }

        protected internal void Bite()
        {
            Console.WriteLine("Bite");
        }
    }
}
