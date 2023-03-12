using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.GTKSpecific;
using Xamarin.Forms.Xaml;

namespace GuessTheCountry
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Xamarin.Forms.NavigationPage(new MainPage());
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
