using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AssignmentPartAlpha.Models
{
    public class Assignment
    {
        private static int nextId = 1;
        public int AssignmentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }
        public Course Course { get; set; }
        public HashSet<Student> Students { get; set; }

        public static Assignment CreateAssignment()
        {
            Assignment a1 = new Assignment();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Assignment's Title(ex Donuts App): ");
            Console.ResetColor();

            a1.Title = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Assignment's Description: ");
            Console.ResetColor();

            a1.Description = Console.ReadLine();


            // SubDateTime
            DateTime result = new DateTime(1111, 11, 11);
            string userInput = "";
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Assignment's subDateTime (ex 2023-08-13): ");
                Console.ResetColor();
                userInput = Console.ReadLine();

                if (Check.isDateTimeType(userInput))
                    a1.SubDateTime = Convert.ToDateTime(userInput);
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter correct DateTime type :");
                    Console.ResetColor();
                }

            } while (!Check.isDateTimeType(userInput));


            // OralMark
            string userInput1 = "";
            bool validMark = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Assignments Oral Mark(0 - 100): ");
                Console.ResetColor();

                userInput1 = Console.ReadLine();
                if (Check.isInt(userInput1))
                {
                    if (Check.isValidMark(Convert.ToInt32(userInput1)))
                    {
                        a1.OralMark = Convert.ToInt32(userInput1);
                        validMark = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input! Please enter a number between 0 - 100");
                        Console.ResetColor();
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your input was not a number! Please enter a number between 0 - 100 :");
                    Console.ResetColor();
                }

            } while (!validMark);


            // TotalMark
            string userInput2 = "";
            bool validMark2 = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Assignments Total Mark(0 - 100): ");
                Console.ResetColor();

                userInput2 = Console.ReadLine();
                if (Check.isInt(userInput2))
                {
                    if (Check.isValidMark(Convert.ToInt32(userInput2))) 
                    {
                        a1.TotalMark = Convert.ToInt32(userInput2);
                        validMark2 = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input! Please enter a number between 0 - 100");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input ! Please enter a number between 0 - 100 :");
                    Console.ResetColor();
                }

            } while (!validMark2);

            a1.AssignmentId = nextId++;


            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Assignment created succesfully");
            Console.ResetColor();
            Thread.Sleep(2000);

            Console.Clear();
            return a1;
        }
    }
}

