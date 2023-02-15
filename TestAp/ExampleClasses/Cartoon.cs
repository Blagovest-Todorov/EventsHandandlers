using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    internal class Cartoon : Drawing
    {
        protected Cartoon()
        {
            Console.WriteLine("Cartoon Constructor");
        }

        //public static void Main()
        //{
        //    Cartoon x = new Cartoon();
        //}
    }
}
