namespace Final.SubPagesRaw;

public partial class Hawaii : ContentPage
{
	public Hawaii()
	{
		InitializeComponent();
	}
    private void addToOrderButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Checkout());

    }
}