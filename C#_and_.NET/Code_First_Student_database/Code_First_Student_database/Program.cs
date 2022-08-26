using Sitecore.FakeDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using XAct.Library.Settings;


namespace Code_First_Student_database
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new Context())
            {
                Console.Write("Enter a StudentID for a new Student: ");
                var StudentID = Console.ReadLine();

                Console.Write("Enter the Student name: ");
                var StudentName = Console.ReadLine();

                Console.Write("Enter the age of the Student: ");
                var Age = Console.ReadLine();

                var Student = new Student { StudentID = StudentID, StudentName  = StudentName, Age = Age };

                Console.WriteLine(Student.StudentID + " " + Student.StudentName + " " + Student.Age);

                ctx.Students.Add(Student);
                ctx.SaveChanges();

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }

    public class Student
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string Age { get; set; }
    }

    public class Context : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

}



