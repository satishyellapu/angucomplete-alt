using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LeftOverFeast.Views;

namespace LeftOverFeast.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsList : ContentPage
    {
        public ItemsList()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            var result = App.SQLiteDb.GetItemsAsync();
            if (result.Count > 0)
            {
                result = result.OrderByDescending(x => x.FSId).ToList();
                lstPersons.ItemsSource = result;
            }

        }

        private void btnHome_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MainTabbedPage());
        }
    }
}