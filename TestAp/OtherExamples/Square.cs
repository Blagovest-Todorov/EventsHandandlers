using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.OtherExamples
{
    internal class Square : Shape
    {
        internal override void Draw()
        {
            Console.WriteLine("Square.Draw()");
        }
        internal override void Erase()
        {
            Console.WriteLine("Square.Erase()");
        }
    }
}
