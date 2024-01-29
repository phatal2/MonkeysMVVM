using MonkeysMVVM.ViewModels;

namespace MonkeysMVVM.Views;

public partial class FindMonkeyByLocationPage : ContentPage
{
	public FindMonkeyByLocationPage()
	{
		InitializeComponent();
		this.BindingContext = new FindMonkeyByLocationPageViewModel();
	}
}