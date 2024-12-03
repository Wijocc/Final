namespace Final.SubPagesOther;

public partial class FriedRice : ContentPage
{
    public FriedRice()
    {
        InitializeComponent();
    }
    private void chickenfrButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SubPagesOther.FriedRice());
    }
    private void beeffrButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SubPagesOther.FriedRice());
    }
    private void shrimpfrButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SubPagesOther.FriedRice());
    }
}