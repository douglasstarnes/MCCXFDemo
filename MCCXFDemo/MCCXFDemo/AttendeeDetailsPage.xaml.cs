using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MCCXFDemo
{
    public partial class AttendeeDetailsPage : ContentPage
    {
        public AttendeeDetailsPage(Attendee attendee) {
            InitializeComponent();
            BindingContext = attendee;
        }
    }
}
