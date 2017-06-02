using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MCCXFDemo
{
    public partial class NewAttendeePage : ContentPage
    {
        private static List<string> shirtSizes = new List<string>()
        {
            "S", "M", "L", "XL"
        };

        public NewAttendeePage()
        {
            InitializeComponent();
            RegisterButton.Clicked += (sender, e) => {
                var firstName = FirstName.Text;
                var lastName = LastName.Text;
                var mealsIncluded = MealsIncluded.IsToggled;
                var message = String.Format("{0} {1} has registered with{2} meals", firstName, lastName, mealsIncluded ? "" : "out");


                DisplayAlert("New Registration", message, "OK");
            };
            ShirtSize.ItemsSource = NewAttendeePage.shirtSizes;
        }
    }
}
