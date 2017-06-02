using System;
using System.ComponentModel;
using SQLite;

namespace MCCXFDemo
{
    [Table("Sessions")]
    public class ConferenceSession: INotifyPropertyChanged
    {
        private string _title;
        private bool _favorite;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title
        {
            get{
                return _title;
            }
            set {
                _title = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Title"));
            }
        }
        public bool Favorite { 
            get {
                return _favorite;
            }

            set {
                _favorite = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Favorite"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e) {
            if (PropertyChanged != null) {
                PropertyChanged(this, e);
            }
        }
    }
}
