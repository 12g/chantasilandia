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
            Juego j = new Juego();
            JuegoCasual jc = new JuegoCasual();
            JuegoExtremo je = new JuegoExtremo();

            j.Id = this.txtId.Text;
            j.Nombre = this.txtNombre.Text;
            j.Capacidad = int.Parse(this.txtCap.Text);
            jc.PoseeCinturon1 = this.chkCinturon.Checked;
            j.Tipojuego = (TipoJuego)Enum.Parse(typeof(TipoJuego), this.ddlTipoJuego.SelectedValue);
            je.Altura = int.Parse(this.txtAltura.Text);
            je.Riesgo1 = (NivelDeRiesgo)Enum.Parse(typeof(NivelDeRiesgo), this.ddlRiesgo.SelectedValue);


            SessionJuego.Add(j);
            SessionJuego.Add(jc);
            SessionJuego.Add(je);

            lblResumen.Text = "La persona ha sido agregada correctamente";
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