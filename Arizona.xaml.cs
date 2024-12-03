namespace Final.SubPagesCooked;

public partial class Arizona : ContentPage
{
    private object newItem;

    public Arizona()
	{
		InitializeComponent();
	}
    private void addToOrderButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Checkout());
        
    }

}