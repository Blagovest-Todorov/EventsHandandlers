namespace TestAp.Music3
{
    internal class Instrument
    {
        public virtual void Play() 
        {
            Console.WriteLine("Instrument.Paly()");
        }

        public virtual string What() 
        {
            return "Instrument";
        }

        public virtual void Adjust() { }
    }
}
