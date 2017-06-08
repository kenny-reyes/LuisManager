using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace LuisManager.WPF.Converters
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        public bool Inverse { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var visibility = value != null && value is bool && (bool)value ? Visibility.Visible : Visibility.Collapsed;
            return Inverse ? Invert(visibility) : visibility;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private Visibility Invert(Visibility visibility)
        {
            return visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }
    }
}
