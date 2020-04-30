using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace syncfucsionTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //BindingContext = new BindableViewModel();
        }

        // Function to go into "CartPage" which is a list view page
        private void CartButton_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new CartPage();
        }

        // Function to send information to "CartPage"
        private void OrderButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
