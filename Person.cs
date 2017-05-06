namespace Module7Assignment
{
    public abstract class Person
    {
        private string _FirstName;
        private string _LastName;

        public string FirstName
        {
            get => _FirstName;
            set => _FirstName = value;
        }

        public string LastName
        {
            get => _LastName;
            set => _LastName = value;
        }

        public virtual void SayName()
        {
            System.Console.WriteLine("My name is {0} {1}.", FirstName, LastName);
        }
    }
}