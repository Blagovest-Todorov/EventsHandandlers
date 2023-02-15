namespace TestAp.CC
{
    internal class A
    {
        public void Foo() 
        {
            B b = new B();
            b.Bar(this);
        }

        int f1;
        public int Field1 
        {
            get { return f1; }
            set { f1 = value; }
        }

        int f2;
        public int Field2 
        {
            get { return f2; }
            set { f2 = value;  }
        }
    }
}
