using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    internal class Cleanser
    {
        private string s = "Cleanser";
        public void Append(string a)
        {
            s += a;
        }

        public void Deilute()
        {
            Append(" dilute()");
        }

        public void Apply()
        {
            Append(" apply()");
        }

        virtual public void Scrub()
        {
            Append(" scrub()");
        }

        public void Print()
        {
            Console.WriteLine(s);
        }

        //public static void Main()
        //{
        //    Cleanser x = new Cleanser();
        //    x.Deilute();
        //    x.Apply();
        //    x.Scrub();
        //    x.Print();
        //}      
    }
}
