using BaviHouse.Validator;
using BaviHouse.ViewModel;

namespace BaviHouse.View;

public partial class UtilityPage : ContentPage
{
	public UtilityPage(UtilityVIewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    private void newElectricity_TextChanged(object sender, TextChangedEventArgs e)
    {
        bool resultCheck = ValidatorMethods.IntValidator(this.newElectricity.Text);
        if (resultCheck)
        {
            UtilityVIewModel.newReading = int.Parse(this.newElectricity.Text);
        }
        else
        {
            DisplayAlert("ErrorElectricity", "Invalid input, try again", "Cancel");
            this.newElectricity.Text = null;
        }
		
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }

    



}