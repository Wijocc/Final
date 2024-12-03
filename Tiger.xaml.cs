namespace Final.SubPagesRaw;

public partial class Tiger : ContentPage
{
	public Tiger()
	{
		InitializeComponent();
	}
    private void addToOrderButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Checkout());

    }
}