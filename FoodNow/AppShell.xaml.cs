using FoodNow.View;

namespace FoodNow;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(DetailsPage),typeof(DetailsPage));
        Routing.RegisterRoute(nameof(InfoPage), typeof(InfoPage));
    }
}
