using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LeftOverFeast.Views;

namespace LeftOverFeast
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {            
            InitializeComponent();
            //this.Title = "Food Storage";
            
        }

        private void btnMList_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new ItemsList()); 
        }
    }
}