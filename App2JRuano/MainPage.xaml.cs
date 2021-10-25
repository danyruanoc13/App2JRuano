using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2JRuano
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario, string password)
        {
            InitializeComponent();
        }

            private void btnCalEP_Clicked(object sender, EventArgs e)
        {

            double valor1 = Convert.ToDouble(txtNotaS1.Text);
            double valor2 = Convert.ToDouble(txtNotaE1.Text);
            double val1 = short.Parse(txtNotaS1.Text);
            double val2 = short.Parse(txtNotaE1.Text);
            if (val1 < 0 || val1 > 10)
            {
                DisplayAlert("Error de entrada", "Solo puede ingresar numeros del 0 al 10", "Aceptar");
                txtNotaS1.Focus();
            }

            if (val2 < 0 || val2 > 10)
            {
                DisplayAlert("Error de entrada", "Solo puede ingresar numeros del 0 al 10", "Aceptar");
                txtNotaE1.Focus();
            }

            else

            {
                //operacion EVALUACION PARCIAL
                double suma1 = valor1 + valor2;
                txtResultadoParcial.Text = suma1.ToString();

                double suma2 = (valor1 * 0.3) + (valor2 * 0.2);
                txtEP.Text = suma2.ToString();

            }
        }

        private void btnCalEF_Clicked(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtNotaS2.Text);
            double valor2 = Convert.ToDouble(txtNotaE2.Text);

            double val1 = short.Parse(txtNotaS2.Text);
            double val2 = short.Parse(txtNotaE2.Text);

            if (val1 < 0 || val1 > 10)
            {
                DisplayAlert("Error de entrada", "Solo puede ingresar numeros del 0 al 10", "Aceptar");
                txtNotaS2.Focus();
            }

            if (val2 < 0 || val2 > 10)
            {
                DisplayAlert("Error de entrada", "Solo puede ingresar numeros del 0 al 10", "Aceptar");
                txtNotaE2.Focus();
            }

            else

            {
                //operacion EVALUACION FINAL
                double sumaf1 = valor1 + valor2;
                txtResultadoFinal.Text = sumaf1.ToString();

                double sumaf2 = (valor1 * 0.3) + (valor2 * 0.2);
                txtEF.Text = sumaf2.ToString();
            }



        }

        private void btnCalProm_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Almacenar variables ingresadas
                double valor1 = Convert.ToDouble(txtEP.Text);
                double valor2 = Convert.ToDouble(txtEF.Text);

                //operacion
                double promFinal = valor1 + valor2;
                txtNotaF.Text = promFinal.ToString();


                if (promFinal >= 7)
                {
                    txtEstado.Text = "APROBADO";
                }
                else
                {
                    if (promFinal >= 5 && promFinal <= 6.999)
                    {
                        txtEstado.Text = "COMPLEMENTARIO";
                    }
                    else
                    {
                        txtEstado.Text = "REPROBADO";
                    }

                }
            }
            catch (Exception ex)
            {
                //mostrar error capturado de el bloque try
                DisplayAlert("Mensaje de advertencia", ex.Message, "OK");
            }
        }
    }
}
