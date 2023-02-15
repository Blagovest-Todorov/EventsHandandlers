namespace TestAp.Instruments
{
    internal class Stringed : InterfaceInstrument
    {
        public void Adjust() { }

        public virtual void Play()
        {
            Console.WriteLine("Stringed.Play()");
        }

        public virtual string What() { return "stringed"; }
    }
}
