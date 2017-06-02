using System;
using System.Globalization;
using Xamarin.Forms;

namespace MCCXFDemo
{
    public class MealImageValueConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool mealsIncluded = (bool)value;

            if (mealsIncluded == true) {
                return "meal_true.png";
            } else {
                return "meal_false.png";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
