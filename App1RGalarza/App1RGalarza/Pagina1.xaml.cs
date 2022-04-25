using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1RGalarza
{
    public partial class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            InitializeComponent();
        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            String sUsuario = txtUsuario.Text;
            String sPin = txtPin.Text;

            if((sUsuario== "estudiante2022") && (sPin== "uisrael2022"))
            {
                await Navigation.PushAsync(new MainPage());

            }
            else
            {
                DisplayAlert("Credenciales Incorrectas...! ",sUsuario,"Cerrar");
            } 
        }
    }
}