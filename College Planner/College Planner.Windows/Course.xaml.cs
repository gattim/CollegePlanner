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
    public sealed partial class Course : UserControl {

        public string courseID { get; set; }
        public string courseName { get; set; }
        public int credits { get; set; }
        public Professor professor { get; set; }
        public string building { get; set; }
        public string roomNumber { get; set; }
        public Grades grades { get; set; }

        public string[,] week = new string[5,2];


        public Course(string id, string name, int credits, string building, string roomNum) {
            this.InitializeComponent();
            courseID = id;
            courseName = name;
            this.credits = credits;
            txtBlkCourseName.Text = name;
            this.building = building;
            roomNumber = roomNum;
        }
    }

}
