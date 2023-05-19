using BaviHouse.ViewModel;

namespace BaviHouse.View;

public partial class UtilityPage : ContentPage
{
	public UtilityPage(UtilityVIewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}