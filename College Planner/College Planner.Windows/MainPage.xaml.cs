﻿using System;
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
using Windows.UI.Xaml.Shapes;


namespace College_Planner
{
    

    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            InitializeComponent();
            settingsAndFunctions.getCourseAdder().AddCourse += AddCourseToDatabase;
        }

        private void AddCourseToDatabase(Course course) {
            Database.addCourse(course);
            courseList.addCourse(new CourseDisplay(course));
            taskList.addCourse(course);
        }
    }
}