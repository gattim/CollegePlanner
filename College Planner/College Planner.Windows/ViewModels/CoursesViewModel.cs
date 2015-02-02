using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using College_Planner.Models;

namespace College_Planner.ViewModels {
    class CoursesViewModel : ViewModelBase {
        private ObservableCollection<CourseViewModel> courses;
        public ObservableCollection<CourseViewModel> Courses {
            get {
                return courses;
            }

            set {
                courses = value;
                RaisePropertyChanged("Courses");
            }
        }
        private College_Planner.App app = (Application.Current as App);

        public ObservableCollection<CourseViewModel> GetCourses() {
            courses = new ObservableCollection<CourseViewModel>();
            using (var db = new SQLite.SQLiteConnection(app.DBPath)) {
                var query = db.Table<Course>().OrderBy(c => c.CourseName);
                foreach (var _course in query) {
                    var course = new CourseViewModel()
                    {
                        Id = _course.Id,
                        CourseCode = _course.CourseCode,
                        CourseName = _course.CourseName,
                        Credits = _course.Credits,
                        Prof = _course.Prof,
                        Building = _course.Building,
                        RoomNumber = _course.RoomNumber,
                        GradeStructure = _course.GradeStructure
                    };
                    courses.Add(course);
                }
            }
            return courses;
        }
    }
}
