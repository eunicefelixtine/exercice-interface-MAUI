namespace Become.Views;

public partial class ForgotPasswordPage : ContentPage
{
	public ForgotPasswordPage()
	{
		InitializeComponent();

		BackTap.Tapped += async (_, _) => await Shell.Current.GoToAsync("..");
	}
}
