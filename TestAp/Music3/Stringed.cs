namespace TestAp.Music3
{
    internal class Stringed : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("stringed.Play()");
        }

        public override string What() { return "Sstringed"; }
        public override void Adjust() { }
    }
}
