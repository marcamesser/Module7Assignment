using System.Collections;
using System.Security.Policy;

namespace Module7Assignment
{

    public class Student : Person
    {
        public static int SCount = 0;



        // constructor
        public Student(string SFName, string SLName, int StID)
        {
            this.FirstName = SFName;
            this.LastName = SLName;
            this.StudentID = StID;
            SCount++;
        }

        // the following statements declare private member variables
        private int _StudentID;
        public Hashtable Grades = new Hashtable();

        public int StudentID
        {
            get => _StudentID;
            set => _StudentID = value;
        }

        public Hashtable Grades1
        {
            get => Grades;
            set => Grades = value;
        }

        public void SayStudentID()
        {
            System.Console.WriteLine("My student ID is {0}", StudentID);
        }

    }
}