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
    public sealed partial class GradesAdder : UserControl {
        double totalPercent = 0;
        public event Action<Grades> AddGrades;
        Grades grades = new Grades();
        public GradesAdder() {
            this.InitializeComponent();
        }

        public void pop() {
            popup.IsOpen = true;
        }

        public void drop() {
            clear();
            popup.IsOpen = false;
        }

        public void clear() {
            txtWarning.Visibility = Visibility.Collapsed;
            txtType.Text = "";
            txtPercent.Text = "";
            lbType.Items.Clear();
        }

        private void Add_Click(object sender, RoutedEventArgs e) {
            bool flagReturn = (txtType.Text == "" || txtPercent.Text == "") ? true : false;
            txtType.Background = (txtType.Text == "") ? new SolidColorBrush(Colors.Yellow) : new SolidColorBrush(Colors.WhiteSmoke);
            txtPercent.Background = (txtPercent.Text == "") ? new SolidColorBrush(Colors.Yellow) : new SolidColorBrush(Colors.WhiteSmoke);
            try {
                grades.addGrade(new Grade(txtType.Text, Convert.ToDouble(txtPercent.Text)));
                lbType.Items.Add(txtType.Text + "\t" + txtPercent.Text);
                txtPercent.Background = new SolidColorBrush(Colors.WhiteSmoke);
                totalPercent += Convert.ToDouble(txtPercent.Text);
            } catch {
                txtPercent.Text = "";
                txtPercent.Background = new SolidColorBrush(Colors.Yellow);
            }
        }

        private void Remove_Click(object sender, RoutedEventArgs e) {
            try {
                string grade = lbType.SelectedItem as string;
                int idx = grade.IndexOf("\t");
                string gradeType = grade.Substring(0, idx);
                grades.removeGrade(gradeType);
                totalPercent -= Convert.ToDouble(grade.Substring(idx + 1));
                lbType.Items.Remove(lbType.SelectedItem);
            } catch {

            }
        }

        private void Submit_Click(object sender, RoutedEventArgs e) {
            if (totalPercent > 100) {
                txtWarning.Visibility = Visibility.Visible;
            } else {
                AddGrades(grades);
                drop();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e) {
            drop();
        }
    }
}
