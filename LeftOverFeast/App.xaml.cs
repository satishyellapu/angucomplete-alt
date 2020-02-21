using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace LeftOverFeast
{
    public partial class App : Application
    {
        static SQLiteHelper db;
        static TodoItemDatabase database;
        public App()
        {
            InitializeComponent();

            //MainPage = new MainTabbedPage();
            //MainPage = new TilesMainPage();
            MainPage = new MasterContent();
        }
        public static SQLiteHelper SQLiteDb
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LeftOverFeast.db3"));
                }
                return db;
            }
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
