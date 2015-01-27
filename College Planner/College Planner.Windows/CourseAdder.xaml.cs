using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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

        public CourseAdder() {
            this.InitializeComponent();
        }

        public void pop() {
            popup.IsOpen = true;
        }

        public void drop() {
            clear();
            popup.IsOpen = false;
        }

        private void addLab_Click(object sender, RoutedEventArgs e) {

        }

        private void submit_Click(object sender, RoutedEventArgs e) {
            AddCourse(new Course(txtID.Text, txtName.Text, cbxBuilding.SelectedItem.ToString(), txtRoom.Text));
            drop();
        }

        private void addGrades_Click(object sender, RoutedEventArgs e) {

        }

        private void cancel_Click(object sender, RoutedEventArgs e) {
            drop();
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
        }

        private void btnAddBuilding_Click(object sender, RoutedEventArgs e) {
            popBuilding.IsOpen = true;
        }

        private void btnAddProfessor_Click(object sender, RoutedEventArgs e) {

        }

        private void BuildingAddSubmit_Click(object sender, RoutedEventArgs e) {
            cbxBuilding.Items.Add(txtBuilding.Text);
        }

        private void BuildingAddCancel_Click(object sender, RoutedEventArgs e) {
            popBuilding.IsOpen = false;
        }
    }
}