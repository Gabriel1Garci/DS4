using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNota1.Text)|| string.IsNullOrEmpty(textBoxNota2.Text)|| string.IsNullOrEmpty(textBoxNota3.Text))
            {
                MessageBox.Show("Ingrese la informacion solicitada.");
                return;
            }

            if (double.TryParse(textBoxNota1.Text, out double nota1) && double.TryParse(textBoxNota2.Text, out double nota2) && double.TryParse(textBoxNota3.Text, out double nota3)) {
                double Final = nota1+nota2+nota3;
                double notaFinal = Final / 3;
                textBoxFinal.Text = notaFinal.ToString("F2");
            }
            else
            {
                MessageBox.Show("Ingrese valores Numericos Validos");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxNota1.Clear();
            textBoxNota2.Clear();
            textBoxNota3.Clear();
            textBoxFinal.Text = ("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
