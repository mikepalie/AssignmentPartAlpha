using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AssignmentPartAlpha.Models
{
    public class Course
    {
        private static int nextId = 1;
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public HashSet<Student> Students { get; set; }
        public HashSet<Trainer> Trainers { get; set; }
        public HashSet<Assignment> Assignments { get; set; }


        public static Course CreateCourse()
        {
            Course c1 = new Course();

            // Title
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Course's Title(ex C#): ");
            Console.ResetColor();

            c1.Title = Console.ReadLine();

            // Stream
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Course's Stream(ex CB8): ");
            Console.ResetColor();

            c1.Stream = Console.ReadLine();

            // Type
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Course's Type(ex Full Time/Part Time): ");
            Console.ResetColor();

            c1.Type = Console.ReadLine();

            
            // StartDate
            string userInput1 = "";
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Course's StartDate(ex 2023-08-13): ");
                Console.ResetColor();
                userInput1 = Console.ReadLine();

                if (Check.isDateTimeType(userInput1))
                    c1.StartDate = Convert.ToDateTime(userInput1);
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter correct DateTime type :");
                    Console.ResetColor();
                }

            } while (!Check.isDateTimeType(userInput1));

            
            // EndDate
            string userInput = "";
            bool isValidEndDate = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Course's EndDate(ex 2023-11-13): ");
                Console.ResetColor();
                userInput = Console.ReadLine();

                if (Check.isDateTimeType(userInput))
                {
                    if(Check.isEndDateValid(c1.StartDate, Convert.ToDateTime(userInput)))
                    {
                        c1.EndDate = Convert.ToDateTime(userInput);
                        isValidEndDate = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("EndDate should be after StartDate!");
                        Console.ResetColor();
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter correct DateTime type :");
                    Console.ResetColor();
                }

            } while (!isValidEndDate);



            c1.Students = new HashSet<Student>();
            c1.Trainers = new HashSet<Trainer>();
            c1.Assignments = new HashSet<Assignment>();
            c1.CourseId = nextId++;
           
           

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Course created succesfully");
            Console.ResetColor();
            Thread.Sleep(2000);

            Console.Clear();
            return c1;
        }

    }
}
