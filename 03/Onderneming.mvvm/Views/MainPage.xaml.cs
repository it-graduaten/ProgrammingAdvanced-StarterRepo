using Onderneming.mvvm.ViewModels;
namespace Onderneming.mvvm.Views;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}