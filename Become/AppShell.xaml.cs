using Become.Views;

namespace Become;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
		Routing.RegisterRoute(nameof(ForgotPasswordPage), typeof(ForgotPasswordPage));
		Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
		Routing.RegisterRoute(nameof(MatchFoundPage), typeof(MatchFoundPage));
		Routing.RegisterRoute(nameof(FoundDocumentPage), typeof(FoundDocumentPage));
	}
}
