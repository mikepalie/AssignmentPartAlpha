using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AssignmentPartAlpha.Models
{
    public class Trainer
    {
        private static int nextId = 1;
        public int TrainerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string subject;
        public HashSet<Course> Courses { get; set; }

        public static Trainer CreateTrainer()
        {
            Trainer t1 = new Trainer();


            // FirstName
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Trainer's Firstname: ");
                Console.ResetColor();
                t1.FirstName = Console.ReadLine();
                if (!Check.isValidName(t1.FirstName))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only letters A-Z allowed: ");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                }
            } while (!Check.isValidName(t1.FirstName));

            // LastName
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Trainer's Lastname: ");
                Console.ResetColor();
                t1.LastName = Console.ReadLine();
                if (!Check.isValidName(t1.LastName))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only letters A-Z allowed: ");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                }
            } while (!Check.isValidName(t1.LastName));

            // Subject
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Trainer's Subject: ");
            Console.ResetColor();
            t1.subject = Console.ReadLine();


            t1.TrainerId = nextId++;

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Trainer created succesfully");
            Console.ResetColor();
            Thread.Sleep(2000);

            Console.Clear();
            return t1;
        }


    }
}
