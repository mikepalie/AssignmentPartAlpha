using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AssignmentPartAlpha.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double TuitionFees { get; set; }
        public  List<Course> Courses { get; set; }
        public  List<Assignment> Assignments { get; set; }

        public static Student CreateStudent()
        {
            
            Student s1 = new Student();


            Console.WriteLine("Student's Firstname: ");
            s1.FirstName = Console.ReadLine();
            Console.WriteLine("Student's Lastname: ");
            s1.LastName = Console.ReadLine();
            Console.WriteLine("Student's Date of Birth(ex. 1991-03-14): ");
            s1.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Student's Tuition Fees: ");
            s1.TuitionFees = Convert.ToDouble(Console.ReadLine());
            s1.Courses = new List<Course>();

           

            Console.Clear();

            Console.WriteLine("Student created succesfully");
            Thread.Sleep(2000);

            Console.Clear();
            return s1;
        }
    }
     
}
