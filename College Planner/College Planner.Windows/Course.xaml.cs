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

        private string courseID;
        private string courseName;
        private Professor professor;
        private string building;
        private string roomNumber;
        private Grades grades;
        private TimeSpan classTime;
        

        public Course(string id, string name, Professor professor) {
            this.InitializeComponent();

           // courseName = name;
            txtBlkCourseName.Text = name;
        }
    }

}
