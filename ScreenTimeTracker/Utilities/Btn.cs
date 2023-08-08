using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ScreenTimeTracker.Utilities
{
    //This is a custom control implementation in WPF that extends the RadioButton control.
    //The custom control is named Btn, and it is used to define a custom appearance and behavior for a radio button in a WPF application.
    public class Btn : RadioButton
    {
        static Btn()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Btn), new FrameworkPropertyMetadata(typeof(Btn)));
        }
    }
}
