using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Conversor_de_Unidades_de_Longitud
{
    public partial class Form2 : MaterialSkin.Controls.MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }

        private void cmdconvertir_Click_1(object sender, EventArgs e)
        {
            cLongitudes longitud = new cLongitudes();
            double valor_ingresado;
            bool isNumber = double.TryParse(txtvalor.Text, out valor_ingresado);

            if (isNumber)
            {
                String textoOrigen = cmborigen.Text;
                String textoDestino = cmbdestino.Text;
                String textValue = textoOrigen + textoDestino;
                Dictionary<string, Func<double, double>> MetodosDeConversión = new Dictionary<string, Func<double, double>>
            {
                { "MetrosCentímetros", longitud.mts_cms },
                { "MetrosMilímetros", longitud.mts_mili },
                { "MetrosKilómetros", longitud.mts_km },
                { "CentímetrosMetros", longitud.cms_mts },
                { "CentímetrosMilímetros", longitud.cms_mili },
                { "CentímetrosKilómetros", longitud.cms_km },
                { "MilímetrosCentímetros", longitud.mili_cms },
                { "MilímetrosMetros", longitud.mili_mts },
                { "MilímetrosKilómetros", longitud.mili_km },
                { "KilómetrosCentímetros", longitud.km_cms },
                { "KilómetrosMetros", longitud.km_mts },
                { "KilómetrosMilímetros", longitud.km_mili }
            };

                if (MetodosDeConversión.TryGetValue(textValue, out Func<double, double> ConvertirValores))
                {
                    double resultado = ConvertirValores(valor_ingresado);
                    lblresultado.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Seleccionaste 2 unidades iguales...");
                }

            }
            else
            {
                MessageBox.Show("Ingrese un número valido.");
            }

        }

        private void cmdSalir_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias");
            Application.Exit();
        }
    }
}
