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
    public sealed partial class Calendar : UserControl {
        public event Action<ToggleSwitch> ViewChanged;
        public Calendar() {
            this.InitializeComponent();
        }
        private void changeView(object sender, RoutedEventArgs e) {
            ToggleSwitch ts = sender as ToggleSwitch;
            if (ts.IsOn) {
                month.IsEnabled = false;
                month.Visibility = Visibility.Collapsed;
                week.IsEnabled = true;
                week.Visibility = Visibility.Visible;
            }
            else {
                week.IsEnabled = false;
                week.Visibility = Visibility.Collapsed;
                month.IsEnabled = true;
                month.Visibility = Visibility.Visible;
                month.populate(datePicker.Date.Year, datePicker.Date.Month);
            }
            ViewChanged(ts);
        }

        private void dateChanged(object sender, DatePickerValueChangedEventArgs e) {
            DatePicker day = sender as DatePicker;
            month.clear();
            month.populate(day.Date.Year, day.Date.Month);
        }
    }
}
