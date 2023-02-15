using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    internal class SprinclerSystem
    {
        private string valve1, valve2, valve3, valve4;
        WaterSource source;
        int i;
        float f;
        void Print()
        {
            Console.WriteLine("valve1 = " + valve1);
            Console.WriteLine("valve2 =" + valve2);
            Console.WriteLine("valve3 = " + valve3);
            Console.WriteLine("valve4 = " + valve4);
            Console.WriteLine("i =  " + i);
            Console.WriteLine("f =  " + f);
            Console.WriteLine("source = " + source);
        }

        //public static void Main()
        //{
        //    SprinclerSystem x = new SprinclerSystem();
        //    x.Print();
        //}
    }
}
