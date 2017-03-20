﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Gravitrips.UI.Converters
{
    public class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (bool) value ^ (parameter as string ?? string.Empty).Equals("Reverse")
                ? Visibility.Visible
                : Visibility.Collapsed;
        }
        
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return (Visibility) value == Visibility.Visible ^ (parameter as string ?? string.Empty).Equals("Reverse");
        }
    }
}