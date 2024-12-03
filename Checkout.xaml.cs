
namespace Final;
using Final.Pages;

    public partial class Checkout : ContentPage
    {
        private List<string> orderItems = new List<string>();

        public Checkout()
        {
            InitializeComponent();
        }

        private void backToHomeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layout());
        }
    }

