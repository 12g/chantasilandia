using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class FormAgregarJuego : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

            }
        }

        protected void OnSelectTipoJuego(object sender, EventArgs e)
        {

            divJuegoExtremo.Visible = (ddlTipoJuego.SelectedIndex == 0);
            divJuegoCasual.Visible = (ddlTipoJuego.SelectedIndex == 1);
        }

        protected void OnSubmitNew(object sender, EventArgs e)
        {

        }

        protected void OnClean(object sender, EventArgs e)
        {

        }
    }
}