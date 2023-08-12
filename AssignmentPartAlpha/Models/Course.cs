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
        public List<Student> Students { get; set; }
        public List<Trainer> Trainers { get; set; }
        public List<Assignment> Assignments { get; set; }


        public static Course CreateCourse()
        {
            Course c1 = new Course();


            Console.WriteLine("Course's Title(ex C#): ");
            c1.Title = Console.ReadLine();
            Console.WriteLine("Course's Stream(ex CB8): ");
            c1.Stream = Console.ReadLine();
            Console.WriteLine("Course's Type(ex full Time/Part Time): ");
            c1.Type = Console.ReadLine();
            Console.WriteLine("Course's StartDate(ex 2023-08-13): ");
            c1.StartDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Course's EndDate(ex 2023-11-13): ");
            c1.EndDate = Convert.ToDateTime(Console.ReadLine());
            c1.Students = new List<Student>();
            c1.Trainers = new List<Trainer>();
            c1.Assignments = new List<Assignment>();
            c1.CourseId = nextId++;
           
           

            Console.Clear();

            Console.WriteLine("Course created succesfully");
            Thread.Sleep(2000);

            Console.Clear();
            return c1;
        }

    }
}
