using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2JRuano
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class User : ContentPage
    {
        public User()
        {
            InitializeComponent();
        }

        private async void btnIngreso_Clicked(object sender, EventArgs e)
        {

            string usuario = txtuser.Text;
            string password = txtpass.Text;

            string user = "estudiante2021";
            string pass = "uisrael2021";

            if (usuario == user && password == pass)
            {
                await Navigation.PushAsync(new MainPage(usuario, password));

            }

            else
            {

                await DisplayAlert("Advertencia" ,"El nombre de usuario o contraseña son incorrectos", "OK");
            
            }
        }
    }

   

}