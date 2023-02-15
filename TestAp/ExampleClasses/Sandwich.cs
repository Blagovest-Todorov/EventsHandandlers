using System.Net.Http.Headers;

namespace TestAp.ExampleClasses
{
    internal class Sandwich
    {
        internal Sandwich()
        {
            var topSlice = new Bread();
            var bottomSlice = new Bread();
            var meat = new Meat();
        }

        Sandwich MakeSandwich(Bread slice1, Bread slice2, Meat chosenMeat, Lettuce letuce)
        {
            var s = new Sandwich();
            //s.topSlice = slice1;
            //s.bottomSlice = slice2;

            return s;
        }

        void F()
        {
            new Lunch();
        }

        Soup priv2 = Soup.MakeSoup();

    }
}
