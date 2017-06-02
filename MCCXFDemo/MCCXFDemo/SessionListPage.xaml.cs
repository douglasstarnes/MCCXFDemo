using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SQLite;
using Xamarin.Forms;

namespace MCCXFDemo
{
    public partial class SessionListPage : ContentPage
    {
        public SessionListPage()
        {
            InitializeComponent();

            SQLiteConnection connection = DependencyService.Get<ISqliteDatabaseFile>(DependencyFetchTarget.GlobalInstance).GetConnection();
            connection.DropTable<ConferenceSession>(); // gotta love those conference demo hacks!
            connection.CreateTable<ConferenceSession>(CreateFlags.None);

            connection.Insert(new ConferenceSession { Title = "A Lap Around Xamarin", Favorite = false });
            connection.Insert(new ConferenceSession { Title = "Data Science with Python and Friends", Favorite = true });
            connection.Insert(new ConferenceSession { Title = "A Lap Around Xamarin Forms", Favorite = true });
            connection.Insert(new ConferenceSession { Title = "Python: What's in it For You", Favorite = false});
            ObservableCollection<ConferenceSession> sessions = new ObservableCollection<ConferenceSession>(); 

            var sessionTable = connection.Table<ConferenceSession>();

            foreach (var session in sessionTable) {
                sessions.Add(session);
            }

            sessionList.ItemsSource = sessions;

            sessionList.ItemTapped += (sender, e) => {
                ConferenceSession selectedSession = (ConferenceSession)e.Item;
                selectedSession.Favorite = !selectedSession.Favorite;
                connection.Update(selectedSession);
                ((ListView)sender).SelectedItem = null;
            };
        }
    }
}
