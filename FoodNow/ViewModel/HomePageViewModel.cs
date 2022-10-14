using FoodNow.Model;

namespace FoodNow.ViewModel
{

    public class HomePageViewModel
    {
        private List<Sweet> sweetList = new List<Sweet>();

        string _title;

        public HomePageViewModel()
        {
            Title = "Home";
            sweetList.Add(new Sweet("Torta", "Torta molto buona", 5.5));
            sweetList.Add(new Sweet("Caramella", "Caramella molto buona", 0.5));
            sweetList.Add(new Sweet("Gelato", "Gelato molto buono", 2.5));
        }

        public List<Sweet> SweetsList
        {
            get { return sweetList; }
            set { sweetList = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
    }
}