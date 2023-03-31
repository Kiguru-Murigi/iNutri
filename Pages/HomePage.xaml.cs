namespace iNutri;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void OnImageButton1Clicked(object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new Pages.NutritionGuide());
    }

    private async void OnImageButton2Clicked(object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new Pages.ConsultationPage());
    }
}