namespace TestAp.ExceptionsHandling.StudentCL
{
    public class Switch
    {
        bool state = false;
        public bool Read 
        {
            get { return state; }  
            set { state = value; }
        }

        public void On() { state = true; }
        public void Off() { state = false; }
    }
}
