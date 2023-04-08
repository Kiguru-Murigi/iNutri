namespace iNutri.Pages;

public partial class NutritionGuide : ContentPage

{
    private List<string> Cancer;
    private List<string> Cardiovascular;
    private List<string> Diabetes;
    private List<string> Chronic;
    public NutritionGuide()
    {
        InitializeComponent();


        // Populate the OptionPicker

        Cancer = new List<string>(){ "Breast cancer", "Cervical cancer", "Ovary cancer", "Prostate cancer", "Colorectal cancer", "Esophagus cancer" };
        Picker CancerPicker = new Picker();
        CancerPicker.ItemsSource = Cancer;

        Cardiovascular = new List<string>() { "Hytertension", "Chronic ischemic heart disease", "Cerebrovascular disease" };
        Picker CardiovascularPicker = new Picker();
        CardiovascularPicker.ItemsSource = Cardiovascular;

        Diabetes = new List<string>() { "Type 1", "Type 2", "Gestational diabetes" };
        Picker DiabetesPicker = new Picker();
        DiabetesPicker.ItemsSource = Diabetes;

        Chronic = new List<string>() { "Chronic obstructive pulmonary disease (COPD)", "Asthma", "Pulmonary Hypertension" };
        Picker ChronicPicker = new Picker();
        ChronicPicker.ItemsSource = Chronic;
    }


    private void OnCancerPicked(object sender, EventArgs e)

    {

        // Get the selected option from the OptionPicker

        string selectedOption = CancerPicker.SelectedItem as string;


        // Do something with the selected option

        // For example, display a message

        DisplayAlert("Selected Option", selectedOption, "OK");

    }

    private void OnCardiovascularPicked(object sender, EventArgs e)

    {

        // Get the selected option from the OptionPicker

        string selectedOption = CardiovascularPicker.SelectedItem as string;


        // Do something with the selected option

        // For example, display a message

        DisplayAlert("Selected Option", selectedOption, "OK");

    }

    private void OnDiabetesPicked(object sender, EventArgs e)

    {

        // Get the selected option from the OptionPicker

        string selectedOption = DiabetesPicker.SelectedItem as string;


        // Do something with the selected option

        // For example, display a message

        DisplayAlert("Selected Option", selectedOption, "OK");

    }

    private void OnChronicPicked(object sender, EventArgs e)

    {

        // Get the selected option from the OptionPicker

        string selectedOption = ChronicPicker.SelectedItem as string;


        // Do something with the selected option

        // For example, display a message

        DisplayAlert("Selected Option", selectedOption, "OK");

    }
}



