using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    internal class BoardGame : Game
    {
        internal BoardGame(int i) : base(i)
        {
            Console.WriteLine("BoardGame Constructor");
        }
    }
}
