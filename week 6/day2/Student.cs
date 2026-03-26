using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6handson.day2
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public double StudentMarks { get; set; }

        public Student(int Id, string Name, double Marks)
        {
            StudentId = Id;
            StudentName = Name;
            StudentMarks = Marks;
        }
    }

    public class StudentRepository
    {
        private List<Student> students = new List<Student>();
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public List<Student> GetStudents()
        {
            return students;
        }
    }

    public class ReportGenerator
    {
        public void GenerateReport(List<Student> students)
        {
            Console.WriteLine("===Student report===");

            foreach (var student in students)
            {
                Console.WriteLine($"Student {student.StudentId}");
                Console.WriteLine(student.StudentName);
                Console.WriteLine(student.StudentMarks);
            }
        }
    }
}
