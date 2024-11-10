using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio153
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSaludo_Click(object sender, EventArgs e)
        {
            String text = txbCaja.Text;
            Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Messagebox", "window.alert('Hola " + text + "');", true);
        }
    }
}