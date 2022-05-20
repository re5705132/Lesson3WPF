using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace BindingExample.Converters
{
    class SumToColorConverter : IValueConverter

    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int season = int.Parse(parameter.ToString());
            int use = 0;
            if (int.TryParse(value.ToString(), out use))
            {
                if (use < 1000 || season==1)
                    return Brushes.Green;
            
            
            }
            return Brushes.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
