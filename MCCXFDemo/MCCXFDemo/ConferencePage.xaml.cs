using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MCCXFDemo
{
    public partial class ConferencePage : ContentPage
    {
        public ConferencePage()
        {
            InitializeComponent();

            ConferenceMap.MoveToRegion(
                MapSpan.FromCenterAndRadius(new Position(36.1447034, -86.8048491), Distance.FromMiles(1))
            );

            AttendeeListButton.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new AttendeeListPage());
            };

            SessionListButton.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new SessionListPage());
            };
        }
    }
}
