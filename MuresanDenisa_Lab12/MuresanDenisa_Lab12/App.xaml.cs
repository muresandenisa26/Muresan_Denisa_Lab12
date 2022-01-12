using MuresanDenisa_Lab12.Services;
using MuresanDenisa_Lab12.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MuresanDenisa_Lab12.Data;

namespace MuresanDenisa_Lab12
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
