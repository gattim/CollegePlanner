using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace College_Planner {
    public sealed partial class CourseAdder : UserControl {
        public event Action<Course> AddCourse;
        private Grades grades;

        public CourseAdder() {
            InitializeComponent();
            popProfessor.AddProfessor += addProfessorToCbx;
            popGrades.AddGrades += PopGrades_AddGrades;
        }

        public void pop() {
            popup.IsOpen = true;
        }

        public void drop() {
            clear();
            popup.IsOpen = false;
        }

        private void clear() {
            txtID.Text = "";
            txtName.Text = "";
            txtRoom.Text = "";
            tbMon.IsChecked = false;
            tbTues.IsChecked = false;
            tbWed.IsChecked = false;
            tbThurs.IsChecked = false;
            tbFri.IsChecked = false;
            grades = null;
        }

        public ProfessorAdder getProfessorAdder() { return popProfessor; }

        private void addProfessorToCbx(Professor professor) {
            cbxProfessor.Items.Add(professor.name);
            cbxProfessor.SelectedValue = professor.name;
        }
        private void PopGrades_AddGrades(Grades g) {
            grades = g;
        }

        private void btnAddProfessor_Click(object sender, RoutedEventArgs e) {
            popProfessor.pop();
        }

        private void addLab_Click(object sender, RoutedEventArgs e) {
            popLab.pop();
        }

        private void addGrades_Click(object sender, RoutedEventArgs e) {
            popGrades.pop();
        }

        private void submit_Click(object sender, RoutedEventArgs e) {
            int credits = 0;
            bool flagReturn = (txtID.Text == "" || txtName.Text == "") ? true :  false;
            txtID.Background = (txtID.Text == "") ? new SolidColorBrush(Colors.Yellow) : new SolidColorBrush(Colors.WhiteSmoke);
            txtName.Background = (txtName.Text == "") ? new SolidColorBrush(Colors.Yellow) : new SolidColorBrush(Colors.WhiteSmoke);
            try {
                credits = Int32.Parse(txtCredits.Text);
                txtCredits.Background = new SolidColorBrush(Colors.WhiteSmoke);
            } catch {
                txtCredits.Background = new SolidColorBrush(Colors.Yellow);
                txtCredits.Text = "";
                flagReturn = true;
            }
            if (flagReturn) return;
            Course course = new Course(txtID.Text, txtName.Text, credits, txtBuilding.Text, txtRoom.Text);
            course.professor = cbxProfessor.SelectedItem as Professor;
            if (grades != null) course.grades = grades;   
            AddCourse(course);
            drop();
        }

        private void cancel_Click(object sender, RoutedEventArgs e) {
            drop();
        }
    }
}