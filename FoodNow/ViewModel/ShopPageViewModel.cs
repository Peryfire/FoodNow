using FoodNow.Data;
using FoodNow.Model;
using System.Windows.Input;

namespace FoodNow.ViewModel
{
    //[QueryProperty("Item", "Item")]
    public class ShopPageViewModel
    {
        string _title;
        TodoItemDatabase _database;
        //Food item;
        public List<Food> _food;
        public ShopPageViewModel()
        {
            Title = "Shop";
            _database = new TodoItemDatabase();
            GetItems();
            //SaveItems();
            ComNuovo = new Command(
                execute: () =>
                {
                    this.SaveItems();
                });
            ComGet = new Command(
                execute: () =>
                {
                    this.GetItems();
                });
        }
        async void GetItems()
        {
            Food = await _database.GetItemsAsync();
        }
        public Food ciao = new Food();
        async void SaveItems()
        {
            int i = await _database.SaveItemAsync(ciao);
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        //public Food Item
        //{
        //    get { return item; }
        //    set { item = value; }
        //}
        public List<Food> Food
        {
            get { return _food; }
            set { _food = value; }
        }

        //public List<Food> QueryAccountWithPositiveBalance()
        //{
        //    return _database.Query<Food>("SELECT * FROM Prodotti");
        //}
        public ICommand ComNuovo {private get; set; }
        public ICommand ComGet { private get; set; }
    }
}
