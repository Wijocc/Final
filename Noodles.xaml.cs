namespace Final.SubPagesOther;

public partial class Noodles : ContentPage
{
    public Noodles()
    {
        InitializeComponent();
    }
    private void chickennButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SubPagesOther.Noodles());
    }
    private void beefnButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SubPagesOther.Noodles());
    }
    private void shrimpnButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SubPagesOther.Noodles());
    }
}