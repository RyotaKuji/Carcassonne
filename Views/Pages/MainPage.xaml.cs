namespace Carcassonne.Views.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.MainPageVM(this);
	}
}