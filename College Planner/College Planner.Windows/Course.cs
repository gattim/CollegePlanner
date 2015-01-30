using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Planner {
    public class Course {
        public string courseID { get; set; }
        public string courseName { get; set; }
        public int credits { get; set; }
        public Professor professor { get; set; }
        public string building { get; set; }
        public string roomNumber { get; set; }
        public Grades grades { get; set; }

        public string[,] week = new string[5, 2];


        public Course(string id, string name, int credits, string building, string roomNum) {
            courseID = id;
            courseName = name;
            this.credits = credits;
            this.building = building;
            roomNumber = roomNum;
        }

        public override string ToString() {
            return courseName;
        }
    }

}
