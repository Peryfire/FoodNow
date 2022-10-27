using FoodNow.Model;
using FoodNow.View;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace FoodNow.ViewModel
{
    public class SettingsPageViewModel : INotifyPropertyChanged
    {
        string _title;
        ObservableCollection<Settings> _setting;

        public SettingsPageViewModel()
        {
            Title = "Settings";
            Settings set = new Settings() { Nome= "Info", Immagine="info_icon.png" };
            ObservableCollection<Settings> setti = new ObservableCollection<Settings>();
            setti.Add(set);
            Setting = setti;
            GoToInfoCommand = new Command(
                execute: () =>
                {
                    GoToInfoAsync();
                });
        }

        public ICommand GoToInfoCommand { get; private set; }

        void GoToInfoAsync()
        {
            Shell.Current.GoToAsync($"{nameof(InfoPage)}");
        }

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Title"));
            }
        }

        public ObservableCollection<Settings> Setting
        {
            get { return _setting; }
            set
            {
                _setting = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Settings"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
