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
            
            int choiceOne;
            bool isValid1;
            do
            {
                menu.Start();
                isValid1 = Check.isValidInput1(Console.ReadLine(),out choiceOne);
                    
            } while (!isValid1);
            
           


            if (choiceOne == 1)
            {
                int choiceTwo;
                do
                {
                    menu.ManuallyMenu();
                    choiceTwo = int.Parse(Console.ReadLine());
                    Console.Clear();

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
                                menu.PrintStudentsPerCourse(courses);
                            else
                                Console.WriteLine("No Courses Found!");
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
                            menu.MergeStudentsCourses(students, courses);
                            break;
                        case 16:
                            menu.MergeTrainersCourses(trainers, courses);
                            break;
                        case 17:
                            menu.MergeAssignmentsCourses(assignments, courses); 
                            break;
                        case 18:
                            menu.MergeAssignmentsStudents(assignments, students);
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



//Console.WriteLine("enter your choice 1 or two: ");
//int input = int.TryParse(Console.ReadLine());
