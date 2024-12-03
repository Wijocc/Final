namespace Final.SubPagesRaw;

public partial class HK : ContentPage
{
	public HK()
	{
		InitializeComponent();
	}
    private void addToOrderButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Checkout());

    }
}