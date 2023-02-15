namespace TestAp.Array.FurnitureCl
{
    internal class Furniture
    {
        protected static int idCounter = 0;
        protected int id = idCounter++;

        protected Furniture() 
        {
            Console.WriteLine("Furniture {0} in construction", id);
        }

        protected Upholstery covering;
        protected Color aColor;
    }
}
