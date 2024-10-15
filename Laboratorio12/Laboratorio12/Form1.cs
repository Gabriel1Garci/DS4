using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12
{
    public partial class calcular : Form
    {
        public calcular()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAuto1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAuto1.Text) || string.IsNullOrEmpty(txtAuto2.Text))
            {
                MessageBox.Show("Ingrese la Informacion solicitada.");
                return;
            }

            try
            {
                double velocidad = Convert.ToDouble(txtAuto1.Text);
                double tiempo = Convert.ToDouble(txtAuto2.Text);

                double distancia = velocidad * tiempo;

                txtTotal.Text = distancia.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numericos validos");

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAuto1.Clear();
            txtAuto2.Clear();
            txtTotal.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
