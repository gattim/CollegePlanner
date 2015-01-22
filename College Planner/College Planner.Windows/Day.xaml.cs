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
    public sealed partial class Day : UserControl {

        private bool isToday = false;

        public Day() {
            InitializeComponent();
        }

        public void select() {
            rectBackground.Fill = new SolidColorBrush(Colors.Gold);
        }

        public void deselect() {
            rectBackground.Fill = new SolidColorBrush(Colors.WhiteSmoke);
        }

        public void activate(int dayNum) {
            txtDayOfMonth.Foreground = new SolidColorBrush(Colors.DarkBlue);
            rectBackground.Fill = new SolidColorBrush(Colors.WhiteSmoke);
            rectBackground.Stroke = (!isToday) ? new SolidColorBrush(Colors.DarkBlue) : rectBackground.Stroke;
            txtDayOfMonth.Text = dayNum.ToString();
        }

        public void deactivate() {
            txtDayOfMonth.Foreground = null;
            rectBackground.Fill = null;
            rectBackground.Stroke = (!isToday) ? null : rectBackground.Stroke;
        }

        public void makeToday() {
            isToday = true;
            rectBackground.Stroke = new SolidColorBrush(Colors.Red);
        }

        public void dismake() {
            isToday = false;
            rectBackground.Stroke = null;
        }
    }
}
