using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LeftOverFeast
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterContent : ContentPage
    {
        public MasterContent()
        {
            InitializeComponent();
            this.Title = "LeftOverFeast";
        }

        private void btnTabs_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MainTabbedPage());
        }

        private void btnTiles_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new TilesMainPage());
        }
    }
}