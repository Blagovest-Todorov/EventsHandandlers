using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    internal class Orc : Villain
    {
        private int j;
        public Orc(int jj) : base(jj) { j = jj; }
        public void Change(int x) { Set(x); }
    }
}
