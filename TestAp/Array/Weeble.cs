namespace TestAp.Array
{
    internal class Weeble
    {
        string name;

        public string Name 
        {
            get { return name; }

            set { name = value; }
        }

        internal Weeble(string name) 
        {
            this.Name = name;
        }
    }
}
