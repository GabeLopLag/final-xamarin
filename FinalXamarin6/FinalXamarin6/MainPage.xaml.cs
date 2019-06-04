using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FinalXamarin6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            try
            {
                string username = "";
                string password = "";

                if (txtUsername.Text != "" && txtPassword.Text != "")
                {
                    username = txtUsername.Text;
                    password = txtPassword.Text;
                }
                else
                {
                    DisplayAlert("Campos vacíos", "Por favor, llene los campos con la información solicitada", "Ok");
                }
            }
            catch(Exception ex)
            {

            }
            
        }
    }
}
