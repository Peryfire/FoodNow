using FoodNow.ViewModel;

namespace FoodNow.View;

public partial class ShopPage : ContentPage
{
    [Obsolete]
    public ShopPage()
	{
		InitializeComponent();
		BindingContext = new ShopPageViewModel();
    }
}