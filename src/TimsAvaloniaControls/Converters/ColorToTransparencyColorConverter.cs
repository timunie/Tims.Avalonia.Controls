using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.ComponentModel;
using System.Globalization;

namespace TimsAvaloniaControls.Converters
{
    public class ColorToTransparencyColorConverter : IValueConverter
    {
        private static ColorToTransparencyColorConverter _Instance;
        public static ColorToTransparencyColorConverter Instance => _Instance ??= new();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                var inputColor = (Color)value;
                var transparencyLevel = (double)(new DoubleConverter().ConvertFromInvariantString(parameter?.ToString()));

                if (transparencyLevel < 0) transparencyLevel = 0;
                if (transparencyLevel > 1) transparencyLevel = 1;

                transparencyLevel = 1 - transparencyLevel;

                return new Color((byte)(transparencyLevel * inputColor.A), inputColor.R, inputColor.G, inputColor.B);
            }
            catch
            {
                return BindingOperations.DoNothing;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
