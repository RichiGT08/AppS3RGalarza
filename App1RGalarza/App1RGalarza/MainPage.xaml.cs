using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1RGalarza
{
    public partial class MainPage : ContentPage
    {
        private Button parc;

        public MainPage()
        {
            InitializeComponent();

        }
            public void Btnparcial1_Clicked(object sender, EventArgs e)
            {
                var segu1 = double.Parse(segui1.Text);
                var exam = double.Parse(examen1.Text);
                var parc = (segu1 * 0.3) + (exam * 0.2);

                string mensaje = "Parcial Primero:" + parc;
                DisplayAlert("MEnsaje ", mensaje, "nota");

            }

            public void Parcial2_Clicked(object sender, EventArgs e)
            {
                var segu2 = double.Parse(segui2.Text);
                var exam2 = double.Parse(examen2.Text);
                var parc2 = (segu2 * 0.3) + (exam2 * 0.2);

                string mensaje = "Segundo Parcial: " + parc2;
                DisplayAlert("MEnsaje ", mensaje, "nota");
            }


            private void notafinal_Clicked_1(object sender, EventArgs e)
            {

            var final1 = double.Parse(segui2.Text);
            var final2 = double.Parse(segui1.Text);
            var promfin = final1+final2;

                string resultado = "";
                if (promfin <= 5)
                {
                    resultado = "Reprobado";

                }
                else
                {
                    DisplayAlert("usted ha: ", resultado, "con" + promfin, ".");
                }
            }
        }
    }