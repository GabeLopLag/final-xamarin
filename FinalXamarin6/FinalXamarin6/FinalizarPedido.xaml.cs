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
	public partial class FinalizarPedido : ContentPage
	{
		public FinalizarPedido ()
		{
			InitializeComponent ();
		}

        private void BtnFinalizar_Clicked(object sender, EventArgs e)
        {

        }
    }
}