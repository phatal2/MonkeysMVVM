using MonkeysMVVM.ViewModels;

namespace MonkeysMVVM.Views;

public partial class MonkeysPage : ContentPage
{
	public MonkeysPage(MonkeysPageViewModel vm)
	{
		InitializeComponent();
        this.BindingContext = vm;
    }
}