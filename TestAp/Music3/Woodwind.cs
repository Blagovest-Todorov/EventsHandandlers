namespace TestAp.Music3
{
    internal class Woodwind : Wind
    {
        public override void Play() 
        {
            Console.WriteLine("Woodwind.Play()");
        }

        public override string What()
        {
            return "Woodwind";
        }
    }
}
