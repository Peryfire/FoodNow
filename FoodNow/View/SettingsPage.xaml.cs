using FoodNow.ViewModel;

namespace FoodNow.View;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
		BindingContext = new SettingsPageViewModel();
	}
}