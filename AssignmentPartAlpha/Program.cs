using AssignmentPartAlpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AssignmentPartAlpha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Trainer> trainers = new List<Trainer>();
            List<Course> courses = new List<Course>();
            List<Assignment> assignments = new List<Assignment>();

            Menu menu = new Menu();

            menu.Start();
            int choiceOne = int.Parse(Console.ReadLine());
            Console.Clear();

            if (choiceOne == 1)
            {
                int choiceTwo;
                do
                {
                    menu.ManuallyMenu();
                    choiceTwo = int.Parse(Console.ReadLine());
                    Console.Clear();
                    //Console.Clear();
                    //Console.WriteLine("View List of all Students (Press 1)");
                    //Console.WriteLine("View List of all Trainers (Press 2)");
                    //Console.WriteLine("View List of all Courses (Press 3)");
                    //Console.WriteLine("View List of all Assignments (Press 4)");
                    //Console.WriteLine("View all Students Per Course (Press 5)");
                    //Console.WriteLine("View all Trainers Per Course (Press 6)");
                    //Console.WriteLine("View all Assignments Per Course (Press 7)");
                    //Console.WriteLine("View all Assignments Per Student (Press 8)");
                    //Console.WriteLine("View all Students with more than one course (Press 9)");
                    //Console.WriteLine("View all Students who need to submit one or more Assignments at a week (Press 10)");
                    //Console.WriteLine("Exit (Press 0)");
                    //Console.WriteLine("Create Student (Press 11)");
                    //Console.WriteLine("Create Trainer (Press 12)");
                    //Console.WriteLine("Create Course (Press 13)");
                    //Console.WriteLine("Create Assignment (Press 14)");
                    //Console.WriteLine("Merge Students - Assignments (Press 15)");
                    //Console.WriteLine("Merge Students - Courses (Press 16)");
                    //Console.WriteLine("Merge Trainers - Courses (Press 17)");
                    //Console.WriteLine("Merge Assignments - Courses (Press 18)");

                    switch (choiceTwo)
                    {
                        case 1:
                            menu.PrintAllStudents(students);
                            break;
                        case 2:
                            menu.PrintAllTrainers(trainers);
                            break;
                        case 3:
                            menu.PrintAllCourses(courses);
                            break;
                        case 4:
                            menu.PrintAllAssignments(assignments);
                            break;
                        case 5:
                            if (!Check.isEmptyList(courses))
                            {
                                menu.PrintStudentsPerCourse(courses);
                            }
                            else
                            {
                                Console.WriteLine("No Courses Found!");
                            }
                            break;
                        case 6:
                            menu.PrintTrainersPerCourse(courses);
                            break;
                        case 7:
                            menu.PrintAssignmentsPerCourse(courses);
                            break;
                        case 8:
                            menu.PrintAssignmentsPerStudent(students);
                            break;
                        case 9:
                            menu.PrintStudentsWithMoreThanOneCourse(students);
                            break;
                        case 10:
                            menu.PrintStudentsSubmitingDay(students);
                            break;
                        case 11:
                            Student s1 = Student.CreateStudent();
                            students.Add(s1);
                            break;
                        case 12:
                            Trainer t1 = Trainer.CreateTrainer();
                            trainers.Add(t1);
                            break;
                        case 13:
                            Course c1 = Course.CreateCourse();
                            courses.Add(c1);
                            break;
                        case 14:
                            Assignment a1 = Assignment.CreateAssignment();
                            assignments.Add(a1);
                            break;
                        case 15:
                            break;
                        case 16:
     
                            break;
                        case 17:
                     
                            break;
                        case 18:
                   
                            break;
                        default:
                            break;                        
                    }
                    
                } while (choiceTwo != 0);

            }
            else
            {
                SyntheticData synthData = new SyntheticData();
                students.AddRange(synthData.SyntheticStudents());
                trainers.AddRange(synthData.SyntheticTrainers());
                courses.AddRange(synthData.SyntheticCourses());
                assignments.AddRange(synthData.SyntheticAssignments());

                synthData.StudentsCourses(students, courses);
                synthData.TrainersCourses(trainers, courses);
                synthData.AssignmentsCourses(assignments, courses);
                synthData.AssignmentsStudents(assignments, students);

                Console.WriteLine("Synthetic Data successfully created!");
                Thread.Sleep(2000);

                Console.Clear();

                int choiceThree;
                do
                {
                    menu.ViewLists();
                    choiceThree = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (choiceThree)
                    {
                        case 1:
                            menu.PrintAllStudents(students);
                            break;
                        case 2:
                            menu.PrintAllTrainers(trainers);
                            break;
                        case 3:
                            menu.PrintAllCourses(courses);
                            break;
                        case 4:
                            menu.PrintAllAssignments(assignments);
                            break;
                        case 5:
                            menu.PrintStudentsPerCourse(courses);
                            break;
                        case 6:
                            menu.PrintTrainersPerCourse(courses);
                            break;
                        case 7:
                            menu.PrintAssignmentsPerCourse(courses);
                            break;
                        case 8:
                            menu.PrintAssignmentsPerStudent(students);
                            break;
                        case 9:
                            menu.PrintStudentsWithMoreThanOneCourse(students);
                            break;
                        case 10:

                            menu.PrintStudentsSubmitingDay(students);
                            break;
                        default:
                            break;
                    }
                } while (choiceThree != 0);
            }

            

        }
        
    }
}
