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
            HashSet<Student> students = new HashSet<Student>();
            HashSet<Trainer> trainers = new HashSet<Trainer>();
            HashSet<Course> courses = new HashSet<Course>();
            HashSet<Assignment> assignments = new HashSet<Assignment>();

            Menu menu = new Menu();
            
            int choiceOne;
            bool isValid1;

            int choiceTwo;
            bool isValid2;
            do
            {
                menu.Start();
                isValid1 = Check.isValidInput1(Console.ReadLine(),out choiceOne);
                    
            } while (!isValid1);
            Console.Clear();
           


            if (choiceOne == 1)
            {
                do
                {


                    do
                    {
                        menu.ManuallyMenu();
                        isValid2 = Check.isValidInput2(Console.ReadLine(), out choiceTwo);

                    } while (!isValid2);
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
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("No Courses Found!");
                                Console.ResetColor();
                            }
                            break;

                        case 6:

                            if (!Check.isEmptyList(courses))
                                menu.PrintTrainersPerCourse(courses);
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("No Courses Found!");
                                Console.ResetColor();
                            }
                            break;
                            
                        case 7:

                            if (!Check.isEmptyList(courses))
                                menu.PrintAssignmentsPerCourse(courses);
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("No Courses Found!");
                                Console.ResetColor();
                            }
                            break;

                        case 8:

                            if(!Check.isEmptyList(students))
                                menu.PrintAssignmentsPerStudent(students);
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("No Students Found!");
                                Console.ResetColor();
                            }
                            break;

                        case 9:
                            if(!Check.isEmptyList(students))
                                menu.PrintStudentsWithMoreThanOneCourse(students);
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("No Students Found!");
                                Console.ResetColor();
                            }
                            break;
                        case 10:
                            if(!Check.isEmptyList(students))
                                menu.PrintStudentsSubmitingDay(students);
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("No Students Found!");
                                Console.ResetColor();
                            }
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

                List<Student> synthStudents = synthData.SyntheticStudents();
                List<Course> synthCourses = synthData.SyntheticCourses();
                List<Trainer> synthTrainers = synthData.SyntheticTrainers();
                List<Assignment> synthAssignments = synthData.SyntheticAssignments();


                synthData.StudentsCourses(synthStudents, synthCourses);
                synthData.TrainersCourses(synthTrainers, synthCourses);
                synthData.AssignmentsCourses(synthAssignments, synthCourses);
                synthData.AssignmentsStudents(synthAssignments, synthStudents);

                students.UnionWith(synthStudents);
                trainers.UnionWith(synthTrainers);
                courses.UnionWith(synthCourses);
                assignments.UnionWith(synthAssignments);


                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Synthetic Data successfully created!");
                Console.ResetColor();
                Thread.Sleep(2000);

                Console.Clear();

                int choiceThree;
                bool isValid3 = false;
                do
                {
                    do
                    {
                        menu.ViewLists();

                        isValid3 = Check.isValidInput3(Console.ReadLine(), out choiceThree);

                    } while (!isValid3);
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




