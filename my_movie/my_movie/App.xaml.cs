using my_movie.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace my_movie
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Lista());
            
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
