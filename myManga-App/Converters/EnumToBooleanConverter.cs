﻿using System;
using System.Windows;
using System.Windows.Data;

namespace myManga_App.Converters
{
    public class EnumToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        { return value.Equals(parameter); }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        { return value.Equals(true) ? parameter : DependencyProperty.UnsetValue; }
    }
}