using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using College_Planner.Models;
using Windows.UI.Xaml;

namespace College_Planner.ViewModels {
    public class CourseViewModel : ViewModelBase {
        #region Properties

        private int id = 0;
        public int Id {
            get {
                return id;
            }
            set {
                if (id == value) {
                    return;
                }
                id = value;
                RaisePropertyChanged("Id");
            }
        }

        private string courseCode = string.Empty;
        public string CourseCode {
            get {
                return courseCode;
            }
            set {
                if (courseCode == value) {
                    return;
                }
                courseCode = value;
                RaisePropertyChanged("CourseCode");
            }
        }

        private string courseName = string.Empty;
        public string CourseName {
            get {
                return courseName;
            }
            set {
                if (courseName == value) {
                    return;
                }
                courseName = value;
                RaisePropertyChanged("CourseName");
            }
        }

        private int credits = 0;
        public int Credits {
            get {
                return credits;
            }
            set {
                if (credits == value) {
                    return;
                }
                credits = value;
                RaisePropertyChanged("Credits");
            }
        }

        private Professor prof = null;
        public Professor Prof {
            get {
                return prof;
            }
            set {
                if (prof == value) {
                    return;
                }
                prof = value;
                RaisePropertyChanged("Professor");
            }
        }

        private string building = string.Empty;
        public string Building {
            get {
                return building;
            }
            set {
                if (building == value) {
                    return;
                }
                building = value;
                RaisePropertyChanged("Building");
            }
        }

        private string roomNumber = string.Empty;
        public string RoomNumber {
            get {
                return roomNumber;
            }
            set {
                if (roomNumber == value) {
                    return;
                }
                roomNumber = value;
                RaisePropertyChanged("RoomNumber");
            }
        }

        private Grades gradeStructure = null;
        public Grades GradeStructure {
            get {
                return gradeStructure;
            }
            set {
                if (gradeStructure == value) {
                    return;
                }
                gradeStructure = value;
                RaisePropertyChanged("GradeStructure");
            }
        }

        #endregion "Properties"

        private College_Planner.App app = (Application.Current as App);

        public CourseViewModel GetCourse(int courseId) {
            var course = new CourseViewModel();
            using (var db = new SQLite.SQLiteConnection(app.DBPath)) {
                var _course = (db.Table<Course>().Where(
                    c => c.Id == courseId)).Single();
                course.Id = _course.Id;
                course.CourseCode = _course.CourseCode;
                course.CourseName = _course.CourseName;
                course.Credits = _course.Credits;
                course.Prof = _course.Prof;
                course.Building = _course.Building;
                course.roomNumber = _course.RoomNumber;
                course.GradeStructure = _course.GradeStructure;
            }
            return course;
        }

        public string GetCourseName(int courseId) {
            string courseName = "Unknown";
            using (var db = new SQLite.SQLiteConnection(app.DBPath)) {
                var course = (db.Table<Course>().Where(
                    c => c.Id == courseId)).Single();
                courseName = course.CourseName;
            }
            return courseName;
        }

        public string SaveCourse(CourseViewModel course) {
            string result = string.Empty;
            using (var db = new SQLite.SQLiteConnection(app.DBPath)) {
                string change = string.Empty;
                try {
                    var existingCourse = (db.Table<Course>().Where(
                        c => c.Id == course.Id)).SingleOrDefault();

                    if (existingCourse != null) {
                        existingCourse.CourseCode = course.CourseCode;
                        existingCourse.CourseName = course.CourseName;
                        existingCourse.Credits = course.Credits;
                        existingCourse.Prof = course.Prof;
                        existingCourse.Building = course.Building;
                        existingCourse.RoomNumber = course.roomNumber;
                        existingCourse.GradeStructure = course.GradeStructure;
                        int success = db.Update(existingCourse);
                    } else {
                        int success = db.Insert(new Course()
                        {
                            Id = course.Id,
                            CourseCode = course.CourseCode,
                            CourseName = course.CourseName,
                            Credits = course.Credits,
                            Prof = course.Prof,
                            Building = course.Building,
                            RoomNumber = course.RoomNumber,
                            GradeStructure = course.GradeStructure
                        });
                    }
                    result = "Success";
                } catch (Exception ex) {
                    result = "This course was not saved.";
                }
            }
            return result;
        }

        public string DeleteCourse(int courseId) {
            string result = string.Empty;
            using (var db = new SQLite.SQLiteConnection(app.DBPath)) {
                var existingCourse = (db.Table<Course>().Where(
                    c => c.Id == courseId)).Single();
                result = (db.Delete(existingCourse) > 0) ? "Success" : "This course was not removed.";
            }
            return result;
        }

        public int GetCourseId() {
            int courseId = 0;
            using (var db = new SQLite.SQLiteConnection(app.DBPath)) {
                var courses = db.Table<Course>();
                if (courses.Count() > 0) {
                    courseId = (from c in db.Table<Course>() select c.Id).Max();
                    courseId++;
                } else {
                    courseId = 1;
                }
            }
            return courseId;
        }

    }
}
