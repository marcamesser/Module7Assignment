using System;
using System.Collections;
using System.Collections.Generic;

namespace Module7Assignment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // declare students
            Student Joey = new Student("Joey", "Freshwater", 01);
            Joey.Grades.Add("Math", "A+");
            Joey.Grades.Add("Science", "A+");
            Joey.Grades.Add("English", "A+");
            Joey.Grades.Add("History", "A+");
            Joey.Grades.Add("Spanish", "A+");
            Student Jimmy = new Student("Jimmy", "Chestnut", 02);
            Jimmy.Grades.Add("Math", "A+");
            Jimmy.Grades.Add("Science", "A+");
            Jimmy.Grades.Add("English", "A+");
            Jimmy.Grades.Add("History", "A+");
            Jimmy.Grades.Add("Spanish", "A+");
            Student Lane = new Student("Lane", "Kiffin", 03);
            Lane.Grades.Add("Math", "A+");
            Lane.Grades.Add("Science", "A+");
            Lane.Grades.Add("English", "A+");
            Lane.Grades.Add("History", "A+");
            Lane.Grades.Add("Spanish", "A+");
            ArrayList StudentList = new ArrayList();
            StudentList.Add(Joey);
            StudentList.Add(Jimmy);
            StudentList.Add(Lane);


            // declare teacher
            Teacher Butch = new Teacher("Butch", "Jones", 01);
            ArrayList TeacherList = new ArrayList();
            TeacherList.Add(Butch);

            // declare course
            Course Prog = new Course("Programming with C#", "P01", StudentList, TeacherList);
            Course[] CourseArray = {Prog};

            Prog.DisplayStudents();
        }


        #region Collections

        static void CreateArrayList()
        {
            //create new arraylist collection
            ArrayList beverages = new ArrayList();

            //create some items to add to the collction
            Coffee coffee1 = new Coffee(4, "Arabica", "Columbia");
            Coffee coffee2 = new Coffee(3, "Arabica", "Vietnam");
            Coffee coffee3 = new Coffee(4, "Robusta", "Indonesia");

            //add the items to the collection
            //items are implicitly cast to the objectr type when you add them
            beverages.Add(coffee1);
            beverages.Add(coffee2);
            beverages.Add(coffee3);

            //retrieve items from the collection
            //items must be explicitly cast back to their original type
            Coffee firstCoffee = (Coffee)beverages[0];
            Coffee secondCoffee = (Coffee) beverages[1];

            OutputCollection(beverages);
        }

        static void OutputCollection(ArrayList beverages)
        {
            foreach (Coffee Coffee in beverages)
            {
                Console.WriteLine("Bean type: {0}", Coffee.Bean);
                Console.WriteLine("Country of origin: {0}", Coffee.CountryOfOrigin);
                Console.WriteLine("Strength: {0}", Coffee.Strength);
                Console.WriteLine("");
            }
        }

        static void CreateHashtable()
        {
            //create a new hashtable collection
            Hashtable ingredients = new Hashtable();

            //add some key/value pairs to the collection
            ingredients.Add("Cafe au Lait", "Coffee, Milk");
            ingredients.Add("Cafe Mocha", "Coffee, Milk, Chocolate");
            ingredients.Add("Cappucino", "Coffee, Milk, Foam");
            ingredients.Add("Irish Coffee", "Coffee, Whiskey, Cream, Sugar");
            ingredients.Add("Macchiato", "Coffee, Milk, Foam");

            OutputHashTable(ingredients);
        }

        static void OutputHashTable(Hashtable hTable)
        {
            //check whether a key exists
            if (hTable.ContainsKey("Cafe Mocha"))
            {
                // retrieve the value associated with a key
                Console.WriteLine("The ingredients of a Cafe Mocha are {0}.", hTable["Cafe Mocha"]);
            }
        }


        #endregion


        #region GenericCollections



        #endregion
    }
}