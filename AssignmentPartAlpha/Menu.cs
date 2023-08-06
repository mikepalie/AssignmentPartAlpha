using AssignmentPartAlpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPartAlpha
{
    public class Menu
    {
        public void Start()
        {
            Console.WriteLine("\t\t Welcome to the coding school");
            Console.WriteLine("Input Data manually (Press 1)");
            Console.WriteLine("Synthetic Data (Press 2)");
            
        }

        public void ManuallyMenu()
        {
            ViewLists();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Create Student (Press 11)");
            Console.WriteLine("Create Trainer (Press 12)");
            Console.WriteLine("Create Course (Press 13)");
            Console.WriteLine("Create Assignment (Press 14)");
            Console.WriteLine("Merge Students - Assignments (Press 15)");
            Console.WriteLine("Merge Students - Courses (Press 16)");
            Console.WriteLine("Merge Trainers - Courses (Press 17)");
            Console.WriteLine("Merge Assignments - Courses (Press 18)");
            Console.ResetColor();
        }
        public void ViewLists()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("View List of all Students (Press 1)");
            Console.WriteLine("View List of all Trainers (Press 2)");
            Console.WriteLine("View List of all Courses (Press 3)");
            Console.WriteLine("View List of all Assignments (Press 4)");
            Console.WriteLine("View all Students Per Course (Press 5)");
            Console.WriteLine("View all Trainers Per Course (Press 6)");
            Console.WriteLine("View all Assignments Per Course (Press 7)");
            Console.WriteLine("View all Assignments Per Student (Press 8)");
            Console.WriteLine("View all Students with more than one course (Press 9)");
            Console.WriteLine("View all Students who need to submit one or more Assignments at a week (Press 10)");
            Console.WriteLine("Exit (Press 0)");
            Console.ResetColor();
        }

        public void PrintAllStudents(List<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Students");
            Console.ResetColor();

            if(students.Count == 0)
                Console.WriteLine("No Result Found!");

            foreach (var stu in students)
            {
                Console.WriteLine("================================");
                Console.WriteLine($"Firstname: {stu.FirstName }");
                Console.WriteLine($"Lastname: {stu.LastName }");
                Console.WriteLine($"Date of Birth: {stu.DateOfBirth }");
                Console.WriteLine($"Tuition Fees: {stu.TuitionFees }");
                Console.WriteLine("================================");
                Console.WriteLine();
            }
        }


        public void PrintAllTrainers(List<Trainer> trainers)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Trainers");
            Console.ResetColor();

            if (trainers.Count == 0)
                Console.WriteLine("No Result Found!");

            foreach (var tra in trainers)
            {
                Console.WriteLine("================================");
                Console.WriteLine($"Firstname: {tra.FirstName}");
                Console.WriteLine($"Lastname: {tra.LastName}");
                Console.WriteLine($"Subject: {tra.subject}");
                Console.WriteLine("================================");
                Console.WriteLine();
            }
        }

        public void PrintAllCourses(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Courses");
            Console.ResetColor();

            if (courses.Count == 0)
                Console.WriteLine("No Result Found!");

            foreach (var cou in courses)
            {
                Console.WriteLine("================================");
                Console.WriteLine($"Title: {cou.Title}");
                Console.WriteLine($"Stream: {cou.Stream}");
                Console.WriteLine($"Type: {cou.Type}");
                Console.WriteLine($"StartDate: {cou.StartDate}");
                Console.WriteLine($"EndDate: {cou.EndDate}");
                Console.WriteLine("================================");
                Console.WriteLine();
            }
        }

        public void PrintAllAssignments(List<Assignment> assignments)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Assignments");
            Console.ResetColor();

            if (assignments.Count == 0)
                Console.WriteLine("No Result Found!");

            foreach (var asn in assignments)
            {
                Console.WriteLine("================================");
                Console.WriteLine($"Title: {asn.Title}");
                Console.WriteLine($"Description: {asn.Description}");
                Console.WriteLine($"SubDateTime: {asn.SubDateTime}");
                Console.WriteLine($"OralMark: {asn.OralMark}");
                Console.WriteLine($"TotalMark: {asn.TotalMark}");
                Console.WriteLine("================================");
                Console.WriteLine();
            }
        }


        public void PrintStudentsPerCourse(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Students Per Course");
            Console.ResetColor();

            foreach (var course in courses)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("==================================");
                Console.WriteLine($"Students of {course.Title} {course.Type}: ");
                Console.WriteLine("==================================");
                Console.ResetColor();

                if (!Check.isEmptyList(course.Students))
                {
                    foreach (var student in course.Students)
                    {
                        Console.WriteLine(student.LastName);
                    }
                }
                else
                {
                    Console.WriteLine("No Student Found!");
                }
                
            }
        }

        public void PrintTrainersPerCourse(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Trainers Per Course");
            Console.ResetColor();

            foreach (var course in courses)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("==================================");
                Console.WriteLine($"Trainers of {course.Title} {course.Type}: ");
                Console.WriteLine("==================================");
                Console.ResetColor();

                foreach (var trainer in course.Trainers)
                {
                    Console.WriteLine(trainer.LastName);
                }
            }
        }

        public void PrintAssignmentsPerCourse(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Assignments Per Course");
            Console.ResetColor();

            foreach (var course in courses)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("==================================");
                Console.WriteLine($"Assignments of {course.Title} {course.Type}: ");
                Console.WriteLine("==================================");
                Console.ResetColor();

                foreach (var assignment in course.Assignments)
                {
                    Console.WriteLine(assignment.Title);
                }
            }
        }

        public void PrintAssignmentsPerStudent(List<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Assignments Per Student");
            Console.ResetColor();

            foreach (var student in students)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("==================================");
                Console.WriteLine($"Assignments of {student.LastName}: ");
                Console.WriteLine("==================================");
                Console.ResetColor();

                foreach (var assignment in student.Assignments)
                {
                    Console.WriteLine(assignment.Title);
                }
            }
        }

        public void PrintStudentsWithMoreThanOneCourse(List<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==================================");
            Console.WriteLine($"Students with more than one course: ");
            Console.WriteLine("==================================");
            Console.ResetColor();
            foreach (var student in students)
            {
                if(student.Courses.Count > 1)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(student.LastName);
                    Console.ResetColor();
                }
                foreach (var course in student.Courses)
                {
                    Console.WriteLine(course.Title + " " + course.Type);
                }
            }
        }

        public void PrintStudentsSubmitingDay(List<Student> students)
        {
            Console.WriteLine("Enter date(ex 2023-08-13): ");
            DateTime dt = Convert.ToDateTime(Console.ReadLine());
            int start = 0;
            int end = 0;
            switch(dt.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    start = dt.DayOfYear;
                    break;
                case DayOfWeek.Tuesday:
                    start = dt.DayOfYear - 1;
                    break;
                case DayOfWeek.Wednesday:
                    start = dt.DayOfYear - 2;
                    break;
                case DayOfWeek.Thursday:
                    start = dt.DayOfYear - 3;
                    break;
                case DayOfWeek.Friday:
                    start = dt.DayOfYear - 4; 
                    break;
                case DayOfWeek.Saturday:
                    start = dt.DayOfYear - 5;
                    break;
                case DayOfWeek.Sunday:
                    start = dt.DayOfYear - 6;
                    break;
            }
            end = start + 6;

            bool foundResult = false;
            foreach (var student in students)
            {
                foreach(var assignment in student.Assignments)
                {
                    if(assignment.SubDateTime.Year == dt.Year &&
                       assignment.SubDateTime.DayOfYear >= start &&
                       assignment.SubDateTime.DayOfYear <= end)
                    {
                        Console.WriteLine($"{student.LastName} {assignment.Title} {assignment.SubDateTime}");
                        foundResult = true;
                    }
                   
                }

            }
            if (!foundResult)
            {
                Console.WriteLine("No Result Found!");
            }
        }

        
    }
}
