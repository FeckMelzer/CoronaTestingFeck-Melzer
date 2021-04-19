using CoronaTest.Core;
using CoronaTest.Core.Sets;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace CoronaTest.Wpf.Converters
{
    public class TestResultConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is TestResults testResult)
            {
                switch(testResult)
                {
                    case TestResults.Unknown:
                        return "-";
                    case TestResults.Positive:
                        return "positiv";
                    case TestResults.Negative:
                        return "negativ";
                    default:
                        return testResult.ToString();
                }
            }
            else
            {
                throw new ArgumentException($"Argument is not from type {typeof(TestResults)}");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
