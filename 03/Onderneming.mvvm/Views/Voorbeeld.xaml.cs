using Onderneming.mvvm.ViewModels;

namespace Onderneming.mvvm.Views;

public partial class Voorbeeld : ContentPage
{
	public Voorbeeld()
	{
		InitializeComponent();

        // We maken een nieuw ViewModel aan
        PersoonViewModel viewModel = new();

        // We koppel het viewModel aan de View (this verwijst naar de huidige View)
        this.BindingContext = viewModel;
    }    
}