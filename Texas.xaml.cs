namespace Final.SubPagesCooked;

public partial class Texas : ContentPage
{
	public Texas()
	{
		InitializeComponent();
	}
    private void addToOrderButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Checkout());

    }
}