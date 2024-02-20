using System.Globalization;
using System.Reflection;
using System.Windows.Data;

namespace WpfIdeas;

internal class EnumLocalizationConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return GetEnumResourceValue(value);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }

    private string GetEnumResourceValue(object obj)
    {
        var fi = obj.GetType().GetField(obj.ToString());
        var attr = fi.GetCustomAttribute(typeof(LocalizationAttribute), false) as LocalizationAttribute;

        if (attr is not null)
        {
            return attr.ResourceType.GetProperty(attr.ResourceName, BindingFlags.Static | BindingFlags.NonPublic).GetValue(null) as string;
        }

        return null;
    }
}