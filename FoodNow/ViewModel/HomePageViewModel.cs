using FoodNow.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FoodNow.ViewModel
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        string _title;
        string _text;
        string _description;
        string _image;

        public HomePageViewModel()
        {
            Title = "Home";
            Text = "Benvenuti su FoodNow";
            Description = "Ciao!\nFoodNow è un'applicazione per un negozio di alimentari ed è stata realizzata utilizzando il framework MAUI.\nGli autori dell'applicazione sono Bindellari Andrea e Mosciatti Tomas";
            Image = "negozio.jpg";
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

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Text"));
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
            }
        }
        public string Image
        {
            get { return _image; }
            set
            {
                _image = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Image"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}