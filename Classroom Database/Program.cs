using System;
using System.Collections.Generic;

namespace ClassroomDatabase
{
    public class Program
    {
        static void Main(string[] args)
        {
            School school = new School();

            // Create teachers
            Teacher teacher1 = new Teacher { TeacherId = 1, Name = "John Doe" };
            Teacher teacher2 = new Teacher { TeacherId = 2, Name = "Jane Smith" };
            Teacher teacher3 = new Teacher { TeacherId = 3, Name = "David Johnson" };

            // Create courses
            Course course1 = new Course { CourseId = 1, Name = "Math" };
            Course course2 = new Course { CourseId = 2, Name = "Science" };
            Course course3 = new Course { CourseId = 3, Name = "English" };
            Course course4 = new Course { CourseId = 4, Name = "History" };

            // Create classrooms
            Classroom classroom1 = new Classroom { ClassroomId = 1, Name = "Classroom 1", Teacher = teacher1 };
            Classroom classroom2 = new Classroom { ClassroomId = 2, Name = "Classroom 2", Teacher = teacher2 };
            Classroom classroom3 = new Classroom { ClassroomId = 3, Name = "Classroom 3", Teacher = teacher3 };

            // Create students
            Student student1 = new Student { StudentId = 1, Name = "Alice", Classroom = classroom1 };
            Student student2 = new Student { StudentId = 2, Name = "Bob", Classroom = classroom1 };
            Student student3 = new Student { StudentId = 3, Name = "Charlie", Classroom = classroom2 };
            Student student4 = new Student { StudentId = 4, Name = "David", Classroom = classroom2 };
            Student student5 = new Student { StudentId = 5, Name = "Eve", Classroom = classroom3 };
            Student student6 = new Student { StudentId = 6, Name = "Frank", Classroom = classroom3 };

            // Assign courses to teachers
            teacher1.Course = course1;
            teacher2.Course = course2;
            teacher3.Course = course3;

            // Add students to classrooms
            classroom1.Students.Add(student1);
            classroom1.Students.Add(student2);
            classroom2.Students.Add(student3);
            classroom2.Students.Add(student4);
            classroom3.Students.Add(student5);
            classroom3.Students.Add(student6);

            // Add classrooms to the school
            school.Classrooms.Add(classroom1);
            school.Classrooms.Add(classroom2);
            school.Classrooms.Add(classroom3);

            // Print classroom information
            foreach (var classroom in school.Classrooms)
            {
                Console.WriteLine($"Classroom ID: {classroom.ClassroomId}");
                Console.WriteLine($"Classroom Name: {classroom.Name}");
                Console.WriteLine($"Teacher Name: {classroom.Teacher.Name}");
                Console.WriteLine($"Course Name: {classroom.Teacher.Course.Name}");
                Console.WriteLine("Students:");

                foreach (var student in classroom.Students)
                {
                    Console.WriteLine($"- {student.Name}");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }

    public class School
    {
        public List<Classroom> Classrooms { get; set; }

        public School()
        {
            Classrooms = new List<Classroom>();
        }
    }

    public class Classroom
    {
        public int ClassroomId { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        public Classroom()
        {
            Students = new List<Student>();
        }
    }

    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public Course Course { get; set; }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public Classroom Classroom { get; set; }
    }
}
