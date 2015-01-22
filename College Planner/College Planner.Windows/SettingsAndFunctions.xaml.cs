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
    public sealed partial class SettingsAndFunctions : UserControl {
        private bool monthView = true;
        public event Action<Course> AddCourse;

        public SettingsAndFunctions() {
            this.InitializeComponent();

        }

        private void btnAddCourse_Click(object sender, RoutedEventArgs e) {
            AddCourse(new Course("Test"));
        }

        private void changeView(object sender, RoutedEventArgs e) {
            ToggleSwitch ts = sender as ToggleSwitch;
            if (monthView) {

                monthView = false;
            } else {

                monthView = true;
            }
        }
    }
}
