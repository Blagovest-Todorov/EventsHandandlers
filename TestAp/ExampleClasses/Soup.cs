using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    internal class Soup
    {
        private Soup()
        {

        }

        public static Soup MakeSoup()
        {
            return new Soup();
        }

        private static Soup ps1 = new Soup();
        public static Soup Access()
        {
            return ps1;
        }

        public void F()
        {

        }
    }
}
