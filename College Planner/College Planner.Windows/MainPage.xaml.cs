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
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace College_Planner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Rectangle selectedDay;

        public MainPage()
        {
            // THIS IS NOT THE ACTUAL VALUE OF CURDAY!
            // THE CURRENT DAY NEEDS TO BE THE SELECTED DAY TO START!
            Rectangle curDay = new Rectangle();

            this.InitializeComponent();
            populateMonth();
            selectDay(curDay);

        }

        private void rect_PointerPressed(object sender, PointerRoutedEventArgs e) {
            Rectangle newDay = sender as Rectangle;
            deselectDay();
            selectDay(newDay);
        }

        private void selectDay(Rectangle actDay) {
            selectedDay = actDay;
            selectedDay.Fill = new SolidColorBrush(Colors.Yellow);
        }

        private void deselectDay() {
            selectedDay.Fill = new SolidColorBrush(Colors.WhiteSmoke);
            selectedDay = null;
        }

        private void populateMonth() {
            int month = datePicker.Date.Month;
            int year = datePicker.Date.Year;
            int daysInMonth = calcNumDaysInMonth(year, month);
            int dayCode = calcFirstDay(year, month);
        }

        private int calcNumDaysInMonth(int year, int month) {
            bool isLeap = ((year % 4) == 0 && ((year % 100) != 0 || (year % 400) == 0));
            int days = (month == 2) ? (28) : 31 - (month - 1) % 7 % 2;
            return (isLeap && month == 2) ? 29 : days;
        }

        private int calcFirstDay(int year, int month) {

            return 0;
        }
    }
}
