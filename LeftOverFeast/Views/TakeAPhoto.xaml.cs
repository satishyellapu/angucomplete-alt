using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LeftOverFeast.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TakeAPhoto : ContentPage
    {
        public TakeAPhoto()
        {
            InitializeComponent();
        }
        private void btnHome_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MasterContent());
        }
    }
}