using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class AgregarJuego : System.Web.UI.Page
    {
        private List<Juego> SessionJuego
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
                Session["Session"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ddlRiesgo.DataSource = Enum.GetNames(typeof(NivelDeRiesgo));
                ddlRiesgo.DataBind();

                ddlTipoJuego.DataSource = Enum.GetNames(typeof(TipoJuego));
                ddlTipoJuego.DataBind();
            }

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Juego j;
            String seleccion = ddlTipoJuego.SelectedValue;

            if (seleccion == "JuegoCasual")
            {
                j = new JuegoCasual();
                ((JuegoCasual)j).PoseeCinturon = this.chkCinturon.Checked;
            }
            else if (seleccion == "JuegoExtremo")
            {
                j = new JuegoExtremo();
                ((JuegoExtremo)j).Altura = int.Parse(this.txtAltura.Text);
                ((JuegoExtremo)j).Riesgo1 = (NivelDeRiesgo)Enum.Parse(typeof(NivelDeRiesgo), this.ddlRiesgo.SelectedValue);
            }
            else
            {
                j = null;
            }

            if (j.GetType().IsSubclassOf(typeof(Juego)))
            {
                j.Id = this.txtId.Text;
                j.Nombre = this.txtNombre.Text;
                j.Capacidad = int.Parse(this.txtCap.Text);
                j.Tipojuego = (TipoJuego)Enum.Parse(typeof(TipoJuego), this.ddlTipoJuego.SelectedValue);
                SessionJuego.Add(j);


                lblResumen.Text = "Juego agregado correctamente.";
            }
            else
            {
                lblResumen.Text = "Hubo un error de sistema. Por favor, reintente.";
            }
        }

        protected void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            this.txtId.Text = "";
            this.txtCap.Text = "";
            this.txtAltura.Text = "";
            this.chkCinturon.Checked = false;
            this.chkSupervision.Checked = false;
            this.ddlRiesgo.SelectedIndex = 0;
            this.ddlTipoJuego.SelectedIndex = 0;
        }
    }
}