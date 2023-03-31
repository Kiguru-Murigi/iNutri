namespace iNutri.Pages;

public partial class ConsultationPage : ContentPage
{
    public ConsultationPage()
    {
        InitializeComponent();
    }

    private async void OnBookConsultationClicked(object sender, EventArgs e)
    {
        // Get the selected date, time, and consultation type
        DateTime consultationDat = consultationDate.Date;
        TimeSpan consultationTim = consultationTime.Time;
        string consultationTyp = (string)consultationType.SelectedItem;


        
        // Create consultation object and save it to the database
        //Consultation consultation = new Consultation(consultationDat, consultationTim, consultationTyp);
        


        // TODO: Save consultation object to the database



        // Display phone or video call information based on consultation type
        if (consultationTyp == "Phone")
        {
            await DisplayAlert("Phone Consultation Scheduled", "Your appointment has been scheduled",
            "OK", "CANCEL");
        }
        else if (consultationTyp == "Video")
        {
            await DisplayAlert("Video Consultation Scheduled", "Your video consultation has scheduled" + "Please click on the following link to join the video call: " +
            "https://example.com/video-call", "OK", "CANCEL");
        }



        // Navigate to confirmation page
        // await Navigation.PushAsync(new ConfirmationPage());
    }
}

public class Consultation
{
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public string Type { get; set; }

    public Consultation(DateTime date, TimeSpan time, string type)
    {
        Date = date;
        Time = time;
        Type = type;
    }
}
