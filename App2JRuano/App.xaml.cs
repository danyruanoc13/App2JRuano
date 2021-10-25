using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2JRuano
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Ventana que se ejecuta
            MainPage = new NavigationPage(new User());
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
