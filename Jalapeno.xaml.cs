namespace Final.SubPagesCooked;

public partial class Jalapeno : ContentPage
{
	public Jalapeno()
	{
		InitializeComponent();
	}
    private void addToOrderButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Checkout());

    }
}