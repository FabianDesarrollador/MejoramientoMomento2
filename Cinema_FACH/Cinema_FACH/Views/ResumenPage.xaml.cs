using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Cinema_FACH.Models.Cinema;

namespace Cinema_FACH.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResumenPage : ContentPage
	{
		public ResumenPage (Funciones function)
		{
			InitializeComponent ();
            BindingContext = function;
           
		}

        
	}
}