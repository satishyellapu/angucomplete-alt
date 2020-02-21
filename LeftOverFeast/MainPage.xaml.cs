using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LeftOverFeast
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            if (Device.RuntimePlatform != Device.UWP)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }
            if (Device.RuntimePlatform != Device.Android)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }
        }
    }
}
