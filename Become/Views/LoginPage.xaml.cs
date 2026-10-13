namespace Become.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();

		ForgotPasswordTap.Tapped += async (_, _) => await Shell.Current.GoToAsync(nameof(ForgotPasswordPage));
		RegisterTap.Tapped += async (_, _) => await Shell.Current.GoToAsync(nameof(RegisterPage));
	}
}
