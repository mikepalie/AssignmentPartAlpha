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
        private static int nextId = 1;
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
            // FirstName
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Student's Firstname: ");
                Console.ResetColor();
                s1.FirstName = Console.ReadLine();
                if (!Check.isValidName(s1.FirstName))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only letters A-Z allowed: ");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                }
            } while (!Check.isValidName(s1.FirstName));

            // LastName
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Student's Lastname: ");
                Console.ResetColor();
                s1.LastName = Console.ReadLine();
                if (!Check.isValidName(s1.LastName))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only letters A-Z allowed: ");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                }
            } while (!Check.isValidName(s1.LastName));

            // Date of Birth
            DateTime result = new DateTime(1111, 11, 11);
            string userInput = "";
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Student's Date of Birth (ex. 1991-03-14): ");
                Console.ResetColor();
                userInput = Console.ReadLine();

                if (Check.isDateTimeType(userInput))
                    s1.DateOfBirth = Convert.ToDateTime(userInput); 
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter correct DateTime type :");
                    Console.ResetColor();
                }

            } while (!Check.isDateTimeType(userInput));

            //Tuition Fees
            string tuition = "";
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Student's Tuition Fees(Euros): ");
                Console.ResetColor();
                tuition = Console.ReadLine();
                if (Check.isDouble(tuition))      
                    s1.TuitionFees = Convert.ToDouble(tuition);
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter numbers(ex. 2000) :");
                    Console.ResetColor();
                }

            } while (!Check.isDouble(tuition));
            

            s1.Courses = new List<Course>();
            s1.Assignments = new List<Assignment>();
            s1.StudentId = nextId++;
           

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Student created succesfully");
            Console.ResetColor();
            Thread.Sleep(2000);

            Console.Clear();
            return s1;
        }
    }
     
}
