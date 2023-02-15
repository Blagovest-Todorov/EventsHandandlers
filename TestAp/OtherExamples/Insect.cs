using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.OtherExamples
{
    internal class Insect
    {
        int i = 9;
        internal int j;
        internal Insect()
        {
            Prt("i = " + i + ", j = " + j);
            j = 39;
        }

        static int x1 = Prt("staic Insect.xl initialized");
        internal static int Prt(string s) 
        {
            Console.WriteLine(s);
            return 47;
        }
    }
}
