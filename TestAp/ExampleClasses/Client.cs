using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    internal class Client
    {
        Utensil[] myUtensils;

        Client()
        {
            myUtensils = new Utensil[3];
            myUtensils[0] = new Spork();
            myUtensils[1] = new Fork();
            myUtensils[2] = new SuperSpork();
        }

        public void WashAll()
        {
            foreach (var u in myUtensils)
            {
                u.Wash();
            }

            Console.WriteLine("All Utensils washed");
        }

        //public static void Main()
        //{
        //    Client c = new Client();
        //    c.WashAll();

        //    Spork s = new SuperSpork();
        //    s.Wash();
        //}
    }
}
