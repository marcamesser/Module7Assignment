namespace Module7Assignment
{
    public class Teacher : Person
    {
        public static int TCount;
        // constructor
        public Teacher(string TFName, string TLName, int TID)
        {
            this.FirstName = TFName;
            this.LastName = TLName;
            this.TeacherID = TID;
            TCount++;
        }

        // the following statements declare private member variables
        private int _TeacherID;

        public int TeacherID
        {
            get => _TeacherID;
            set => _TeacherID = value;
        }

        public void SayTeacherID()
        {
            System.Console.WriteLine("My teacher ID is {0}", TeacherID);
        }
    }
}