using BaviHouse.ViewModel;
using BaviHouse.Validator;
using BaviHouse.DataBase;

namespace BaviHouse.View;


public partial class DetailsUpdatePage : ContentPage
{
    int unitNum;
    string newTentantName;
    string newOccupation;
    DateOnly newMoveInDate;
    string newPhone;
    double newDeposite;
    double newRent;
    double newWaterLaundry;
    int oldElectricReading;
    int newElectricReading;


    public DetailsUpdatePage(DetailsUpdateViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
    }

    public void PreUpdate()
    {
        unitNum = int.Parse(this.Lable.Text);
        newTentantName = this.NewTenantName.Text;
        newOccupation = this.NewOccupation.Text;
        newMoveInDate = DateOnly.Parse(this.NewMoveInDate.Text);
        newPhone = this.NewPhone.Text;
        newDeposite = double.Parse(this.NewDeposite.Text);
        newRent = double.Parse(this.NewRent.Text);
        newWaterLaundry = double.Parse(this.NewWaterLaundry.Text);
        newElectricReading = int.Parse(this.NewElectricityReading.Text);
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {

        PreUpdate();
    }

    public string invalidMessage = "Invalid input, try again";

   
    

    private void NewTenantName_TextChanged(object sender, TextChangedEventArgs e)
    { 
        bool checkResult = ValidatorMethods.StringValidator(this.NewTenantName.Text);
        if (checkResult)
        {
            newTentantName = this.NewTenantName.Text;
        }
        else
        {
            DisplayAlert("ErrorName",invalidMessage,"Cancel");
            this.NewTenantName.Text = null;
        }
    }

    private void NewOccupation_TextChanged(object sender, TextChangedEventArgs e)
    {
        bool checkResult = ValidatorMethods.StringValidator(this.NewOccupation.Text);
        if (checkResult)
        {
            newOccupation = this.NewOccupation.Text;
        }
        else
        {
            DisplayAlert("ErrorOccupation", invalidMessage, "Cancel");
            this.NewOccupation.Text = null;
        }
    }

    private void NewMoveInDate_TextChanged(object sender, TextChangedEventArgs e)
    {
        bool checkResult = ValidatorMethods.DateValidator(this.NewMoveInDate.Text);
        if (checkResult)
            newMoveInDate = DateOnly.Parse(this.NewMoveInDate.Text);
        else
        {
            DisplayAlert("ErrorMoveDate", invalidMessage, "Cancel");
            this.NewMoveInDate.Text = null;
        }
    }
    private void NewPhone_TextChanged(object sender, TextChangedEventArgs e)
    {
        bool checkResult = ValidatorMethods.DoubleValidator(this.NewPhone.Text);
        if (checkResult)
        {
            newPhone = this.NewPhone.Text;
        }
        else
        {
            DisplayAlert("ErrorPhone", invalidMessage, "Cancel");
            this.NewPhone.Text = null;
        }
    }

    private void NewDeposite_TextChanged(object sender, TextChangedEventArgs e)
    {
        bool checkResult = ValidatorMethods.DoubleValidator(this.NewDeposite.Text);
        if (checkResult)
            newDeposite = double.Parse(this.NewDeposite.Text);
        else
        {
            DisplayAlert("ErrorDeposite", invalidMessage, "Cancel");
            this.NewDeposite.Text = null;
        }
    }

    private void Rent_TextChanged(object sender, TextChangedEventArgs e)
    {
        bool checkResult = ValidatorMethods.DoubleValidator(this.NewRent.Text);
        if (checkResult)
            newRent = double.Parse(this.NewRent.Text);
        else
        {
            DisplayAlert("ErrorRent", invalidMessage, "Cancel");
            this.NewRent.Text = null;
        }
        
    }

    private void NewWaterLaundry_TextChanged(object sender, TextChangedEventArgs e)
    {
        bool checkResult = ValidatorMethods.DoubleValidator(this.NewWaterLaundry.Text);
        if (checkResult)
            newWaterLaundry = double.Parse(this.NewWaterLaundry.Text);
        else
        {
            DisplayAlert("ErrorWaterLaundry", invalidMessage, "Cancel");
            this.NewWaterLaundry.Text = null;
        }


    }

    private void NewElectricityReading_TextChanged(object sender, TextChangedEventArgs e)
    {
        bool checkResult = ValidatorMethods.IntValidator(this.NewElectricityReading.Text);
        if (checkResult)
            newElectricReading = int.Parse(this.NewElectricityReading.Text);
        else
        {
            DisplayAlert("ErrorElectricity", invalidMessage, "Cancel");
            this.NewElectricityReading.Text = null;
        }

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        DBConnect dBConnect = new DBConnect();
        dBConnect.UpdateAppartment(unitNum,newTentantName,newOccupation,newMoveInDate,newDeposite,newPhone,newRent,newWaterLaundry,newElectricReading);
        DisplayAlert("Task Successful","Database has been updated successfully","Reload");
        DetailsUpdateViewModel.GoMain();

    }
}