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
    public sealed partial class ProfessorAdder : UserControl {
        public event Action<Professor> AddProfessor;
        public ProfessorAdder() {
            this.InitializeComponent();
        }

        public void pop() {
            popProfessor.IsOpen = true;
        }

        public void drop() {
            clear();
            popProfessor.IsOpen = false;
        }

        private void clear() {
            txtName.Text = "";
            txtBuilding.Text = "";
            txtRoom.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }

        private void Submit_Click(object sender, RoutedEventArgs e) {
            if (txtName.Text == "") {
                txtName.Background = new SolidColorBrush(Colors.Yellow);
            } else {
                Professor newProfessor = new Professor(txtName.Text, txtBuilding.Text, txtRoom.Text, txtPhone.Text, txtEmail.Text);
                Database.addProfessor(newProfessor);
                drop();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e) {
            drop();
        }
    }
}
