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
    public partial class Resumen : ContentPage
    {
        public Resumen(string user, string nombre, string pago)
        {
            InitializeComponent();
            lblUser.Text = user;

            txtDatoUno.Text = nombre;
            txtDatoDos.Text = pago;
            //lblPass.Text = Pass;///////test

        }
    }
}