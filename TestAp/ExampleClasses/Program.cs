using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    public class Program
    {
        //static void Main(string[] args)
        //{
        //    int[] a1 = {1, 2, 3, 4 };

        //    Console.WriteLine(String.Join(" ", a1));

        //    int[] a2;

        //    a2 = a1;

        //    for (int i = 0; i < a1.Length; i++)
        //    {
        //        a2[i]++;
        //    }

        //    Console.WriteLine(String.Join(" ", a1));
        //    Console.WriteLine(String.Join(" ", a2));
        //}


        static int Ternary(int i)
        {
            return i < 10 ? i * 100 : i * 10;
        }
    }
}
