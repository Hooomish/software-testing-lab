using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    public class Student
    {
        private List<int> Marks;

        public string Name { get; set; }

        public Student(string Name)
        {
            this.Name = Name;
            this.Marks = new List<int>();
        }

        public void AddMark(int mark)
        {
            if (mark >= 0 && mark <= 10)
                this.Marks.Add(mark);
        }

        public double? CalculateAverageMark()
        {
            if (Marks.Count != 0)
                return Marks.Average();
            return null;
        }
    }
}
