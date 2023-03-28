namespace iNutri;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}
    private async void OnSignInButton2Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SignInPage());
    }
}