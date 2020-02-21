﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LeftOverFeast.ViewModel;
using LeftOverFeast.Model;
using LeftOverFeast;
using LeftOverFeast.Views;

namespace LeftOverFeast.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Meat : ContentPage
    {
        private string mode;

        public Meat()
        {
            InitializeComponent();
            //CachedImageRenderer.Init();
           
        }

      

        protected override void OnAppearing()
        {
            FoodItemViewModel objItems = new FoodItemViewModel();
            base.OnAppearing();
            lstMeat.ItemsSource = objItems.MeatItems;            
        }

       

        private void btnMeat_Clicked(object sender, EventArgs e)
        {
            var _details = (sender as ImageButton).CommandParameter as FoodItem;
            // _details.Mode = "American";
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