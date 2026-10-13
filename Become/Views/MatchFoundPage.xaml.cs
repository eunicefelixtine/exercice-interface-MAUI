namespace Become.Views;

public partial class MatchFoundPage : ContentPage
{
	public MatchFoundPage()
	{
		InitializeComponent();

		CloseTap.Tapped += async (_, _) => await Shell.Current.GoToAsync("..");
		WhyTap.Tapped += (_, _) => WhyDetailsLabel.IsVisible = !WhyDetailsLabel.IsVisible;
	}
}
