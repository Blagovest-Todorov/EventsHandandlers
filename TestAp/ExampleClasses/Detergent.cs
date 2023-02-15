using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    internal class Detergent : Cleanser
    {
        public override void Scrub()
        {
            Append(" Detergent.scrub()");
            base.Scrub(); // call base-class version
        }

        public void Foam()
        {
            Append(" Foam()");
        }


        //public static void Main() 
        //{
        //    Detergent x = new Detergent();
        //    x.Deilute();
        //    x.Apply();
        //    x.Scrub();
        //    x.Foam();
        //    x.Print();
        //    Console.WriteLine("Testing base class: ");
        //}
    }
}
