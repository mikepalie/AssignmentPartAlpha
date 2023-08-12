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
        public List<Course> Courses { get; set; }

        public static Trainer CreateTrainer()
        {
            Trainer t1 = new Trainer();


            Console.WriteLine("Trainer's Firstname: ");
            t1.FirstName = Console.ReadLine();
            Console.WriteLine("Trainer's Lastname: ");
            t1.LastName = Console.ReadLine();
            Console.WriteLine("Trainer's Subject: ");
            t1.subject = Console.ReadLine();
            t1.TrainerId = nextId++;

            Console.Clear();

            Console.WriteLine("Trainer created succesfully");
            Thread.Sleep(2000);

            Console.Clear();
            return t1;
        }


    }
}
