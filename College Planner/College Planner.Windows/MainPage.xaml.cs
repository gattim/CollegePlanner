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

        public MainPage()
        {
            int curDayOfMonth = DateTime.Now.Day;
            Rectangle curDay = new Rectangle();

            this.InitializeComponent();
            clearMonth();
            populateMonth(datePicker.Date.Year, datePicker.Date.Month);
            selectDay(curDay);
        }

        private void rect_PointerPressed(object sender, PointerRoutedEventArgs e) {
            Rectangle newDay = sender as Rectangle;
            deselectDay();
            selectDay(newDay);
        }

        private void datePicker_DateChanged(object sender, DatePickerValueChangedEventArgs e) {
            DatePicker day = sender as DatePicker;
            clearMonth();
            populateMonth(day.Date.Year, day.Date.Month);
        }

        private void selectDay(Rectangle actDay) {
            selectedDay = actDay;
            selectedDay.Fill = new SolidColorBrush(Colors.Yellow);
        }

        private void deselectDay() {
            selectedDay.Fill = new SolidColorBrush(Colors.WhiteSmoke);
            selectedDay = null;
        }

        private void populateMonth(int year, int month) {
            int daysInMonth = calcNumDaysInMonth(year, month);
            int firstWeekDayOfMonth = calcFirstDay(year, month);

            for (int i = 1; i <= daysInMonth; i++) {
                int rectDay = i + firstWeekDayOfMonth;
                switch (rectDay) {
                    case 1:
                        txt0x0.Text = i.ToString();
                        rect0x0.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 2:
                        txt0x1.Text = i.ToString();
                        rect0x1.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 3:
                        txt0x2.Text = i.ToString();
                        rect0x2.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 4:
                        txt0x3.Text = i.ToString();
                        rect0x3.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 5:
                        txt0x4.Text = i.ToString();
                        rect0x4.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 6:
                        txt0x5.Text = i.ToString();
                        rect0x5.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 7:
                        txt0x6.Text = i.ToString();
                        rect0x6.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 8:
                        txt1x0.Text = i.ToString();
                        rect1x0.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 9:
                        txt1x1.Text = i.ToString();
                        rect1x1.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 10:
                        txt1x2.Text = i.ToString();
                        rect1x2.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 11:
                        txt1x3.Text = i.ToString();
                        rect1x3.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 12:
                        txt1x4.Text = i.ToString();
                        rect1x4.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 13:
                        txt1x5.Text = i.ToString();
                        rect1x5.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 14:
                        txt1x6.Text = i.ToString();
                        rect1x6.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 15:
                        txt2x0.Text = i.ToString();
                        rect2x0.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 16:
                        txt2x1.Text = i.ToString();
                        rect2x1.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 17:
                        txt2x2.Text = i.ToString();
                        rect2x2.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 18:
                        txt2x3.Text = i.ToString();
                        rect2x3.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 19:
                        txt2x4.Text = i.ToString();
                        rect2x4.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 20:
                        txt2x5.Text = i.ToString();
                        rect2x5.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 21:
                        txt2x6.Text = i.ToString();
                        rect2x6.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 22:
                        txt3x0.Text = i.ToString();
                        rect3x0.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 23:
                        txt3x1.Text = i.ToString();
                        rect3x1.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 24:
                        txt3x2.Text = i.ToString();
                        rect3x2.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 25:
                        txt3x3.Text = i.ToString();
                        rect3x3.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 26:
                        txt3x4.Text = i.ToString();
                        rect3x4.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 27:
                        txt3x5.Text = i.ToString();
                        rect3x5.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 28:
                        txt3x6.Text = i.ToString();
                        rect3x6.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 29:
                        txt4x0.Text = i.ToString();
                        rect4x0.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 30:
                        txt4x1.Text = i.ToString();
                        rect4x1.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 31:
                        txt4x2.Text = i.ToString();
                        rect4x2.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 32:
                        txt4x3.Text = i.ToString();
                        rect4x3.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 33:
                        txt4x4.Text = i.ToString();
                        rect4x4.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 34:
                        txt4x5.Text = i.ToString();
                        rect4x5.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 35:
                        txt4x6.Text = i.ToString();
                        rect4x6.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 36:
                        txt5x0.Text = i.ToString();
                        rect5x0.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 37:
                        txt5x1.Text = i.ToString();
                        rect5x1.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
                    case 38:
                        txt5x2.Text = i.ToString();
                        rect5x2.Fill = new SolidColorBrush(Colors.WhiteSmoke);
                        break;
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

        private void clearMonth() {
            changeDayColors(Colors.DarkBlue);
        }

        private void changeDayColors(Color c) {
            rect0x0.Fill = new SolidColorBrush(c);
            rect0x1.Fill = new SolidColorBrush(c);
            rect0x2.Fill = new SolidColorBrush(c);
            rect0x3.Fill = new SolidColorBrush(c);
            rect0x4.Fill = new SolidColorBrush(c);
            rect0x5.Fill = new SolidColorBrush(c);
            rect0x6.Fill = new SolidColorBrush(c);
            rect0x0.Fill = new SolidColorBrush(c);
            rect0x1.Fill = new SolidColorBrush(c);
            rect0x2.Fill = new SolidColorBrush(c);
            rect0x3.Fill = new SolidColorBrush(c);
            rect0x4.Fill = new SolidColorBrush(c);
            rect0x5.Fill = new SolidColorBrush(c);
            rect0x6.Fill = new SolidColorBrush(c);
            rect1x0.Fill = new SolidColorBrush(c);
            rect1x1.Fill = new SolidColorBrush(c);
            rect1x2.Fill = new SolidColorBrush(c);
            rect1x3.Fill = new SolidColorBrush(c);
            rect1x4.Fill = new SolidColorBrush(c);
            rect1x5.Fill = new SolidColorBrush(c);
            rect1x6.Fill = new SolidColorBrush(c);
            rect2x0.Fill = new SolidColorBrush(c);
            rect2x1.Fill = new SolidColorBrush(c);
            rect2x2.Fill = new SolidColorBrush(c);
            rect2x3.Fill = new SolidColorBrush(c);
            rect2x4.Fill = new SolidColorBrush(c);
            rect2x5.Fill = new SolidColorBrush(c);
            rect2x6.Fill = new SolidColorBrush(c);
            rect4x0.Fill = new SolidColorBrush(c);
            rect4x1.Fill = new SolidColorBrush(c);
            rect4x2.Fill = new SolidColorBrush(c);
            rect4x3.Fill = new SolidColorBrush(c);
            rect4x4.Fill = new SolidColorBrush(c);
            rect4x5.Fill = new SolidColorBrush(c);
            rect4x6.Fill = new SolidColorBrush(c);
            rect5x0.Fill = new SolidColorBrush(c);
            rect5x1.Fill = new SolidColorBrush(c);
            rect5x2.Fill = new SolidColorBrush(c);
            rect5x3.Fill = new SolidColorBrush(c);
            rect5x4.Fill = new SolidColorBrush(c);
            rect5x5.Fill = new SolidColorBrush(c);
            rect5x6.Fill = new SolidColorBrush(c);
        }
    }
}