namespace Become;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	// Chaque bouton porte en CommandParameter la route de l'écran à ouvrir.
	private async void OnScreenClicked(object? sender, EventArgs e)
	{
		if (sender is Button { CommandParameter: string route })
			await Shell.Current.GoToAsync(route);
	}
}
