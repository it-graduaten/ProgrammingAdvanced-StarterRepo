namespace VakkenOefening.Views;

public partial class OverzichtVakkenGrid : ContentPage
{
	public OverzichtVakkenGrid()
	{
		InitializeComponent();
	}
    private void CSPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CSPage());
    }
    private void JSPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new JSPage());
    }
    private void BootstrapPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BootstrapPage());
    }
    private void ReactPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ReactPage());
    }
    private void AngularPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AngularPage());
    }
}