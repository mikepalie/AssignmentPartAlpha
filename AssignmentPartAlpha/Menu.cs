using AssignmentPartAlpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AssignmentPartAlpha
{
    public class Menu
    {
        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t WELCOME TO THE CODING SCHOOL");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Input Data manually (Press 1)");
            Console.WriteLine("Synthetic Data (Press 2)");
            Console.ResetColor();
            
        }

        public void ManuallyMenu()
        {
            ViewLists();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("(Press 11): ");
            Console.WriteLine("Create Student ");
            Console.Write("(Press 12): ");
            Console.WriteLine("Create Trainer ");
            Console.Write("(Press 13): ");
            Console.WriteLine("Create Course ");
            Console.Write("(Press 14): ");
            Console.WriteLine("Create Assignment ");
            Console.Write("(Press 15): ");
            Console.WriteLine("Merge Students - Courses ");
            Console.Write("(Press 16): ");
            Console.WriteLine("Merge Trainers - Courses ");
            Console.Write("(Press 17): ");
            Console.WriteLine("Merge Assignments - Courses ");
            Console.Write("(Press 18): ");
            Console.WriteLine("Merge Assignments - Students ");
   
            Console.ResetColor();
        }
        public void ViewLists()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("(Press 1): ");
            Console.WriteLine("View List of all Students ");
            Console.Write("(Press 2): ");
            Console.WriteLine("View List of all Trainers ");
            Console.Write("(Press 3): ");
            Console.WriteLine("View List of all Courses ");
            Console.Write("(Press 4): ");
            Console.WriteLine("View List of all Assignments ");
            Console.Write("(Press 5): ");
            Console.WriteLine("View all Students Per Course ");
            Console.Write("(Press 6): ");
            Console.WriteLine("View all Trainers Per Course ");
            Console.Write("(Press 7): ");
            Console.WriteLine("View all Assignments Per Course ");
            Console.Write("(Press 8): ");
            Console.WriteLine("View all Assignments Per Student ");
            Console.Write("(Press 9): ");
            Console.WriteLine("View all Students with more than one course ");
            Console.Write("(Press 10): ");
            Console.WriteLine("View all Students who need to submit one or more Assignments at a week ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("(Press 0): ");
            Console.WriteLine("Exit ");
            Console.ResetColor();
        }

        public void PrintAllStudents(HashSet<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Students");
            Console.ResetColor();

            if(students.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No Result Found!");
                Console.ResetColor();
            }

            foreach (var stu in students)
            {
                Console.WriteLine("================================");
                Console.WriteLine($"Student's Id: {stu.StudentId}");
                Console.WriteLine($"Firstname: {stu.FirstName }");
                Console.WriteLine($"Lastname: {stu.LastName }");
                Console.WriteLine($"Date of Birth: {stu.DateOfBirth }");
                Console.WriteLine($"Tuition Fees: {stu.TuitionFees }");
                Console.WriteLine("================================");
                Console.WriteLine();
            }
        }


        public void PrintAllTrainers(HashSet<Trainer> trainers)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Trainers");
            Console.ResetColor();

            if (trainers.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No Result Found!");
                Console.ResetColor();
            }

            foreach (var tra in trainers)
            {
                Console.WriteLine("================================");
                Console.WriteLine($"Trainer's Id: {tra.TrainerId}");
                Console.WriteLine($"Firstname: {tra.FirstName}");
                Console.WriteLine($"Lastname: {tra.LastName}");
                Console.WriteLine($"Subject: {tra.subject}");
                Console.WriteLine("================================");
                Console.WriteLine();
            }
        }

        public void PrintAllCourses(HashSet<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Courses");
            Console.ResetColor();

            if (courses.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No Result Found!");
                Console.ResetColor();
            }

            foreach (var cou in courses)
            {
                Console.WriteLine("================================");
                Console.WriteLine($"Course's Id: {cou.CourseId}");
                Console.WriteLine($"Title: {cou.Title}");
                Console.WriteLine($"Stream: {cou.Stream}");
                Console.WriteLine($"Type: {cou.Type}");
                Console.WriteLine($"StartDate: {cou.StartDate}");
                Console.WriteLine($"EndDate: {cou.EndDate}");
                Console.WriteLine("================================");
                Console.WriteLine();
            }
        }

        public void PrintAllAssignments(HashSet<Assignment> assignments)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Assignments");
            Console.ResetColor();

            if (assignments.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No Result Found!");
                Console.ResetColor();
            }

            foreach (var asn in assignments)
            {
                Console.WriteLine("================================");
                Console.WriteLine($"Assignment's Id: {asn.AssignmentId}");
                Console.WriteLine($"Title: {asn.Title}");
                Console.WriteLine($"Description: {asn.Description}");
                Console.WriteLine($"SubDateTime: {asn.SubDateTime}");
                Console.WriteLine($"OralMark: {asn.OralMark}");
                Console.WriteLine($"TotalMark: {asn.TotalMark}");
                Console.WriteLine("================================");
                Console.WriteLine();
            }
        }


        public void PrintStudentsPerCourse(HashSet<Course> courses)
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No Student Found!");
                    Console.ResetColor();
                }
                
            }
        }

        public void PrintTrainersPerCourse(HashSet<Course> courses)
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


                if (!Check.isEmptyList(course.Trainers))
                {
                    foreach (var trainer in course.Trainers)
                    {
                        Console.WriteLine(trainer.LastName);
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No Trainer Found!");
                    Console.ResetColor();
                }
            }
        }

        public void PrintAssignmentsPerCourse(HashSet<Course> courses)
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


                if (!Check.isEmptyList(course.Assignments))
                {
                    foreach (var assignment in course.Assignments)
                    {
                        Console.WriteLine(assignment.Title);
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No Assignment Found!");
                    Console.ResetColor();
                }
            }
        }

        public void PrintAssignmentsPerStudent(HashSet<Student> students)
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


                if (!Check.isEmptyList(student.Assignments))
                {
                    foreach (var assignment in student.Assignments)
                    {
                        Console.WriteLine(assignment.Title);
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No Assignment Found!");
                    Console.ResetColor();
                }
            }
        }

        public void PrintStudentsWithMoreThanOneCourse(HashSet<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==================================");
            Console.WriteLine($"Students with more than one course: ");
            Console.WriteLine("==================================");
            Console.ResetColor();
            bool thereIs = false;
            foreach (var student in students)
            {
                if(student.Courses.Count > 1)
                {
                    thereIs = true; 
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(student.LastName);
                    Console.ResetColor();
                    foreach (var course in student.Courses)
                    {
                        Console.WriteLine(course.Title + " " + course.Type);
                    }
                }               
            }
            if (!thereIs)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No Results Found! ");
                Console.ResetColor();
            }
        }

        public void PrintStudentsSubmitingDay(HashSet<Student> students)
        {
            DateTime dt = new DateTime(1111, 11, 11);
            string userInput = "";
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter date(ex 2023-08-13): ");
                Console.ResetColor();
                userInput = Console.ReadLine();

                if (Check.isDateTimeType(userInput))
                    DateTime.TryParse(userInput, out dt);
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter correct DateTime type :");
                    Console.ResetColor();
                }

            } while (!Check.isDateTimeType(userInput));
            
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
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{student.LastName} {assignment.Title} {assignment.SubDateTime}");
                        Console.ResetColor();
                        foundResult = true;
                    }
                   
                }

            }
            if (!foundResult)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No Result Found!");
                Console.ResetColor();
            }
        }

        public void MergeStudentsCourses(HashSet<Student> students, HashSet<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Choose from above Student and Course you want to merge");

            PrintAllStudents(students);
            PrintAllCourses(courses);

            Console.ForegroundColor = ConsoleColor.Green;

            // StudentId
            string input1 = "";
            int stuId = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter Student's Id :");
                Console.ResetColor();
                input1 = Console.ReadLine();
                if(Check.isInt(input1))
                     stuId = Convert.ToInt32(input1); 
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input! Please enter the number of Student's Id (ex. 13)");
                    Console.ResetColor();
                }    
            } while (!Check.isInt(input1));

            // courseId
            string input2 = "";
            int couId = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter Course's Id :");
                Console.ResetColor();
                input2 = Console.ReadLine();
                if (Check.isInt(input2))
                    couId = Convert.ToInt32(input2);
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input! Please enter the number of Course's Id (ex. 13)");
                    Console.ResetColor();
                }
            } while (!Check.isInt(input2));



            Student student1 = new Student();
            bool studentFound = false;
            bool courseFound = false;

            foreach (var stu in students)
            {
                if(stuId == stu.StudentId)
                {
                    student1 = stu;
                    studentFound = true;
                }
            }

            foreach (var course in courses)
            {
                if (couId == course.CourseId)
                {
                    courseFound = true;
                    course.Students.Add(student1);
                    student1.Courses.Add(course);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{course.Title } successfully merged with {student1.LastName}");
                    Console.ResetColor();

                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            if (!studentFound)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"No Student Found with id :{stuId}");
                Console.ResetColor();
            }
            if (!courseFound)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"No Course Found with id :{couId}");
                Console.ResetColor();
            }

            Console.ResetColor();
            Thread.Sleep(6000);
            Console.Clear();
        }

        public void MergeTrainersCourses(HashSet<Trainer> trainers, HashSet<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Choose from above Trainer and Course you want to merge");

            PrintAllTrainers(trainers);
            PrintAllCourses(courses);

            // TrainerId
            string input1 = "";
            int traId = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter Trainer's Id :");
                Console.ResetColor();
                input1 = Console.ReadLine();
                if (Check.isInt(input1))
                    traId = Convert.ToInt32(input1);
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input! Please enter the number of Trainer's Id (ex. 13)");
                    Console.ResetColor();
                }
            } while (!Check.isInt(input1));

            // courseId
            string input2 = "";
            int couId = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter Course's Id :");
                Console.ResetColor();
                input2 = Console.ReadLine();
                if (Check.isInt(input2))
                    couId = Convert.ToInt32(input2);
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input! Please enter the number of Course's Id (ex. 13)");
                    Console.ResetColor();
                }
            } while (!Check.isInt(input2));

            Trainer trainer1 = new Trainer();
            bool trainerFound = false;
            bool courseFound = false;

            foreach (var tra in trainers)
            {
                if (traId == tra.TrainerId)
                {
                    trainer1 = tra;
                    trainerFound = true;
                }
            }

            foreach (var course in courses)
            {
                if (couId == course.CourseId)
                {
                    course.Trainers.Add(trainer1);
                    courseFound = true;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{course.Title} successfully merged with {trainer1.LastName}");
                    Console.ResetColor();

                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }

            if (!trainerFound)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"No Trainer Found with id :{traId}");
                Console.ResetColor();
            }
            if (!courseFound)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"No Course Found with id :{couId}");
                Console.ResetColor();
            }
        }

        public void MergeAssignmentsCourses(HashSet<Assignment> assignments, HashSet<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Choose from above Assignment and Course you want to merge");

            PrintAllAssignments(assignments);
            PrintAllCourses(courses);

            // AssignmentId
            string input1 = "";
            int assId = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter Assignment's Id :");
                Console.ResetColor();
                input1 = Console.ReadLine();
                if (Check.isInt(input1))
                    assId = Convert.ToInt32(input1);
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input! Please enter the number of Assignment's Id (ex. 13)");
                    Console.ResetColor();
                }
            } while (!Check.isInt(input1));

            // courseId
            string input2 = "";
            int couId = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter Course's Id :");
                Console.ResetColor();
                input2 = Console.ReadLine();
                if (Check.isInt(input2))
                    couId = Convert.ToInt32(input2);
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input! Please enter the number of Course's Id (ex. 13)");
                    Console.ResetColor();
                }
            } while (!Check.isInt(input2));


            Assignment assignment1 = new Assignment();
            bool assignmentFound = false;
            bool courseFound = false;

            foreach (var ass in assignments)
            {
                if (assId == ass.AssignmentId)
                {
                    assignment1 = ass;
                    assignmentFound = true;
                }
            }

            foreach (var course in courses)
            {
                if (couId == course.CourseId)
                {
                    course.Assignments.Add(assignment1);
                    courseFound = true;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{course.Title} successfully merged with {assignment1.Title}");
                    Console.ResetColor();

                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }

            if (!assignmentFound)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"No Assignment Found with id :{assId}");
                Console.ResetColor();
            }
            if (!courseFound)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"No Course Found with id :{couId}");
                Console.ResetColor();
            }

        }

        public void MergeAssignmentsStudents(HashSet<Assignment> assignments, HashSet<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Choose from above Assignment and Student you want to merge");

            PrintAllAssignments(assignments);
            PrintAllStudents(students);

            // AssignmentId
            string input1 = "";
            int assId = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter Assignment's Id :");
                Console.ResetColor();
                input1 = Console.ReadLine();
                if (Check.isInt(input1))
                    assId = Convert.ToInt32(input1);
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input! Please enter the number of Assignment's Id (ex. 13)");
                    Console.ResetColor();
                }
            } while (!Check.isInt(input1));

            // StudentId
            string input2 = "";
            int stuId = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter Student's Id :");
                Console.ResetColor();
                input2 = Console.ReadLine();
                if (Check.isInt(input2))
                    stuId = Convert.ToInt32(input2);
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input! Please enter the number of Student's Id (ex. 13)");
                    Console.ResetColor();
                }
            } while (!Check.isInt(input2));

            Assignment assignment1 = new Assignment();
            bool assignmentFound = false;
            bool studentFound = false;

            foreach (var ass in assignments)
            {
                if (assId == ass.AssignmentId)
                {
                    assignment1 = ass;
                    assignmentFound = true;
                }
            }

            foreach (var stu in students)
            {
                if (stuId == stu.StudentId)
                {
                    stu.Assignments.Add(assignment1);
                    studentFound = true;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{stu.LastName} successfully merged with {assignment1.Title}");
                    Console.ResetColor();

                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }

            if (!assignmentFound)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"No Assignment Found with id :{assId}");
                Console.ResetColor();
            }
            if (!studentFound)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"No Student Found with id :{stuId}");
                Console.ResetColor();
            }
        }

    }
}
