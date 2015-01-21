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
    public sealed partial class TaskList : UserControl {
        public TaskList() {
            this.InitializeComponent();
        }

        private void addTask(object sender, RoutedEventArgs e) {
            popupAddTask.IsOpen = true;

        }

        private void addTaskPressed(object sender, PointerRoutedEventArgs e) {
            
        }

        private void addTaskReleased(object sender, PointerRoutedEventArgs e) {

        }

        private void btnSubmitTask_Click(object sender, RoutedEventArgs e) {
            taskList.Children.Add(new Task(txtName.Text));
            txtName.Text = "";
            popupAddTask.IsOpen = false;
        }

        private void btnCancelAddTask_Click(object sender, RoutedEventArgs e) {
            txtName.Text = "";
            popupAddTask.IsOpen = false;
        }
    }

}
