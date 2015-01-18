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
    public sealed partial class Hour : UserControl {
        SolidColorBrush selectedBgColor = new SolidColorBrush(Colors.Gold);
        SolidColorBrush unselectedBgColor = new SolidColorBrush(Colors.WhiteSmoke);

        public Hour() {
            InitializeComponent();
        }

        public void select() {
            rectBg.Fill = selectedBgColor;
        }

        public void deselect() {
            rectBg.Fill = unselectedBgColor;
        }
    }
}
