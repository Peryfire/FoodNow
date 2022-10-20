using FoodNow.Model;

namespace FoodNow.ViewModel
{

    public class HomePageViewModel
    {
        private List<Food> foodList = new List<Food>();

        string _title;
        string _text;
        string _immagine;

        public HomePageViewModel()
        {
            Title = "Home";
            Text = "Benvenuti su FoodNow";
            Immagine = "negozio.jpg";
            //foodList.Add(new Food("Mela", "Melinda", "frutta", 2.50));
            //foodList.Add(new Food("Anguria", "proveniente dalla Sicilia", "frutta",  12.5));
            //foodList.Add(new Food("Lasagna",  "buonissime", "cotto", 15.0));
        }

        public List<Food> FoodsList
        {
            get { return foodList; }
            set { foodList = value; }
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
        public string Immagine
        {
            get { return _immagine; }
            set { _immagine = value; }
        }
    }
}