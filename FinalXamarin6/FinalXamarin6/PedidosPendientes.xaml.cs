using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalXamarin6
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PedidosPendientes : ContentPage
	{
		public PedidosPendientes ()
		{
			InitializeComponent ();
		}

        private void BtnIniciarBusqueda_Clicked(object sender, EventArgs e)
        {

        }
    }
}