namespace iNutri;

public partial class SignInPage : ContentPage
{

	public SignInPage()
	{
		InitializeComponent();
	}
    private async void OnSignInButton1Clicked(object sender, EventArgs e)
    {
        string _UserEmail = UserEmail.Text;
        string _UserPassword= UserPassword.Text;
        if (_UserEmail == null || _UserPassword == null)
        {
            await DisplayAlert("Warning", "Please imput email and password", "OK");
            return;
        }
        else
        {
            await Navigation.PushAsync(new HomePage());
        }
        
    }

        private async void OnSignUpButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SignUpPage());
    }
}

