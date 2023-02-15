using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.OtherExamples
{
    internal class Beetle : Insect
    {
        int k = Prt("Beetle.k initialized");

        Beetle() 
        {
            Prt("k = " + k);
            Prt("j = " + j);
        }

        static int x2 = Prt("Beetle .x2 initialized");

        //public static void Main() 
        //{
        //    Prt("Beetle  Constructor");
        //    Beetle b = new Beetle();
        //}
    }
}
