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
    public sealed partial class Month : UserControl {

        private Day selectedDay;
        private Day[] days = new Day[37];

        public Month() {
            InitializeComponent();

            instantiateDaysArray();
            clear();
            populate(datePicker.Date.Year, datePicker.Date.Month);     
        }

        private void Day_PointerPressed(object sender, PointerRoutedEventArgs e) {
            Day newSelectedDay = sender as Day;
            if (selectedDay != null) {
                selectedDay.deselect();
            } 
            newSelectedDay.select();
            selectedDay = newSelectedDay;
        }

        private void dateChanged(object sender, DatePickerValueChangedEventArgs e) {
            DatePicker day = sender as DatePicker;
            clear();
            populate(day.Date.Year, day.Date.Month);
        }

        private void instantiateDaysArray() {
            days[0] = day1;
            days[1] = day2;
            days[2] = day3;
            days[3] = day4;
            days[4] = day5;
            days[5] = day6;
            days[6] = day7;
            days[7] = day8;
            days[8] = day9;
            days[9] = day10;
            days[10] = day11;
            days[11] = day12;
            days[12] = day13;
            days[13] = day14;
            days[14] = day15;
            days[15] = day16;
            days[16] = day17;
            days[17] = day18;
            days[18] = day19;
            days[19] = day20;
            days[20] = day21;
            days[21] = day22;
            days[22] = day23;
            days[23] = day24;
            days[24] = day25;
            days[25] = day26;
            days[26] = day27;
            days[27] = day28;
            days[28] = day29;
            days[29] = day30;
            days[30] = day31;
            days[31] = day32;
            days[32] = day33;
            days[33] = day34;
            days[34] = day35;
            days[35] = day36;
            days[36] = day37;
        }

        private void clear() {
            foreach (Day day in days) {
                if (selectedDay != null) {
                    selectedDay.deselect();
                    selectedDay = null;
                }
                day.deactivate();
                day.PointerPressed -= Day_PointerPressed;
            }
        }

        private void populate(int year, int month) {
            int daysInMonth = calcNumDaysInMonth(year, month);
            int firstWeekDayOfMonth = calcFirstDay(year, month);

            for (int i = 0; i < days.Length; i++) {
                if (i >= firstWeekDayOfMonth && i < daysInMonth + firstWeekDayOfMonth) {
                    days[i].activate(i-firstWeekDayOfMonth+1);
                    days[i].PointerPressed += Day_PointerPressed;
                }
            }

            if (year == DateTime.Now.Year && month == DateTime.Now.Month) {
                selectedDay = days[DateTime.Today.Day - 1];
                selectedDay.select();
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
    }
}
