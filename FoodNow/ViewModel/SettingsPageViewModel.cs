using static System.Net.Mime.MediaTypeNames;

namespace FoodNow.ViewModel
{
    public class SettingsPageViewModel
    {
        string _title;
        public SettingsPageViewModel()
        {
            Title = "Settings";
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
    }
}
