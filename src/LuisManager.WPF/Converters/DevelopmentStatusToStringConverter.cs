using System;
using System.Globalization;
using System.Windows.Data;
using LuisManager.Domain.Enums;
using LuisManager.WPF.Localization;

namespace LuisManager.WPF.Converters
{
    public class DevelopmentStatusToStringConverter : IValueConverter
    {
        public const string DevelopmentStatusResourcePrefix = "DevelopmentStatus_";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(value is DevelopmentStatus)
                    ? string.Empty
                    : Resources.ResourceManager.GetString($"{DevelopmentStatusResourcePrefix}{value}");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
