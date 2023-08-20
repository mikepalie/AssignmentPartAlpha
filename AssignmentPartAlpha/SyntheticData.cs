using AssignmentPartAlpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPartAlpha
{
    public class SyntheticData
    {
        public List<Student> SyntheticStudents()
        {
            Student s1 = new Student() {
                StudentId = 1, FirstName = "Mike", LastName = "Palie", DateOfBirth = new DateTime(1991,03,14),
                TuitionFees = 2000
            };  

            Student s2 = new Student() {
                StudentId = 2,FirstName = "Jane", LastName = "Lubiz", DateOfBirth = new DateTime(1981,05,04),
                TuitionFees = 3000
            };      //2

            Student s3 = new Student() {
                StudentId = 3,FirstName = "Nick", LastName = "Kalos", DateOfBirth = new DateTime(1990,10,24),
                TuitionFees = 3000
            };      //3

            Student s4 = new Student() {
                StudentId = 4, FirstName = "Phil", LastName = "Jones", DateOfBirth = new DateTime(1993,12,01), 
                TuitionFees = 7000
            };      //4

            Student s5 = new Student() {
                StudentId = 5, FirstName = "Helen", LastName = "Philips", DateOfBirth = new DateTime(1999,06,01),
                TuitionFees = 12000
            };  //5

            Student s6 = new Student() {
                StudentId = 6, FirstName = "John", LastName = "Novers", DateOfBirth = new DateTime(2000,06,10),
                TuitionFees = 2500
            };     //6

            Student s7 = new Student() {
                StudentId = 7, FirstName = "Hew", LastName = "Ceena", DateOfBirth = new DateTime(1978,09,20),
                TuitionFees = 3800
            };       //7

            Student s8 = new Student() {
                StudentId = 8, FirstName = "Gary", LastName = "Lomorov", DateOfBirth = new DateTime(1983,02,14), 
                TuitionFees = 10000
            };   //8

            Student s9 = new Student() {
                StudentId = 9, FirstName = "Dan", LastName = "Cally", DateOfBirth = new DateTime(1989,08,28),
                TuitionFees = 12000
            };      //9

            Student s10 = new Student() {
                StudentId = 10, FirstName = "Mary", LastName = "Shein", DateOfBirth = new DateTime(1990,11,19), 
                TuitionFees = 22000
            };    //10

            Student s11 = new Student() {
                StudentId = 11, FirstName = "Eleni", LastName = "Rantou", DateOfBirth = new DateTime(1995,09,02), 
                TuitionFees = 1000
            };   //11

            Student s12 = new Student() {
                StudentId = 12, FirstName = "Maria", LastName = "Lappa", DateOfBirth = new DateTime(1996,06,18),
                TuitionFees = 1200
            };    //12

            Student s13 = new Student() {
                StudentId = 13, FirstName = "Ken", LastName = "Doherty", DateOfBirth = new DateTime(1998,08,17),
                TuitionFees = 2400
            };    //13

            Student s14 = new Student() {
                StudentId = 14, FirstName = "Mark", LastName = "Williams", DateOfBirth = new DateTime(1984,04,26), 
                TuitionFees = 12000
            }; //14

            Student s15 = new Student() {
                StudentId = 15, FirstName = "Toni", LastName = "Tavarez", DateOfBirth = new DateTime(1994,05,24),
                TuitionFees = 8000
            };   //15

            Student s16 = new Student() {
                StudentId = 16, FirstName = "Frank", LastName = "Goulouise", DateOfBirth = new DateTime(1985,09,03),
                TuitionFees = 5400
            };    //16

            Student s17 = new Student() {
                StudentId = 17, FirstName = "Lory", LastName = "Sinatra", DateOfBirth = new DateTime(1990,10,22),
                TuitionFees = 7000
            };       //17

            Student s18 = new Student() {
                StudentId = 18, FirstName = "Kathrin", LastName = "Rose", DateOfBirth = new DateTime(1985,09,30),
                TuitionFees = 6300
            };       //18

            Student s19 = new Student() {
                StudentId = 19, FirstName = "Sawn", LastName = "Steitham", DateOfBirth = new DateTime(1999,01,28),
                TuitionFees = 12000
            };     //19

            Student s20 = new Student() {
                StudentId = 20, FirstName = "Keicy", LastName = "Corey", DateOfBirth = new DateTime(2003,03,16),
                TuitionFees = 2200
            };        //20

            List<Student> students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20 };

            return students;
        }

        public List<Trainer> SyntheticTrainers()
        {
            Trainer t1 = new Trainer() { TrainerId = 1, FirstName = "Dimitris", LastName = "Dedes", subject = "C#" };
            Trainer t2 = new Trainer() { TrainerId = 2, FirstName = "Ioanna", LastName = "Deli", subject = "Java" };
            Trainer t3 = new Trainer() { TrainerId = 3, FirstName = "Xristina", LastName = "Moustaka", subject = "C#" };
            Trainer t4 = new Trainer() { TrainerId = 4, FirstName = "Kostas", LastName = "Nioras", subject = "Python" };
            Trainer t5 = new Trainer() { TrainerId = 5, FirstName = "Evagelia", LastName = "Salata", subject = "Java" };
            Trainer t6 = new Trainer() { TrainerId = 6, FirstName = "Xristos", LastName = "Tsaousis", subject = "C#" };
            Trainer t7 = new Trainer() { TrainerId = 7, FirstName = "Eleftheria", LastName = "Moutakidou", subject = "Python" };
            Trainer t8 = new Trainer() { TrainerId = 8, FirstName = "Xaralampos", LastName = "Ioannou", subject = "C#" };

            List<Trainer> trainers = new List<Trainer>() { t1, t2, t3, t4, t5, t6, t7, t8 };

            return trainers;
        }

        public List<Course> SyntheticCourses()
        {
            Course c0 = new Course() { CourseId = 1, Title = "C#", Stream = "CB8", Type = "Full Time", 
                StartDate = new DateTime(2023, 08, 12),
                EndDate = new DateTime(2024, 02, 12) ,
                
            };

            Course c1 = new Course() { CourseId = 2, Title = "Java", Stream = "CB9", Type = "Part Time", 
                StartDate = new DateTime(2023, 08, 12),
                EndDate = new DateTime(2023, 11, 12),
               
            };
            Course c2 = new Course() { CourseId = 3, Title = "Java", Stream = "CB10", Type = "Full Time", 
                StartDate = new DateTime(2023, 10, 22),
                EndDate = new DateTime(2024, 04, 22), 
               
            };
            Course c3 = new Course() { CourseId = 4, Title = "C#", Stream = "CB11", Type = "Part Time", 
                StartDate = new DateTime(2022, 02, 15),
                EndDate = new DateTime(2022, 05, 15),
                
            };

            List<Course> courses = new List<Course>() {c0, c1, c2, c3};

            return courses;
        }

        public List<Assignment> SyntheticAssignments()
        {
            Assignment a1 = new Assignment() { AssignmentId = 1, Title = "Donut App", Description = "An application about a donuts shop", SubDateTime = new DateTime(2023,11,13), OralMark = 88, TotalMark = 86};
            Assignment a2 = new Assignment() { AssignmentId = 2, Title = "Weather Forecast", Description = "An application about the weather in your country", SubDateTime = new DateTime(2023,02,20), OralMark = 98, TotalMark = 96};
            Assignment a3 = new Assignment() { AssignmentId = 3, Title = "Soccer Maniac", Description = "A trivial game about soccer", SubDateTime = new DateTime(2023,01,10), OralMark = 98, TotalMark = 96};
            Assignment a4 = new Assignment() { AssignmentId = 4, Title = "Movie Place", Description = "A site about movies of a  Cinema", SubDateTime = new DateTime(2023,03,23), OralMark = 68, TotalMark = 76};
            Assignment a5 = new Assignment() { AssignmentId = 5, Title = "Pokemon", Description = "A game with pokemon cards", SubDateTime = new DateTime(2023,02,23), OralMark = 88, TotalMark = 86};
            Assignment a6 = new Assignment() { AssignmentId = 6, Title = "Looney Tunes", Description = "A shop with Looney tunes stickers", SubDateTime = new DateTime(2023,01,23), OralMark = 78, TotalMark = 96};
            Assignment a7 = new Assignment() { AssignmentId = 7, Title = "Travel Agent", Description = "A site about holiday tickets", SubDateTime = new DateTime(2023,03,23), OralMark = 90, TotalMark = 87};
            Assignment a8 = new Assignment() { AssignmentId = 8, Title = "Jobs", Description = "A site with job opportunities", SubDateTime = new DateTime(2023,06,23), OralMark = 56, TotalMark = 78};


            List<Assignment> assignments = new List<Assignment>() { a1, a2, a3, a4, a5, a6, a7, a8 };

            return assignments;

        }

        public void StudentsCourses(List<Student> students, List<Course> courses)
        {
            students[0].Courses = new HashSet<Course> { courses[0], courses[1] };
            students[1].Courses = new HashSet<Course> { courses[1], courses[2] };
            students[2].Courses = new HashSet<Course> { courses[0], courses[3] };
            students[3].Courses = new HashSet<Course> { courses[1], courses[3] };
            students[4].Courses = new HashSet<Course> { courses[1], courses[2] };
            students[5].Courses = new HashSet<Course> { courses[2], courses[3] };
            students[6].Courses = new HashSet<Course> { courses[0], courses[1] };
            students[7].Courses = new HashSet<Course> { courses[0], courses[2] };
            students[8].Courses = new HashSet<Course> { courses[1], courses[2] };
            students[9].Courses = new HashSet<Course> { courses[2], courses[3] };
            students[10].Courses = new HashSet<Course> { courses[3], courses[1] };
            students[11].Courses = new HashSet<Course> { courses[1], courses[0] };
            students[12].Courses = new HashSet<Course> { courses[2], courses[0] };
            students[13].Courses = new HashSet<Course> { courses[3], courses[2] };
            students[14].Courses = new HashSet<Course> { courses[2], courses[1] };
            students[15].Courses = new HashSet<Course> { courses[1], courses[3] };
            students[16].Courses = new HashSet<Course> { courses[0], courses[2] };
            students[17].Courses = new HashSet<Course> { courses[0], courses[3] };
            students[18].Courses = new HashSet<Course> { courses[3], courses[0] };
            students[19].Courses = new HashSet<Course> { courses[2], courses[3] };


            courses[0].Students = new HashSet<Student>
            {
                students[0], students[2], students[6], students[7],students[11], students[12], students[16], students[17], students[18]
            };
            courses[1].Students = new HashSet<Student>
            {
                students[0], students[1], students[3], students[4],students[6], students[8], students[10], students[11], students[14],students[15]
            };
            courses[2].Students = new HashSet<Student>
            {
                students[1], students[4], students[5], students[7],students[8], students[9], students[12], students[13], students[14], students[16], students[19]
            };
            courses[3].Students = new HashSet<Student>
            {
                students[2], students[3], students[5], students[9],students[10], students[13], students[15], students[17], students[18], students[19]
            };

        } 

        public void TrainersCourses(List<Trainer> trainers, List<Course> courses)
        {
            trainers[0].Courses = new HashSet<Course> { courses[1], courses[2] };
            trainers[1].Courses = new HashSet<Course> { courses[0], courses[3] };
            trainers[2].Courses = new HashSet<Course> { courses[1] };
            trainers[3].Courses = new HashSet<Course> { courses[2], courses[3] };
            trainers[4].Courses = new HashSet<Course> { courses[1], courses[2] };
            trainers[5].Courses = new HashSet<Course> { courses[0] };
            trainers[6].Courses = new HashSet<Course> { courses[2], courses[3] };
            trainers[7].Courses = new HashSet<Course> { courses[2] };

            courses[0].Trainers = new HashSet<Trainer> { trainers[1], trainers[5] }; 
            courses[1].Trainers = new HashSet<Trainer> { trainers[0], trainers[2], trainers[4] }; 
            courses[2].Trainers = new HashSet<Trainer> { trainers[0], trainers[3], trainers[4], trainers[6], trainers[7] }; 
            courses[3].Trainers = new HashSet<Trainer> { trainers[1], trainers[3], trainers[6] }; 
        }

        public void AssignmentsCourses(List<Assignment> assignments, List<Course> courses)
        {
            courses[0].Assignments = new HashSet<Assignment> { assignments[0], assignments[2] };
            courses[1].Assignments = new HashSet<Assignment> { assignments[1], assignments[3] };
            courses[2].Assignments = new HashSet<Assignment> { assignments[5], assignments[7] };
            courses[3].Assignments = new HashSet<Assignment> { assignments[4], assignments[6] };

            assignments[0].Course = courses[0];
            assignments[1].Course = courses[1];
            assignments[2].Course = courses[0];
            assignments[3].Course = courses[1];
            assignments[4].Course = courses[3];
            assignments[5].Course = courses[2];
            assignments[6].Course = courses[3];
            assignments[7].Course = courses[2];


        }

        public void AssignmentsStudents(List<Assignment> assignments, List<Student> students)
        {
            assignments[0].Students = new HashSet<Student> { students[0], students[2], students[8], students[10], students[14] };
            assignments[1].Students = new HashSet<Student> { students[1], students[3], students[18], students[11], students[13] };
            assignments[2].Students = new HashSet<Student> { students[1], students[3], students[7], students[10], students[19] };
            assignments[3].Students = new HashSet<Student> { students[4], students[5], students[6], students[9], students[12] };
            assignments[4].Students = new HashSet<Student> { students[0], students[2], students[8], students[10], students[14] };
            assignments[5].Students = new HashSet<Student> { students[1], students[3], students[18], students[11], students[13] };
            assignments[6].Students = new HashSet<Student> { students[1], students[3], students[7], students[10], students[19] };
            assignments[7].Students = new HashSet<Student> { students[4], students[5], students[6], students[9], students[12] };

            students[0].Assignments = new HashSet<Assignment> { assignments[0], assignments[4] };
            students[1].Assignments = new HashSet<Assignment> { assignments[1], assignments[2], assignments[5], assignments[6] };
            students[2].Assignments = new HashSet<Assignment> { assignments[0], assignments[4] };
            students[3].Assignments = new HashSet<Assignment> { assignments[1], assignments[2], assignments[5], assignments[6] };
            students[4].Assignments = new HashSet<Assignment> { assignments[3], assignments[7] };
            students[5].Assignments = new HashSet<Assignment> { assignments[3], assignments[7] };
            students[6].Assignments = new HashSet<Assignment> { assignments[3], assignments[7] };
            students[7].Assignments = new HashSet<Assignment> { assignments[2], assignments[6] };
            students[8].Assignments = new HashSet<Assignment> { assignments[0], assignments[4] };
            students[9].Assignments = new HashSet<Assignment> { assignments[3], assignments[7] };
            students[10].Assignments = new HashSet<Assignment> { assignments[0], assignments[2], assignments[4], assignments[6] };
            students[11].Assignments = new HashSet<Assignment> { assignments[1], assignments[5] };
            students[12].Assignments = new HashSet<Assignment> { assignments[3], assignments[7] };
            students[13].Assignments = new HashSet<Assignment> { assignments[1], assignments[5] };
            students[14].Assignments = new HashSet<Assignment> { assignments[0], assignments[4] };
            students[15].Assignments = new HashSet<Assignment> { assignments[0], assignments[4] };
            students[16].Assignments = new HashSet<Assignment> { assignments[2], assignments[6] };
            students[17].Assignments = new HashSet<Assignment> { assignments[1], assignments[5] };
            students[18].Assignments = new HashSet<Assignment> { assignments[3], assignments[7] };
            students[19].Assignments = new HashSet<Assignment> { assignments[2], assignments[6] };
        }
    }
}
