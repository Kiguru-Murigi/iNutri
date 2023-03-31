namespace iNutri;

public partial class NutritionGuide : ContentPage

{
    private List<string> Cancer;
    public NutritionGuide()
    {
        InitializeComponent();


        // Populate the OptionPicker

        Cancer = new List<string>(){"Option 1","Option 2", "Option 3","Option 4"};

        Picker CancerPicker = new Picker();

        CancerPicker.ItemsSource = Cancer;

    }


    private void OnCancerPicked(object sender, EventArgs e)

    {

        // Get the selected option from the OptionPicker

        string selectedOption = CancerPicker.SelectedItem as string;


        // Do something with the selected option

        // For example, display a message

        DisplayAlert("Selected Option", selectedOption, "OK");

    }

}



