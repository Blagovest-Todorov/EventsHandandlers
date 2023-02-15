using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.OtherExamples
{
    internal class Circle : Shape
    {
        internal override void Draw()
        {
            Console.WriteLine("Circle.Draw()"); 
        }

        internal override void Erase()
        {
            Console.WriteLine("Circle Erase");
        }
    }
}
