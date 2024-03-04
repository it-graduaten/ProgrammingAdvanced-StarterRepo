namespace VakkenOefening.Views;

public partial class CSPage : ContentPage
{
	public CSPage()
	{
		InitializeComponent();
	}
    void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        Score.Text = string.Format("{0}/20", value);
    }
    private async void BtnOpslaan_Clicked(object sender, EventArgs e)
    {
        string infoString = string.Empty;

        infoString += "Voornaam: " + Voornaam.Text;
        infoString += ", Naam: " + Naam.Text;
        infoString += ", Locatie: " + Campuslocatie.Text;
        infoString += ", Vast lokaal: " + VastLokaal.IsChecked.ToString();
        infoString += ", Lokaalnummer: " + LokaalNummer.Text;
        infoString += ", Datum eerste les: " + Datum.Date.ToShortDateString();
        infoString += ", Score: " + ScoreStep.Value.ToString() + "/20";

        await DisplayAlert("Info", infoString, "Terug aub");
    }
}