namespace TestAp.Food
{
    internal class Sandwich : PortableLunch
    {
        Bread b = new Bread();
        Cheese c = new Cheese();
        Lettuce l = new Lettuce();

        internal Sandwich()
        {
           Console.WriteLine("Sandwich");
        }

        //public static void Main() 
        //{
        //    new Sandwich();
        //}
    }
}
