using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using College_Planner.Models;
using College_Planner.ViewModels;


namespace College_Planner
{

    public sealed partial class MainPage : Page
    {
        CoursesViewModel coursesViewModel = null;
        ObservableCollection<CourseViewModel> courses = null;
        

        public MainPage()
        {
            InitializeComponent();
            calendar.ViewChanged += viewChanged;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) {
            coursesViewModel = new CoursesViewModel();
            courses = coursesViewModel.GetCourses();
        }

        private void viewChanged(ToggleSwitch ts) {
            if (ts.IsOn) {
                daySchedule.IsEnabled = false;
                daySchedule.Visibility = Visibility.Collapsed;
            } else {
                daySchedule.IsEnabled = true;
                daySchedule.Visibility = Visibility.Visible;
            }
        }
    }
}