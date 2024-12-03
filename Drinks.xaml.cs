namespace Final.SubPagesOther;

public partial class Drinks : ContentPage
{
	public Drinks()
	{
		InitializeComponent();
	}
    private void cokeButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SubPagesOther.Drinks());
    }
    private void pepsiButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SubPagesOther.Drinks());
    }
    private void drpepperButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SubPagesOther.Drinks());
    }
}