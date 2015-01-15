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


namespace College_Planner
{
    public sealed partial class MainPage : Page
    {
        private Rectangle selectedDay;
        private Rectangle[,] rectDays = new Rectangle[5,7];
        private TextBlock[,] txtDays = new TextBlock[5, 7];

        public MainPage()
        {
            instantiateDays();

            int curDayOfMonth = DateTime.Now.Day;
            Rectangle curDay = new Rectangle();

            this.InitializeComponent();
            populateMonth();
            selectDay(curDay);
            txt0x0.Text = calcFirstDay(2015, 1).ToString();
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
            int firstWeekDayOfMonth = calcFirstDay(year, month);

            for (int i = 0; i < daysInMonth; i++) {
                for (int j = 0; j < 5; j++) {
                    for (int k = (j == 0) ? firstWeekDayOfMonth : 0; k < 7; k++) {
                        
                    }
                }
            }
        }

        private int calcNumDaysInMonth(int year, int month) {
            bool isLeap = ((year % 4) == 0 && ((year % 100) != 0 || (year % 400) == 0));
            int days = (month == 2) ? (28) : 31 - (month - 1) % 7 % 2;
            return (isLeap && month == 2) ? 29 : days;
        }

        private int calcFirstDay(int year, int month) {
            return (int)new DateTime(year, month, 1).DayOfWeek;
        }

        private void instantiateDays() {
            rectDays[0, 0] = rect0x0; rectDays[0, 1] = rect0x1; rectDays[0, 2] = rect0x2; rectDays[0, 3] = rect0x3;
            rectDays[0, 4] = rect0x4; rectDays[0, 5] = rect0x5; rectDays[0, 6] = rect0x6;
            rectDays[1, 0] = rect1x0; rectDays[1, 1] = rect1x1; rectDays[1, 2] = rect1x2; rectDays[1, 3] = rect1x3;
            rectDays[1, 4] = rect1x4; rectDays[1, 5] = rect1x5; rectDays[1, 6] = rect1x6;
            rectDays[2, 0] = rect2x0; rectDays[2, 1] = rect2x1; rectDays[2, 2] = rect2x2; rectDays[2, 3] = rect2x3;
            rectDays[2, 4] = rect2x4; rectDays[2, 5] = rect2x5; rectDays[2, 6] = rect2x6;
            rectDays[3, 0] = rect3x0; rectDays[3, 1] = rect3x1; rectDays[3, 2] = rect3x2; rectDays[3, 3] = rect3x3;
            rectDays[3, 4] = rect3x4; rectDays[3, 5] = rect3x5; rectDays[3, 6] = rect3x6;
            rectDays[4, 0] = rect4x0; rectDays[4, 1] = rect4x1; rectDays[4, 2] = rect4x2; rectDays[4, 3] = rect4x3;
            rectDays[4, 4] = rect4x4; rectDays[4, 5] = rect4x5; rectDays[4, 6] = rect4x6;

            txtDays[0, 0] = txt0x0; txtDays[0, 1] = txt0x1; txtDays[0, 2] = txt0x2; txtDays[0, 3] = txt0x3;
            txtDays[0, 4] = txt0x4; txtDays[0, 5] = txt0x5; txtDays[0, 6] = txt0x6;
            txtDays[1, 0] = txt1x0; txtDays[1, 1] = txt1x1; txtDays[1, 2] = txt1x2; txtDays[1, 3] = txt1x3;
            txtDays[1, 4] = txt1x4; txtDays[1, 5] = txt1x5; txtDays[1, 6] = txt1x6;
            txtDays[2, 0] = txt2x0; txtDays[2, 1] = txt2x1; txtDays[2, 2] = txt2x2; txtDays[2, 3] = txt2x3;
            txtDays[2, 4] = txt2x4; txtDays[2, 5] = txt2x5; txtDays[2, 6] = txt2x6;
            txtDays[3, 0] = txt3x0; txtDays[3, 1] = txt3x1; txtDays[3, 2] = txt3x2; txtDays[3, 3] = txt3x3;
            txtDays[3, 4] = txt3x4; txtDays[3, 5] = txt3x5; txtDays[3, 6] = txt3x6;
            txtDays[4, 0] = txt4x0; txtDays[4, 1] = txt4x1; txtDays[4, 2] = txt4x2; txtDays[4, 3] = txt4x3;
            txtDays[4, 4] = txt4x4; txtDays[4, 5] = txt4x5; txtDays[4, 6] = txt4x6;
        }
    }
}
