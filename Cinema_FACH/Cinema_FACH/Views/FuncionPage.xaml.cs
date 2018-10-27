using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using static Cinema_FACH.Models.Cinema;

namespace Cinema_FACH.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FuncionPage : ContentPage
	{
		public FuncionPage (Cartelera cartelera)
		{
			InitializeComponent ();
            BindingContext = cartelera;
            
		}

        

        private async void SeleccionFuncion(object sender, SelectedItemChangedEventArgs e)
        {
            var function = e.SelectedItem as Funciones;
            await Navigation.PushModalAsync(new ResumenPage(function));
        }
    }
}