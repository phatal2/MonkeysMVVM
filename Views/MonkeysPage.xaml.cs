using MonkeysMVVM.ViewModels;

namespace MonkeysMVVM.Views;

public partial class MonkeysPage : ContentPage
{
	public MonkeysPage()
	{
		InitializeComponent();
        this.BindingContext = new MonkeysPageViewModel();
    }
}