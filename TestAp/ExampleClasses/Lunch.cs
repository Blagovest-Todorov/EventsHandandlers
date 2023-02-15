namespace TestAp.ExampleClasses
{
    public class Lunch
    {
        public Lunch()
        {

        }

        void Test()
        {
            // Soup priv1 = new Soup();
            Soup priv2 = Soup.MakeSoup();
            Sandwich f1 = new Sandwich();
            Soup.Access().F();

        }


    }
}