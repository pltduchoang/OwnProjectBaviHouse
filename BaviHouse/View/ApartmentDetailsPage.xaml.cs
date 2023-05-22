using BaviHouse.ViewModel;

namespace BaviHouse.View;

public partial class ApartmentDetailsPage : ContentPage
{
	public ApartmentDetailsPage(ApartmentDetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}