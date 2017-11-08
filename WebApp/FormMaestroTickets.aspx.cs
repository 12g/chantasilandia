using Juegos.Negocio.Colecciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class FormMaestroticket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            TicketCollection listaTickets = new TicketCollection();
            GdTickets.DataSource = listaTickets.ReadAll();
            GdTickets.DataBind();



        }
    }
}