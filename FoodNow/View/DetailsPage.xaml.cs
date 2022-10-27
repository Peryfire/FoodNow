using FoodNow.Model;
using FoodNow.ViewModel;

namespace FoodNow.View;

[QueryProperty(nameof(Food), "Food")]
public partial class DetailsPage : ContentPage
{
    public DetailsPage()
    {
        InitializeComponent();
        BindingContext = new DetailsViewModel();
    }

    private Food _food;
    
    public Food Food
    {
        get { return _food; }
        set
        {
            this._food = value;
        }
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        (BindingContext as DetailsViewModel).Food = this.Food;
    }
}