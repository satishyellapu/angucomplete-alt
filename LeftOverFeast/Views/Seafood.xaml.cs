using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LeftOverFeast.ViewModel;
using LeftOverFeast.Model;

namespace LeftOverFeast.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Seafood : ContentPage
    {
        public Seafood()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            FoodItemViewModel objItems = new FoodItemViewModel();
            base.OnAppearing();
            lstSeafood.ItemsSource = objItems.Seafooditems;


        }
        private void btnSeafood_Clicked(object sender, EventArgs e)
        {
            var _details = (sender as ImageButton).CommandParameter as FoodItem;            
            App.Current.MainPage = new StorePage(_details.FCategoryid, _details.ItemImage, _details.Name, _details.BestBeforeDays, _details.DiscardAfterDays);
        }

        private void btnManage_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new ItemsList());
        }

        private void btnHome_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MasterContent());
        }

       
    }
}