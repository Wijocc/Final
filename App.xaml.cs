namespace Final;
using Final.Pages;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        //MainPage = new AppShell();
        var navigationPage = new NavigationPage(new Layout());

        MainPage = navigationPage;
    }
}
