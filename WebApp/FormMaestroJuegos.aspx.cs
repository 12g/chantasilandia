using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Juegos.Negocio.Colecciones;

namespace WebApp
{
    public partial class FormMaestroJuegos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            JuegoCasualCollection listaCasuales = new JuegoCasualCollection();
            GdJuegosCasuales.DataSource = listaCasuales.ReadAll();
            GdJuegosCasuales.DataBind();

            JuegoExtremoCollection listaExtremos = new JuegoExtremoCollection();
            GdJuegosExtremos.DataSource = listaExtremos.ReadAll();
            GdJuegosExtremos.DataBind();
        }

        protected void BtnFiltrar_OnClick(object sender, EventArgs e)
        {
            String filtro = TxtFiltro.Text;
            if (filtro != "")
            {
                
            }
        }
    }
}