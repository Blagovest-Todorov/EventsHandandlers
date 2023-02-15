using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    internal class Chess : Game
    {
        internal Chess() : base(11)
        {
            Console.WriteLine("Chess Constructor");
            Console.WriteLine("2");
        }

        //public static void Main()
        //{
        //    Chess x = new Chess();
        //}
    }
}
