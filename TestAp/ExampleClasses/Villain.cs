using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    public class Villain
    {
        private int i;
        protected int Read() { return i; }
        protected void Set(int ii) { i = ii; }
        public Villain(int ii) { i = ii; }
        public int Value(int m) { return m * i; }

    }
}
