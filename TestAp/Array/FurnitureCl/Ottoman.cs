namespace TestAp.Array.FurnitureCl
{
    internal class Ottoman : Furniture
    {
        internal Ottoman() 
        {
            Console.WriteLine("Ottoman created");
            covering = Upholstery.fabric;
            aColor = Color.ercu;
        }

        public override string ToString()
        {
            return String.Format("Ottoman {0} is {1} {2}", id, aColor, covering);
        }
    }
}
