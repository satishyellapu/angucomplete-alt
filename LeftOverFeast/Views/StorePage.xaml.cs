using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LeftOverFeast.Model;
using LeftOverFeast.ViewModel;
using LeftOverFeast.Views;
using System.Linq;

namespace LeftOverFeast.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StorePage : ContentPage
    {
        FoodItem fi = new FoodItem();
        FoodStore fs;
        public StorePage()
        {
            InitializeComponent();
        }


        public StorePage(long FCategoryid, string ItemImage, string Name, int BestBeforeDays, int DiscardAfterDays)
        {
            try
            {
                InitializeComponent();

                this.Foodimg.Source = ItemImage.Trim();
                this.Foodname.Text = Name.Trim();
                this.BestBeforedays.Text = "Best if consumed within : " + BestBeforeDays.ToString() + " Days";
                this.DiscardAfterdays.Text = "Discard after : " + DiscardAfterDays.ToString() + " Days";
                this.TodayDate.Text = "Today’s Date : " + System.DateTime.Now.ToShortDateString();

                fi.FCategoryid = FCategoryid;
                fi.Name = Name.Trim();
                fi.BestBeforeDays = BestBeforeDays;
                fi.DiscardAfterDays = DiscardAfterDays;
                //   fi.Mode = mode;
            }
            catch (Exception ex)
            {
            }
            
        }



        private void btnBack_Clicked(object sender, EventArgs e)
        {
            //fs = new FoodStore();
            //fs.Mode = fi.Mode;
            //if (fs.Mode == "Indian")
            //{
            //    App.Current.MainPage = new NavigationPage(new Indian());
            //}
            //else if (fs.Mode == "American")
            //{
            //    App.Current.MainPage = new NavigationPage(new American());
            //}
            try
            {
                App.Current.MainPage = new NavigationPage(new TilesMainPage());
            }
            catch (Exception ex)
            {
            }
            
        }
        private void btnView_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new TabbedPage());
            }
            catch (Exception ex)
            {
            }
        }

        async void btnSave_Clicked(object sender, EventArgs e)
        {
            try
            {

                string Qty = "", Unit = "";
                FoodStore fs = new FoodStore();
                fs.FCategoryid = fi.FCategoryid;
                fs.DateStored = System.DateTime.Now.ToShortDateString();
                Qty = qty.SelectedIndex.ToString();

                if (Qty == "-1")
                {
                    await DisplayAlert("Alert", "Select Qty", "Ok");
                    return;
                }
                else
                {
                    Qty = qty.SelectedItem.ToString();
                }
                Unit = units.SelectedIndex.ToString();
                if (Unit == "-1")
                {
                    await DisplayAlert("Alert", "Select Units", "Ok");
                    return;
                }
                else
                {
                    Unit = units.SelectedItem.ToString();
                }

                fs.Qty = Qty;
                fs.Units = Unit;
                fs.FCategoryName = fi.Name;
                if (fi.BestBeforeDays != 0)
                {
                    DateTime ConsumeByDate = System.DateTime.Now.AddDays(fi.BestBeforeDays);//add 4 days;
                    fs.ConsumeByDate = ConsumeByDate.ToString();
                }
                if (fi.DiscardAfterDays != 0)
                {
                    DateTime DiscardAfterDays = System.DateTime.Now.AddDays(fi.DiscardAfterDays);//add 4 days;
                    fs.DiscardAfterDate = DiscardAfterDays.ToString();
                }               

                //Insert into SQl Lite
                await App.SQLiteDb.SaveItemAsync(fs);
                //
                try
                {
                    //Insert into CosmosDB
                    //string url = "http://10.0.2.2:7071/api/Create";
                    //var res = APICall.ApiCalls.Post<FoodStore>(url, fs);
                    //
                }
                catch (Exception ex)
                {}
              
                App.Current.MainPage = new NavigationPage(new ItemsList());
            }
            catch (Exception ex)
            {
            }

        }


    }
}