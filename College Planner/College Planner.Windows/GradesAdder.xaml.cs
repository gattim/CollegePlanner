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
    public sealed partial class GradesAdder : UserControl {
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
            txtType.Text = "";
            txtPercent.Text = "";
            lbType.Items.Clear();
        }

        private void Add_Click(object sender, RoutedEventArgs e) {
            lbType.Items.Add(txtType.Text + "\t" + txtPercent);
        }

        private void Remove_Click(object sender, RoutedEventArgs e) {
            lbType.Items.Remove(lbType.SelectedItem);
        }

        private void Submit_Click(object sender, RoutedEventArgs e) {

            drop();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e) {
            drop();
        }
    }
}
