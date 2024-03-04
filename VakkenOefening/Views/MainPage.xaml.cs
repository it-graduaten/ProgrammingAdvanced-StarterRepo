using VakkenOefening.Views;

namespace VakkenOefening.Views
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void StackClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OverzichtVakkenStack());
        }
        private void GridClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OverzichtVakkenGrid());
        }
        private void FlexClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OverzichtVakkenFlex());
        }
    }

}
