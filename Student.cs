using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3a_student_grades
{
    public class Student
    {
        public string Name { get; set; }
        public List<int> Grades { get; set; }
        public double AverageGrade
        {
            get { return Grades.Average(); }
        }

        public string LetterGrade 
        { get
                { return GradingService.EvaluateGrade(AverageGrade); }
        }
        
    }
}