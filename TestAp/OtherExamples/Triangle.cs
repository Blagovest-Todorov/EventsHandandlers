using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.OtherExamples
{
    internal class Triangle : Shape
    {
        internal override void Draw() 
        {
            Console.WriteLine("Triangle.Draw()");
        }

        internal override void Erase()
        {
            Console.WriteLine("Triangle.Erase()");
        }
    }
}
