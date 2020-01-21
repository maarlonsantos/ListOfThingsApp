using System;
using System.Globalization;
using Xamarin.Forms;

namespace Projeto01.Converter
{
    public class FinalizadoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valor = (bool) value;

            if (valor == false)
            {
                return "Aberta";
            }
            else
            {
                return "Finalizada";
            }

            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
