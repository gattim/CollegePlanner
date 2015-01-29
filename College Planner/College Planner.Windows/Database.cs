using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Planner {

    public class Database {
        private List<Professor> professors = new List<Professor>();
        private List<Course> courses = new List<Course>();
        private List<Task> tasks = new List<Task>();

        public void addProfessor(Professor professor) { professors.Add(professor); }
        public void addCourse(Course course) { courses.Add(course); }
        public void addTask(Task task) { tasks.Add(task); }

    }
}
