using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LeftOverFeast.Model;
using LeftOverFeast.Views;

namespace LeftOverFeast
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TilesMainPage : ContentPage
    {
        FoodStore fs = null;
        public TilesMainPage()
        {
            InitializeComponent();
        }

        public void btnMeat_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new TMeat());           


        }

        private void btnSeafood_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new TSeafood());
        }

        private void btnPizza_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new TPizza());
        }

        private void btnTakePhoto_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new TTakePhoto());
        }

        private void btnHome_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MasterContent());
        }

        //private void btnHome_Clicked(object sender, EventArgs e)
        //{
        //    App.Current.MainPage = new NavigationPage(new MasterContent());
        //}
    }
}