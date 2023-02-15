namespace TestAp.Instruments
{
    internal class Percussion : InterfaceInstrument
    {
        public void Adjust() { }

        public virtual void Play()
        {
            Console.WriteLine("Percussion.Play()");
        }

        public virtual string What() { return "Percussion"; }
    }
}
