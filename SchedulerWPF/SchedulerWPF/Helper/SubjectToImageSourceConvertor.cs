using System;
using System.Globalization;
using System.Windows.Data;

namespace SchedulerWPF
{
    public class SubjectToImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString().Equals("Meeting"))
                return "../Images/Conference_schedule.png";
            else
                return "../Images/cake_schedule.png";
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}





