using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    internal class Instrument
    {
        public void play() { }
        static internal void Tune(Instrument i)
        {
            i.play();
            Console.WriteLine("The instrument is tuned");
        }
    }
}
