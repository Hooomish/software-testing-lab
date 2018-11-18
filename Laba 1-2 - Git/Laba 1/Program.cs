using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Nastya");
            Student student2 = new Student("Leha");
            Student student3 = new Student("Yura");

            student1.AddMark(4);
            student1.AddMark(9);

            student2.AddMark(7);
            student2.AddMark(8);
            student2.AddMark(9);

            student3.AddMark(6);
            student3.AddMark(10);

            Group group = new Group();

            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);

            var averageStudent2 = student2.CalculateAverageMark();
            var averageGroup = group.CalculateAverageMark();
        }
    }
}
