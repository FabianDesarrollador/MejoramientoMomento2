using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema_FACH.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            loginboton.Clicked += loginboton_Clicked;
        }

        private async void loginboton_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(user.Text))
            {
                await DisplayAlert("Error", "Debe Ingresar un Usuario", "Aceptar");
                user.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password.Text))
            {
                await DisplayAlert("Error", "Debe Ingresar una Contraseña", "Aceptar");
                user.Focus();
                return;
            }

            loginActivity.IsRunning = true;
            HttpClient cliente = new HttpClient();
            cliente.BaseAddress = new Uri(" https://misapis.azurewebsites.net")
            string url = string.Format("/api/Seguridad ");
        }
    }
}