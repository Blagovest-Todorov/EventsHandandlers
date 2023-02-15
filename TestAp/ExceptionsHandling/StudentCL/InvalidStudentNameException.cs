namespace TestAp.ExceptionsHandling.StudentCL
{
    [Serializable]
    public class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException() { }       

        public InvalidStudentNameException(string name)
            : base(String.Format("Invalid Student name: {0}", name))
        {

        }
    }
}
