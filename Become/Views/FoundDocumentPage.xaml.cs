namespace Become.Views;

public partial class FoundDocumentPage : ContentPage
{
	public FoundDocumentPage()
	{
		InitializeComponent();

		BackTap.Tapped += async (_, _) => await Shell.Current.GoToAsync("..");
	}
}
