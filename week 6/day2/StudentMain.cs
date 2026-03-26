using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6handson.day2
{
    internal class StudentMain
    {
        public static void Main()
        {
            StudentRepository std =new StudentRepository();

            Student s1 = new Student(1,"sai",95.4);
            Student s2 = new Student(2, "jeevan", 96);

            std.AddStudent(s1);
            std.AddStudent(s2);

            ReportGenerator report = new ReportGenerator();
            report.GenerateReport(std.GetStudents());
        }
    }
}
