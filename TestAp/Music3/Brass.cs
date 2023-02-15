namespace TestAp.Music3
{
    internal class Brass : Wind
    {
        public override void Play() 
        {
            Console.WriteLine("Brass.Play()");
        }

        public override void Adjust()
        {
            Console.WriteLine("Brass.Adjust()");
        }
    }
}
