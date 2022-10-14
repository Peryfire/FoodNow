namespace FoodNow.ViewModel
{
    public class ShopPageViewModel
    {
        string _title;
        string _text;
        public ShopPageViewModel()
        {
            Title = "Shop";
            Text = "Shop in allestimento";
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
    }
}
