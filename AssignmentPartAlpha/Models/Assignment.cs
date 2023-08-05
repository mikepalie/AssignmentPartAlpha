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
        public int AssignmentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public double OralMark { get; set; }
        public double TotalMark { get; set; }
        public Course Course { get; set; }
        public List<Student> Students { get; set; }

        public static Assignment CreateAssignment()
        {
            Assignment a1 = new Assignment();


            Console.WriteLine("Assignment's Title(ex Donuts App): ");
            a1.Title = Console.ReadLine();
            Console.WriteLine("Assignment's Description: ");
            a1.Description = Console.ReadLine();
            Console.WriteLine("Assignment's subDateTime (ex 2023-08-13): ");
            a1.SubDateTime = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Assignments Oral Mark(0 - 100): ");
            a1.OralMark = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Assignment's Total Mark(0 - 100): ");
            a1.TotalMark = Convert.ToDouble(Console.ReadLine());


            Console.Clear();

            Console.WriteLine("Assignment created succesfully");
            Thread.Sleep(2000);

            Console.Clear();
            return a1;
        }
    }
}

