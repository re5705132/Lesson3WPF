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
    class ToColorMultiBinding : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {

            
            int season = int.Parse(parameter.ToString());
            int use = 0;
            int people =int.Parse( values[1].ToString());

            if (int.TryParse(values[0].ToString(), out use))
            {
                if (use < 1000 || season == 1 || people>10)
                    return Brushes.Green;


            }
            return Brushes.Red;
            }
            catch (Exception)
            {

                return true;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
