using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Planner.Models {
    public class Course {
        [SQLite.PrimaryKey]
        public int Id { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public Professor Prof { get; set; }
        public string Building { get; set; }
        public string RoomNumber { get; set; }
        public Grades GradeStructure { get; set; }
    }
}
