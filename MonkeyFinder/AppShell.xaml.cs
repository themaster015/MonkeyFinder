using MonkeyFinder.View;

namespace MonkeyFinder;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		InicializarRouting();
	}

    private void InicializarRouting()
    {
		Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
    }
}
