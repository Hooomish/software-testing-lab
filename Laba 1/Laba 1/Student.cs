using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    public class Student
    {
        private List<int> Marks; //comment 4.1

        public string Name { get; set; } //comment 5..

        public Student(string Name) //comment 3..
        {
            this.Name = Name;
            this.Marks = new List<int>();
        }

        public void AddMark(int mark) //comment 2
        {
            if (mark >= 0 && mark <= 10)
                this.Marks.Add(mark);
        }

        public double? CalculateAverageMark() //comment 1
        {
            if (Marks.Count != 0)
                return Marks.Average();
            return null;
        }
    }
}
