namespace Final.SubPagesRaw;

public partial class Alaska : ContentPage
{
	public Alaska()
	{
		InitializeComponent();
	}
    private void addToOrderButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Checkout());

    }
}