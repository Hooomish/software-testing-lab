using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    public class Group
    {
        private List<Student> Students = new List<Student>();
        
        public void AddStudent(Student student)
        {
            if (!student.Equals(null))
                Students.Add(student);
        }

        public double? CalculateAverageMark()
        {
            if (Students.Count == 0)
                return null;
            else
            {
                List<double?> studentsAverageMarks = new List<double?>();
                
                foreach (Student s in Students)
                {
                    studentsAverageMarks.Add(s.CalculateAverageMark());
                }
                if (studentsAverageMarks.Count == 0)
                    return null;
                else
                    return studentsAverageMarks.Average();
            }
        }
    }
}
