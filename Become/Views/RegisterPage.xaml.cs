namespace Become.Views;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();

		LoginTap.Tapped += async (_, _) => await Shell.Current.GoToAsync("..");
	}
}
