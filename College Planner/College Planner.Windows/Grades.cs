using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Planner {
    public class Grades {
        private List<Grade> grades;

        public Grades() {
            grades = new List<Grade>();
        }

        public void addGrade(Grade grade) {
            grades.Add(grade);
        }

        public List<Grade> getGrades() {
            return grades;
        }
    }
}
