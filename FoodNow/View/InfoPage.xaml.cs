using FoodNow.ViewModel;

namespace FoodNow.View;

public partial class InfoPage : ContentPage
{
	public InfoPage()
	{
		InitializeComponent();
		BindingContext = new InfoPageViewModel();
	}
}