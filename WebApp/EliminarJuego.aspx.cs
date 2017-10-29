using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class EliminarJuego : System.Web.UI.Page
    {

        List<Juego> SessionJuego
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
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            this.lblMensaje.Text = string.Empty;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = this.txtId.Text;

            foreach (Juego j in SessionJuego)
            {
                if ((j.Id) == id)
                {
                    SessionJuego.Remove(j);
                    this.lblMensaje.Text = "El juego ha sido eliminado";
                    break;
                }
                else
                {
                    this.lblMensaje.Text = "El ID ingresado no existe. Ingrese otra ID";
                }
            }
        }
    }
}