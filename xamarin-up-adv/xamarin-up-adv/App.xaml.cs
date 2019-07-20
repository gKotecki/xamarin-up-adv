using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamarin_up_adv.Services;
using xamarin_up_adv.Views;

namespace xamarin_up_adv
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
