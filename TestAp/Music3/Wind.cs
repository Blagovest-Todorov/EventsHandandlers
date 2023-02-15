namespace TestAp.Music3
{
    internal class Wind : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("Wind.Play()");
        }
        public override string What()
        {
            return "Wind";
        }
        public override void Adjust()
        {
            
        }
    }
}
