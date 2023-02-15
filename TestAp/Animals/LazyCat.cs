namespace TestAp.Animals
{
    internal class LazyCat : Cat
    {
        public new void Move() 
        {
            Console.WriteLine("Lazy Cat walks");
        }
    }
}
