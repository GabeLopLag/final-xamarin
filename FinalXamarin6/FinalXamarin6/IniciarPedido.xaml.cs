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
	public partial class IniciarPedido : ContentPage
	{
		public IniciarPedido ()
		{
			InitializeComponent ();
		}

        private void BtnEnviar_Clicked(object sender, EventArgs e)
        {
            try
            {
                string cliente = "";
                string producto = "";
                double importeTotal = 0;
                string comentario = "";
                DateTime fecha;

                if (txtCliente.Text != "" && txtProducto.Text != "" && 
                    txtImporteTotal.Text != "" && txtComentario.Text != "")
                {
                    cliente = txtCliente.Text;
                    producto = txtProducto.Text;
                    comentario = txtComentario.Text;
                    importeTotal = double.Parse(txtImporteTotal.Text);
                }
                else
                {
                    DisplayAlert("Campos vacíos", "Por favor, llene los campos con la información solicitada", "Ok");
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Error:", ex.Message, "Ok");
            }
            
        }
    }
}