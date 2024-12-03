namespace Final.SubPagesCooked;

public partial class CrabDyn : ContentPage
{
	public CrabDyn()
	{
		InitializeComponent();
	}
    private void addToOrderButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Checkout());

    }
}