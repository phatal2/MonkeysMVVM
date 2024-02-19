using MonkeysMVVM.Views;

namespace MonkeysMVVM;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("MonkeysPage", typeof(MonkeysPage));
		Routing.RegisterRoute("FindMonkeyPage", typeof(FindMonkeyByLocationPage));
		Routing.RegisterRoute("MonkeyPage", typeof(ShowMonkeyView));
	}
}
