using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    internal struct Mp3Player
    {
        int volume;
        internal int Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                Console.WriteLine("Volume set to {0} ", volume);
            }
        }
    }
}
