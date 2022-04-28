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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnAbrirVentanaDos_Clicked(object sender, EventArgs e)
        {
            String user = txtUser.Text;
            String pass = txtPass.Text;

            if ((user == "pablo2022") && (pass == "uisrael2022"))

            {


                await Navigation.PushAsync(new Registro(user, pass));



            }

            else
            {

                await DisplayAlert("Error", "Usuario o Clave Incorrectos", "Ok");


            }

        }


    }
}