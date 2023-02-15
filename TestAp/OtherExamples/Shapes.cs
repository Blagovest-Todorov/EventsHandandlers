using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.OtherExamples
{
    internal class Shapes
    {
        static Random rand = new Random();

        public static Shape RandShape() 
        {
            switch (rand.Next(3))
            {
                case 0: return new Circle();
                case 1: return new Square();
                case 2: return new Triangle();
                default:
                    return null;                    
            }            
        }


        //public static void Main()
        //{
        //    Shape[] s = new Shape[9];

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        s[i] = RandShape();
        //    }

        //    foreach (Shape shape in s)
        //    {
        //        shape.Draw();
        //    }
        //}
    }
}
