using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class ListarJuego : System.Web.UI.Page
    {

        private List<Juego> ListaJuegos
        {
            get
            {
                if (Session["session"] == null)
                {
                    Session["session"] = new List<Juego>();
                }
                return (List<Juego>)Session["session"];
            }

            set
            {
                Session["session"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.gdListar.DataSource = ListaJuegos;
            this.gdListar.DataBind();
        }
    }

}
