using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MCCXFDemo
{
    public partial class AttendeeListPage : ContentPage
    {
        public static readonly List<Attendee> allAttendees = new List<Attendee>
        {
            new Attendee { FirstName="Xamarin", LastName="Coder", ShirtSize="S", MealsIncluded=true },
            new Attendee { FirstName="iOS", LastName="Programmer", ShirtSize="M", MealsIncluded=false },
            new Attendee { FirstName="Android", LastName="Engineer", ShirtSize="L", MealsIncluded=true },
            new Attendee { FirstName="UWP", LastName="Developer", ShirtSize="XL", MealsIncluded=false },
        };

        public AttendeeListPage()
        {
            InitializeComponent();
            attendeeList.ItemsSource = allAttendees;
            attendeeList.ItemTapped += (sender, e) =>
            {
                var selectedItem = (Attendee)e.Item;
                Navigation.PushAsync(new AttendeeDetailsPage(selectedItem));
            };

            AddButton.Clicked += (sender, e) => {
                Navigation.PushAsync(new NewAttendeePage());        
            };
        }
    }
}
