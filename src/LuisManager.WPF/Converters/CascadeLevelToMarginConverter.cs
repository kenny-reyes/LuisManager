using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace LuisManager.WPF.Converters
{
    class CascadeLevelToMarginConverter : IValueConverter
    {
        public const int CascadeSize = 60;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var level = (value is int)? (int)value : 0;
            return new Thickness(0, level * CascadeSize, 0, 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }    
    }
}
