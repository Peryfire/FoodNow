using System.ComponentModel;

namespace FoodNow.ViewModel
{
    public class InfoPageViewModel:INotifyPropertyChanged
    {
        string _title;
        string _text;
        string _image;
        public InfoPageViewModel()
        {
            Title = "Info";
            Text = "Grazie per aver usato l'app!";
            Image = "appicon.png";
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
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
