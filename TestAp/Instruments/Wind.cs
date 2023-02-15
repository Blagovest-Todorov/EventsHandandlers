namespace TestAp.Instruments
{
    public class Wind : InterfaceInstrument
    {
        public virtual void Adjust() { }

        public virtual void Play()
        {
            Console.WriteLine("Wind.Play()");
        }

        public virtual string What() {return "Wind";}
    }
}
