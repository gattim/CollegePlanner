using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Planner {

    public static class Database {
        public static List<Professor> professors = new List<Professor>();
        public static List<Course> courses = new List<Course>();
        public static List<Task> tasks = new List<Task>();

        public static void addProfessor(Professor professor) { professors.Add(professor); }
        public static void addCourse(Course course) { courses.Add(course); }
        public static void addTask(Task task) { tasks.Add(task); }

    }
}
