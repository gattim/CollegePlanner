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
    public sealed partial class DaySchedule : UserControl {
        public DaySchedule() {
            InitializeComponent();
            instantiateTimeText();
            setUpTimers();
        }

        private void timer_Tick(object sender, object e) {
            nowBar.Margin = new Thickness(0, (DateTime.Now.Hour * 60) + (DateTime.Now.Minute), 0, 0);
        }

        private void instantiateTimeText() {
            hr0.setTime("0000");
            hr1.setTime("0100");
            hr2.setTime("0200");
            hr3.setTime("0300");
            hr4.setTime("0400");
            hr5.setTime("0500");
            hr6.setTime("0600");
            hr7.setTime("0700");
            hr8.setTime("0800");
            hr9.setTime("0900");
            hr10.setTime("1000");
            hr11.setTime("1100");
            hr12.setTime("1200");
            hr13.setTime("1300");
            hr14.setTime("1400");
            hr15.setTime("1500");
            hr16.setTime("1600");
            hr17.setTime("1700");
            hr18.setTime("1800");
            hr19.setTime("1900");
            hr20.setTime("2000");
            hr21.setTime("2100");
            hr22.setTime("2200");
            hr23.setTime("2300");
        }

        private void setUpTimers() {
            nowBar.Margin = new Thickness(0, (DateTime.Now.Hour * 60) + (DateTime.Now.Minute), 0, 0);

            DispatcherTimer nowBarTimer = new DispatcherTimer();
            nowBarTimer.Interval = TimeSpan.FromMinutes(1);
            nowBarTimer.Tick += timer_Tick;
            nowBarTimer.Start();

            DispatcherTimer nowBarFocusTimer = new DispatcherTimer();
            nowBarFocusTimer.Interval = TimeSpan.FromMilliseconds(1);
            nowBarFocusTimer.Tick += nowBarFocusTimer_Tick;
            nowBarFocusTimer.Start();
        }

        private void nowBarFocusTimer_Tick(object sender, object e) {
            DispatcherTimer nowBarFocusTimer = sender as DispatcherTimer;
            nowBarFocusTimer.Interval = TimeSpan.FromMinutes(5);
            scrollViewer.ChangeView(null, (DateTime.Now.Hour * 60) + (DateTime.Now.Minute), null, false);
        }
    }
}
