using FoodNow.Data;
using FoodNow.Model;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;

namespace FoodNow.ViewModel
{
    //[QueryProperty("Item", "Item")]
    public class ShopPageViewModel : INotifyPropertyChanged
    {
        string _title;
        TodoItemDatabase _database;
        //Food item;
        public ObservableCollection<Food> _food;
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
            System.Diagnostics.Debug.Print("OKO");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        async void SaveItems()
        {
            int i = await _database.SaveItemAsync(new Food() { Descrizione = "test desc", Immagine = "a.png", Nome = "prova", Prezzo = 29.99, Tipo = "frutto" });
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
        public ObservableCollection<Food> Food
        {
            get { return _food; }
            set
            {
                _food = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Food"));
            }
        }

        //public List<Food> QueryAccountWithPositiveBalance()
        //{
        //    return _database.Query<Food>("SELECT * FROM Prodotti");
        //}
        public ICommand ComNuovo { get; private set; }
        public ICommand ComGet { get; private set; }
    }
}
