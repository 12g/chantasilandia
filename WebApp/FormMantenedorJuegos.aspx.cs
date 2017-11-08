using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Juegos.Negocio.Modelo;

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
                bool tipoCasual = ddTipoJuego.SelectedValue == "1";
                Juego referencia = new Juego();
                referencia.Nombre = nombre;
                if (referencia.BuscarUno())
                {
                    btnBuscar_Click(sender, e);
                    lblMensaje.Text = "Ya existe un juego con este nombre.";
                }
                else if (!tipoCasual)
                {
                    JuegoExtremo jExtremo = new JuegoExtremo();

                    jExtremo.Nombre = txtNombre.Text;
                    jExtremo.NivelRiesgo = ddNivelRiesgo.SelectedIndex;
                    jExtremo.Altura = int.Parse(txtAltura.Text);

                    if (jExtremo.Crear())
                    {
                        referencia.BuscarUno();
                        txtID.Text = referencia.Id.ToString();
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
                    JuegoCasual jCasual = new JuegoCasual();

                    jCasual.Nombre = txtNombre.Text;
                    jCasual.PoseeCinturon = chkPoseeCinturon.Checked;
                    jCasual.RequiereSupervision = chkRequiereSupervision.Checked;

                    if (jCasual.Crear())
                    {
                        referencia.BuscarUno();
                        txtID.Text = referencia.Id.ToString();
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
                Juego juego = new Juego();
                bool success;

                juego.Nombre = filtro; //para buscar un juego a nivel general, usamos el nombre
                if (success = juego.BuscarUno())
                {
                    txtID.Text = juego.Id.ToString(); //de este nombre sacamos el ID y lo mostramos
                    txtNombre.Text = juego.Nombre;
                    ddTipoJuego.SelectedValue = (juego.EsTipoCasual) ? "1" : "0";
                    if (juego.EsTipoCasual)
                    {
                        JuegoCasual subtipo = new JuegoCasual();
                        subtipo.Id = juego.Id;
                        success = subtipo.BuscarUno(); //para ubicar la subclase con datos especificos usamos el ID
                        chkPoseeCinturon.Checked = subtipo.PoseeCinturon;
                        chkRequiereSupervision.Checked = subtipo.RequiereSupervision;
                    }
                    else
                    {
                        JuegoExtremo subtipo = new JuegoExtremo();
                        subtipo.Id = juego.Id;
                        success = subtipo.BuscarUno(); //para ubicar la subclase con datos especificos usamos el ID
                        ddNivelRiesgo.SelectedValue = subtipo.NivelRiesgo.ToString();
                        txtAltura.Text = subtipo.Altura.ToString();
                    }

                    if (!success)
                    {
                        BtnLimpiar_Click(sender, e);
                        txtNombre.Text = filtro;
                        lblMensaje.Text = "Hubo un problema al cargar la información (el juego no se encuentra en tabla subtipo correspondiente).";
                    }
                    else
                    {
                        lblMensaje.Text = "";
                    }
                }
                else
                {
                    BtnLimpiar_Click(sender, e);
                    txtNombre.Text = filtro;
                    lblMensaje.Text = "El juego no pudo ser encontrado.";
                }

                btnActualizar.Enabled = success;
                btnBorrar.Enabled = success;
                btnAgregar.Enabled = !success;
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
                bool success = false;


                //este metodo asume que el ID se muestra en el formulario
                Juego referencia = new Juego();
                referencia.Id = int.Parse(txtID.Text);
                referencia.BuscarUno();

                if (referencia.EsTipoCasual)
                {
                    JuegoCasual juego = new JuegoCasual
                    {
                        Id = referencia.Id,
                        Nombre = txtNombre.Text,
                        RequiereSupervision = chkRequiereSupervision.Checked,
                        PoseeCinturon = chkPoseeCinturon.Checked
                    };

                    if (tipo == "1") //si el formulario dice que sea casual tambien
                    {
                        success = juego.Update();
                    }
                    else
                    {
                        juego.Delete(); //eliminamos el viejo que era casual

                        JuegoExtremo nuevo = new JuegoExtremo
                        {
                            Id = referencia.Id,
                            Nombre = txtNombre.Text,
                            Altura = int.Parse(txtAltura.Text),
                            NivelRiesgo = int.Parse(ddNivelRiesgo.SelectedValue)
                        };
                        success = nuevo.Crear(); //y creamos el nuevo casual
                    }
                }
                else
                {
                    String riesgo = ddNivelRiesgo.SelectedValue;
                    String altura = txtAltura.Text;

                    if (riesgo == "")
                    {
                        lblMensaje.Text = "Debe seleccionar un nivel de riesgo.";
                    }
                    else if (altura == "")
                    {
                        lblMensaje.Text = "Debe indicar la altura mínima para este juego.";
                    }
                    else
                    {
                        JuegoExtremo juego = new JuegoExtremo
                        {
                            Id = referencia.Id,
                            Nombre = txtNombre.Text,
                            NivelRiesgo = int.Parse(riesgo),
                            Altura = int.Parse(altura)
                        };

                        if (tipo == "0") //si el formulario dice que sea extremo tambien
                        {
                            success = juego.Update();
                        }
                        else
                        {
                            juego.Delete(); //eliminamos el viejo que era extremo

                            JuegoCasual nuevo = new JuegoCasual
                            {
                                Id = referencia.Id,
                                Nombre = txtNombre.Text,
                                RequiereSupervision = chkRequiereSupervision.Checked,
                                PoseeCinturon = chkPoseeCinturon.Checked
                            };
                            success = nuevo.Crear(); //y creamos el nuevo extremo
                        }
                    }
                }

                if (success)
                {
                    lblMensaje.Text = "Actualización de datos completada.";
                }
                else
                {
                    lblMensaje.Text = "Fallo al actualizar información.";
                }

            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            bool success = false;
            Juego juego = new Juego();

            juego.Id = int.Parse(txtID.Text); //lo unico que necesitamos es el ID, pues
            if (juego.BuscarUno()) //sacamos la informacion de la base de datos misma
            {
                if (!juego.EsTipoCasual)
                {
                    JuegoExtremo subtipo = new JuegoExtremo();
                    subtipo.Id = int.Parse(txtID.Text);
                    success = subtipo.Delete();
                }
                else
                {
                    JuegoCasual subtipo = new JuegoCasual();
                    subtipo.Id = int.Parse(txtID.Text);
                    success = subtipo.Delete();
                }
            }

            if (success)
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