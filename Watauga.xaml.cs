namespace Final.SubPagesCooked;

public partial class Watauga : ContentPage
{
	public Watauga()
	{
		InitializeComponent();
	}
    private void addToOrderButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Checkout());

    }
}