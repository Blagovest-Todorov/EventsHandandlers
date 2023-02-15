using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    internal class PlaceSetting : Custom
    {
        Spoon sp;
        Fork fk;
        Knife kn;
        DinnerPlate dp;

        public PlaceSetting(int i) : base(i + 1)
        {
            sp = new Spoon(i + 2);
            //fk = new Fork(i + 3);
            kn = new Knife(i + 4);
            dp = new DinnerPlate(i + 5);

            Console.WriteLine("PlacesettingConstructor");
        }

        //public static void Main() 
        //{
        //    PlaceSetting ps = new PlaceSetting(9);
        //}
    }
}
