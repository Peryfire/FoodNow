using FoodNow.ViewModel;

namespace FoodNow.View;

public partial class ShopPage : ContentPage
{
	public ShopPage()
	{
		InitializeComponent();
		BindingContext = new ShopPageViewModel();
	}
}