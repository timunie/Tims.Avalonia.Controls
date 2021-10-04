using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Globalization;

namespace TimsAvaloniaControls.Converters
{

    public class ObjectEqualsToBooleanConverter : IValueConverter
    {
        private static ObjectEqualsToBooleanConverter _Instance;
        public static ObjectEqualsToBooleanConverter Instance => _Instance ??= new();


        private static ObjectEqualsToBooleanConverter _InstanceInverted;
        public static ObjectEqualsToBooleanConverter InstanceInverted => _InstanceInverted ??= new() { Inverted = true };

        // Set this parameter in order to return the inverse value
        public bool Inverted { get; set; }

        /// <summary>
        /// Cheks two objects for equality. Can be also used to bind enums 
        /// </summary>
        /// <param name="value">the value to test</param>
        /// <param name="targetType">unused</param>
        /// <param name="parameter">the value to compare to</param>
        /// <param name="culture">unused</param>
        /// <returns><see langword="true"/> if both objects are equal, <see langword="false"/> if not.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool result;
            if (value is null && parameter is null) // both are null
            {
                result = true;
            }
            else if (value is null || parameter is null) // either of them is null
            {
                result = false;
            }
            else // both have a value
            {
                result = value.Equals(parameter);
            }

            return Inverted ? !result : result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
