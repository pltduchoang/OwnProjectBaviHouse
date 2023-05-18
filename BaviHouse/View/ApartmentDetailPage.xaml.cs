using BaviHouse.Model;
using BaviHouse.ViewModel;

namespace BaviHouse.View;


public partial class ApartmentDetailPage : ContentPage
{


	public ApartmentDetailPage(ApartmentDetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    //protected override void OnNavigatedTo(NavigatedToEventArgs args)
    //{
    //    base.OnNavigatedTo(args);
    //}
}