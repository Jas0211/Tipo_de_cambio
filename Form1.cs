using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tipo_de_cambio
{
    public partial class Form1 : Form
    {
        private string texto_anterior = string.Empty;
        private double TipoCambioDolar = 0;
        private double TipoCambioEuro = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_dolares_Click(object sender, EventArgs e)
        {
            string url = "https://gee.bccr.fi.cr/indicadoreseconomicos/Cuadros/frmVerCatCuadro.aspx?idioma=1&CodCuadro=%20400";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void Btn_euros_Click(object sender, EventArgs e)
        {
            string url = "https://gee.bccr.fi.cr/indicadoreseconomicos/Cuadros/frmVerCatCuadro.aspx?idioma=1&CodCuadro=%2012";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }


        private void Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false; // Permitir dígitos
            }
            else if (e.KeyChar == ',')
            {
                e.Handled = false; // Permitir la coma
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false; // Permitir la tecla Backspace
            }
            else
            {
                e.Handled = true; // Bloquear cualquier otro carácter
            }

        }

        private void Txt_cambio_dolares_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(Txt_cambio_dolares.Text, out double cambioDolar))
            {
                TipoCambioDolar = cambioDolar;
            }
        }

        private void Txt_cambio_euros_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(Txt_cambio_euros.Text, out double cambioEuro))
            {
                TipoCambioEuro = cambioEuro;
            }
        }

        private void Txt_Colones_TextChanged(object sender, EventArgs e)
        {
            // No necesitamos hacer nada aquí por ahora
        }

        private void Cbx_Convertir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (double.TryParse(Txt_Colones.Text, out double colones))
            {
                switch (Cbx_Convertir.SelectedIndex)
                {
                    case 0: // Dólares
                        double dolares = colones / TipoCambioDolar; // Aquí usamos la división
                        MessageBox.Show($"La conversión de {colones} colones a dólares es: {dolares:F2} USD", "Resultado de Conversión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 1: // Euros
                        dolares = (colones / TipoCambioDolar) ;
                        double euros = dolares / TipoCambioEuro; // Aquí usamos la división
                        MessageBox.Show($"La conversión de {colones} colones a euros es: {euros:F2} EUR", "Resultado de Conversión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        MessageBox.Show("Seleccione una opción válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido en colones.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
