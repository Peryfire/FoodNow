using CommunityToolkit.Mvvm.ComponentModel;
using FoodNow.Model;
using System.ComponentModel;

namespace FoodNow.ViewModel
{
    
    public class DetailsViewModel : INotifyPropertyChanged
    {

        string _title;

        private Food _food;
        public DetailsViewModel()
        {
            Title = "Details";
            
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

        public Food Food
        {
            get { return _food; }
            set
            {
                _food = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Food"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
