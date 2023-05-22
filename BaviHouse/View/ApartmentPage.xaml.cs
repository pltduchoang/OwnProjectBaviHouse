using BaviHouse.ViewModel;

namespace BaviHouse.View;

public partial class ApartmentPage : ContentPage
{
	public ApartmentPage(ApartmentViewModel vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}


    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}