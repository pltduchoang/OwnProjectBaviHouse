using BaviHouse.View;

namespace BaviHouse;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();


		//nameof(ApartmentDetailPage) == "ApartmentDetailPage"
		Routing.RegisterRoute(nameof(ApartmentDetailPage), typeof(ApartmentDetailPage));
        Routing.RegisterRoute(nameof(UtilityPage), typeof(UtilityPage));
    }
}
