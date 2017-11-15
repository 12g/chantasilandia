using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class FormMantenedorJuegos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddTipoJuego_SelectedIndexChanged(sender, e); //deshabilitar los controles segun corresponda
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNombre.Text = "";
            ddTipoJuego.SelectedValue = "";
            ddNivelRiesgo.SelectedValue = "";
            txtAltura.Text = "";
            chkPoseeCinturon.Checked = false;
            chkRequiereSupervision.Checked = false;
            btnBorrar.Enabled = false;
            btnActualizar.Enabled = false;
            btnAgregar.Enabled = true;
            ddTipoJuego_SelectedIndexChanged(sender, e);
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text.Trim();

            if (nombre == "")
            {
                lblMensaje.Text = "El nombre no debe estar en blanco.";
            }
            else if (ddTipoJuego.SelectedValue == "")
            {
                lblMensaje.Text = "Debe elegir un tipo de juego.";
            }
            else
            {
                SvcJuegos.ServicioJuegosClient servicio = new SvcJuegos.ServicioJuegosClient();
                bool tipoCasual = ddTipoJuego.SelectedValue == "1";
                Juegos.Negocio.Modelo.Juego referencia = servicio.BuscarUnoJuegoByNombreServicio(nombre);
                if (referencia != null)
                {
                    btnBuscar_Click(sender, e);
                    lblMensaje.Text = "Ya existe un juego con este nombre.";
                }
                else if (!tipoCasual)
                {

                    bool creacion = servicio.CrearJuegoExtremoServicio(txtNombre.Text, int.Parse(txtAltura.Text), ddNivelRiesgo.SelectedIndex);
                    
                    if (creacion)
                    {
                        Juegos.Negocio.Modelo.JuegoExtremo juego = servicio.BuscarUnoJuegoExtremoByNombreServicio(txtNombre.Text);
                        txtID.Text = juego.Id.ToString();
                        lblMensaje.Text = "El juego extremo fue creado exitosamente";
                        btnActualizar.Enabled = true;
                        btnBorrar.Enabled = true;
                        btnAgregar.Enabled = false;
                    }
                    else
                    {
                        lblMensaje.Text = "La creación del juego extremo falló.";
                    }
                }
                else
                {
                    bool creacion = servicio.CrearJuegoCasualServicio(txtNombre.Text, chkRequiereSupervision.Checked, chkPoseeCinturon.Checked);

                    if (creacion)
                    {
                        lblMensaje.Text = "El juego casual fue creado exitosamente";
                        btnActualizar.Enabled = true;
                        btnBorrar.Enabled = true;
                        btnAgregar.Enabled = false;
                    }
                    else
                    {
                        lblMensaje.Text = "La creación del juego casual falló.";
                    }
                }
            }
        }

        protected void ddTipoJuego_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool tipoCasual = ddTipoJuego.SelectedValue == "1";
            bool tipoExtremo = ddTipoJuego.SelectedValue == "0";

            ddNivelRiesgo.Enabled = tipoExtremo;
            txtAltura.Enabled = tipoExtremo;
            chkPoseeCinturon.Enabled = tipoCasual;
            chkRequiereSupervision.Enabled = tipoCasual;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            String filtro = txtNombre.Text.Trim();

            if (filtro == "")
            {
                lblMensaje.Text = "Debe ingresar un nombre.";
            }
            else
            {
                SvcJuegos.ServicioJuegosClient servicio = new SvcJuegos.ServicioJuegosClient();
                Juegos.Negocio.Modelo.Juego juego = servicio.BuscarUnoJuegoByNombreServicio(filtro);
                bool encontrado = (juego != null);

                if (encontrado)
                {
                    txtID.Text = juego.Id.ToString(); //de este nombre sacamos el ID y lo mostramos
                    txtNombre.Text = juego.Nombre;
                    ddTipoJuego.SelectedValue = (juego.EsTipoCasual) ? "1" : "0";
                    if (juego.EsTipoCasual)
                    {
                        Juegos.Negocio.Modelo.JuegoCasual subtipo = servicio.BuscarUnoJuegoCasualByNombreServicio(filtro); //para ubicar la subclase con datos especificos usamos el ID
                        chkPoseeCinturon.Checked = subtipo.PoseeCinturon;
                        chkRequiereSupervision.Checked = subtipo.RequiereSupervision;
                    }
                    else
                    {
                        Juegos.Negocio.Modelo.JuegoExtremo subtipo = servicio.BuscarUnoJuegoExtremoByNombreServicio(filtro); //para ubicar la subclase con datos especificos usamos el ID
                        ddNivelRiesgo.SelectedValue = subtipo.NivelRiesgo.ToString();
                        txtAltura.Text = subtipo.Altura.ToString();
                    }
                }
                else
                {
                    BtnLimpiar_Click(sender, e);
                    txtNombre.Text = filtro;
                    lblMensaje.Text = "El juego no pudo ser encontrado.";
                }

                btnActualizar.Enabled = encontrado;
                btnBorrar.Enabled = encontrado;
                btnAgregar.Enabled = !encontrado;
                ddTipoJuego_SelectedIndexChanged(sender, e);
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text.Trim();
            String tipo = ddTipoJuego.SelectedValue;

            if (nombre == "")
            {
                lblMensaje.Text = "Debe ingresar un nombre.";
            }
            else if (tipo == "")
            {
                lblMensaje.Text = "Debe ingresar un tipo";
            }
            else
            {
                SvcJuegos.ServicioJuegosClient servicio = new SvcJuegos.ServicioJuegosClient();
                Juegos.Negocio.Modelo.Juego referencia = servicio.BuscarUnoJuegoServicio(int.Parse(txtID.Text));
                bool encontrado = (referencia != null);

                if (encontrado)
                {
                    String riesgo = ddNivelRiesgo.SelectedValue;
                    String altura = txtAltura.Text;
                    bool actualizado = false;
                    if (referencia.EsTipoCasual)
                    {
                        //no realizamos validaciones porque los datos del juego casual son checkboxes

                        if (tipo == "1") //si la seleccion del dropdown dice casual
                        {
                            actualizado = servicio.UpdateJuegoCasualServicio(
                                referencia.Id, 
                                txtNombre.Text, 
                                chkRequiereSupervision.Checked, 
                                chkPoseeCinturon.Checked
                            );
                        }
                        else //pero si el formulario ahora dice extremo...
                        {
                            //eliminamos el viejo que era casual
                            bool borrado = servicio.DeleteJuegoCasualServicio(referencia.Id); 
                            
                            if (borrado && riesgo != "" && altura != "")
                            {
                                //no conserva ID con este metodo, deberia crear otro que acepte el parametro para darle el ID
                                actualizado = servicio.CrearJuegoExtremoServicio(
                                    txtNombre.Text,
                                    int.Parse(altura),
                                    int.Parse(riesgo)
                                );
                            }
                            else
                            {
                                actualizado = false;
                            }
                        }
                    }
                    else
                    {
                        if (riesgo == "" && altura == "")
                        {
                            lblMensaje.Text = "Debe rellenar todos los campos del formulario.";
                        }
                        else
                        {

                            if (tipo == "0") //si el formulario dice que sea extremo tambien
                            {
                                actualizado = servicio.UpdateJuegoExtremoServicio(
                                    referencia.Id,
                                    txtNombre.Text,
                                    int.Parse(altura),
                                    int.Parse(riesgo)
                                );
                            }
                            else
                            {
                                bool borrado = servicio.DeleteJuegoExtremoServicio(referencia.Id);
                                
                                if (borrado)
                                {
                                    actualizado = servicio.CrearJuegoExtremoServicio(
                                        txtNombre.Text,
                                        int.Parse(altura),
                                        int.Parse(riesgo)
                                    );
                                }
                                else
                                {
                                    actualizado = false;
                                }
                            }
                        }
                    }
                    lblMensaje.Text = "Actualización de datos completada.";
                }
                else
                {
                    lblMensaje.Text = "Fallo al encontrar juego original .";
                }

            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            SvcJuegos.ServicioJuegosClient servicio = new SvcJuegos.ServicioJuegosClient();
            bool eliminado = false;
            
            Juegos.Negocio.Modelo.Juego juego = servicio.BuscarUnoJuegoServicio(int.Parse(txtID.Text));
            if (juego != null) //sacamos la informacion de la base de datos misma
            {
                if (!juego.EsTipoCasual)
                {
                    eliminado = servicio.DeleteJuegoExtremoServicio(juego.Id);
                }
                else
                {
                    eliminado = servicio.DeleteJuegoCasualServicio(juego.Id);
                }
            }

            if (eliminado)
            {
                BtnLimpiar_Click(sender, e);
                lblMensaje.Text = "Eliminación exitosa.";
            }
            else
            {
                lblMensaje.Text = "No se pudo eliminar el juego.";
            }
        }
    }
}