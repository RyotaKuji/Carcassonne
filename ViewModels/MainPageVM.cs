using Carcassonne.Views.Controls;
using Carcassonne.Views.Pages;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Carcassonne.ViewModels
{
	internal partial class MainPageVM : ObservableObject
	{
		[ObservableProperty]
		string name;

		MainPage mainPage;

		public MainPageVM(MainPage mainPage)
		{
			Name = "NoClicked";
			this.mainPage = mainPage;
			mainPage.layout.Add(new Tile());
		}
		[RelayCommand]
		void ButtonClicked()
		{
			Name = "clicked";
		}
	}
}
