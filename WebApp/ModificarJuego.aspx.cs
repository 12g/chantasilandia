using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class ModificarJuego : System.Web.UI.Page
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
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            this.lblMensaje.Text = string.Empty;

            if (!IsPostBack)
            {
                ddlRiesgo.DataSource = Enum.GetNames(typeof(NivelDeRiesgo));
                ddlRiesgo.DataBind();

                ddlTipoJuego.DataSource = Enum.GetNames(typeof(TipoJuego));
                ddlTipoJuego.DataBind();
            }

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Juego j = new Juego();
            JuegoCasual jc = new JuegoCasual();
            JuegoExtremo je = new JuegoExtremo();
            j.Id = txtId.Text;
            j.Nombre = txtNombre.Text;
            j.Tipojuego = (TipoJuego)Enum.Parse(typeof(TipoJuego), this.ddlTipoJuego.SelectedValue);
            je.Riesgo1 = (NivelDeRiesgo)Enum.Parse(typeof(NivelDeRiesgo), this.ddlRiesgo.SelectedValue);
            j.Capacidad = int.Parse(txtCapacidad.Text);
            jc.PoseeCinturon = chkPoseeCinuron.Checked;
            je.Altura = int.Parse(txtAltura.Text);
            jc.RequiereSupervision = chkSupervision.Checked;

            string id = this.txtIdBsc.Text;


            int aux = 0;
            foreach (Juego j1 in ListaJuegos)
            {
                aux++;

                if (j1.Id == id)
                {
                    break;
                }
            }

            ListaJuegos[aux] = j;

            lblMensaje.Text = "Juego Modificado";
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = this.txtIdBsc.Text;

            foreach (Juego j1 in ListaJuegos)
            {
                if (j1.Id == id)
                {
                    
                    this.txtId.Text = j1.Id;
                    this.txtNombre.Text = j1.Nombre;

                    if (j1.Tipojuego.ToString() == "JuegoCasual")
                        this.ddlTipoJuego.SelectedIndex = 0;
                    else
                        this.ddlTipoJuego.SelectedIndex = 1;

                    this.txtCapacidad.Text = j1.Capacidad.ToString();


                    JuegoCasual jc1 = new JuegoCasual();


                    this.chkPoseeCinuron.Checked = jc1.PoseeCinturon;
                    this.chkSupervision.Checked = jc1.RequiereSupervision;



                    JuegoExtremo je1 = new JuegoExtremo();

                    this.txtAltura.Text = je1.Altura.ToString();
                    if (je1.Riesgo1.ToString() == "Alto")
                        this.ddlRiesgo.SelectedIndex = 0;
                    else
                        this.ddlRiesgo.SelectedIndex = 1;


                    lblMensaje.Text = "Datos cargados correctamente";


                }
            }
        }
    }
}