namespace Final.SubPagesRaw;

public partial class Austin : ContentPage
{
	public Austin()
	{
		InitializeComponent();
	}
    private void addToOrderButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Checkout());

    }
}