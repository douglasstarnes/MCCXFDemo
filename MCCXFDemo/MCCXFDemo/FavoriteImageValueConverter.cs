using System;
using System.Globalization;
using Xamarin.Forms;

namespace MCCXFDemo
{
    public class FavoriteImageValueConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool favorite = (bool)value;

            if (favorite == true) {
                return "favorite_true.png";
            } else {
                return "favorite_false.png";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
