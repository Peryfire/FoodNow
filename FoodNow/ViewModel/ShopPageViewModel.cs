using FoodNow.Data;
using FoodNow.Model;
using FoodNow.View;
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
        public ObservableCollection<Food> _food;
        TodoItemDatabase _database;

        [Obsolete]
        public ShopPageViewModel()
        {
            Title = "Shop";
            _database = new TodoItemDatabase();
            DeleteTable();
            GetItems();
            ComUp = new Command(
                execute: () =>
                {
                    GetItems();
                });
            GoToDetailsCommand = new Command(
                execute: (object food) =>
                {
                    //Food food = new Food { Nome = "Ciao", Descrizione = "descrizione" };
                    System.Diagnostics.Debug.Print((food as Food).Nome);
                    GoToDetailsAsync(food as Food);
                });
        }

        public ICommand ComUp { get; private set; }
        public ICommand GoToDetailsCommand { get; private set; }

        [Obsolete]
        void GoToDetailsAsync(Food food)
        {
            Device.BeginInvokeOnMainThread(async () =>

            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true, new Dictionary<string, object>
            {
                {"Food", food }
            }));

        }


        public void DeleteTable()
        {
            _database.DeleteTableAsync();
            //System.Diagnostics.Debug.Print("OKO");
        }

        async void GetItems()
        {
            Food = await _database.GetItemsAsync();
            //System.Diagnostics.Debug.Print("OKO");
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
        public ObservableCollection<Food> Food
        {
            get { return _food; }
            set
            {
                _food = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Food"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //async void SaveItems()
        //{
        //    int i = await _database.SaveItemAsync(new Food() { Descrizione = "test desc", Immagine = "a.png", Nome = "prova", Prezzo = 29.99, Tipo = "frutto" });
        //}

        //public Food Item
        //{
        //    get { return item; }
        //    set { item = value; }
        //}

        //public List<Food> QueryAccountWithPositiveBalance()
        //{
        //    return _database.Query<Food>("SELECT * FROM Prodotti");
        //}
    }
}
