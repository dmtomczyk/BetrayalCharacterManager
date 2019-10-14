using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace BetrayalApp.Converters
{
    class IsTraitorConverter : IValueConverter
    {
        /// <summary>
        /// Converts a IsTraitorValue to a color.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool IsTraitor)
            {
                // Ensuring the value is a boolean, and that it is true. (AKA if the character is a traitor)
                if (IsTraitor)
                    return "Red";
                else if (!IsTraitor)
                    return "Green";
            }

            // Returns empty string if user has not been deemed traitor or explicitly listed as innocent
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
