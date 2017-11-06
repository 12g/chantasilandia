using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class FormListaJuegos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnVer_Click(object sender, EventArgs e)
        {
            int juego = GdJuegos.SelectedIndex;
            if (juego > 0)
            {
                String url = String.Format("FormMantenedorJuegos.aspx?id={0}", juego);
                Response.Redirect(url);
            }
        }
    }
}