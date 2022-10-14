namespace FoodNow.ViewModel
{
    public class InfoPageViewModel
    {
        string _title;
        public InfoPageViewModel()
        {
            Title = "Info";
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
    }
}
