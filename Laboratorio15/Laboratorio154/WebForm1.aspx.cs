using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio154
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            int Uno, Dos, btnSumar;
            if (int.TryParse(txbUno.Text, out Uno) && int.TryParse(txbDos.Text, out Dos))
            {
                btnSumar = Uno + Dos;
                lblResultado.Text = "Resultado: " + btnSumar.ToString();
            }
            else
            {
                lblResultado.Text = "Por favor, ingrese números válidos.";
            }
        }
    }
}