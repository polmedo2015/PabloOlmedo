using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PabloOlmedo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        decimal monto1;
        decimal calculo;
        decimal porcentaje;

        public Registro(String user, String Pass)
        {
            InitializeComponent();
            DisplayAlert("Mensaje", "El usuario es " + user + " La contraseña es " + Pass, "cerrar");
            lblUser.Text = user;
            //lblPass.Text = Pass;///////test

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string nombre = "";
            string pago = "";
            bool answer = await DisplayAlert("Mensaje", "Guardado con exito", "si", "no");
            if (answer)
            {
                await Navigation.PushAsync(new Resumen(lblUser.Text, txtDatoUno.Text, txtDatoTres.Text));
            }




        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                porcentaje = 3000 * Convert.ToDecimal(0.05);
                monto1 = Convert.ToDecimal(txtDatoDos.Text);
                calculo = (monto1 / 5) + porcentaje;
                txtDatoTres.Text = calculo.ToString();


            }
            catch (Exception ex)
            {

                DisplayAlert("ERROR", ex.Message, "Cerrar");
            }

        }
    }
}