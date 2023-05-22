using BaviHouse.View;

namespace BaviHouse;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();


		//nameof(ApartmentDetailPage) == "ApartmentDetailPage"
		Routing.RegisterRoute(nameof(ApartmentDetailsPage), typeof(ApartmentDetailsPage));
        Routing.RegisterRoute(nameof(UtilityPage), typeof(UtilityPage));
		Routing.RegisterRoute(nameof(DetailsUpdatePage), typeof(DetailsUpdatePage));
    }
}
