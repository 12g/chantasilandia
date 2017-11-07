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
            DdTipoJuego_SelectedIndexChanged(sender, e); //deshabilitar los controles segun corresponda
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtID.Text = "";
            TxtNombre.Text = "";
            DdTipoJuego.SelectedValue = "";
            DdNivelRiesgo.SelectedValue = "";
            TxtAltura.Text = "";
            ChkPoseeCinturon.Checked = false;
            ChkRequiereSupervision.Checked = false;
            BtnBorrar.Enabled = false;
            BtnActualizar.Enabled = false;
            BtnAgregar.Enabled = true;
            DdTipoJuego_SelectedIndexChanged(sender, e);
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            String nombre = TxtNombre.Text;
            bool tipoCasual = DdTipoJuego.SelectedValue == "1";

            if (nombre == "")
            {
                LblMensaje.Text = "El nombre no debe estar en blanco.";
            }
            else
            {
                Juego referencia = new Juego();
                referencia.Nombre = nombre;
                if (referencia.BuscarUno())
                {
                    BtnBuscar_Click(sender, e);
                    LblMensaje.Text = "Ya existe un juego con este nombre.";
                }
                else if (!tipoCasual)
                {
                    JuegoExtremo jExtremo = new JuegoExtremo();

                    jExtremo.Nombre = TxtNombre.Text;
                    jExtremo.NivelRiesgo = DdNivelRiesgo.SelectedIndex;
                    jExtremo.Altura = int.Parse(TxtAltura.Text);

                    if (jExtremo.Crear())
                    {
                        referencia.BuscarUno();
                        TxtID.Text = referencia.Id.ToString();
                        LblMensaje.Text = "El juego extremo fue creado exitosamente";
                        BtnActualizar.Enabled = true;
                        BtnBorrar.Enabled = true;
                        BtnAgregar.Enabled = false;
                    }
                    else
                    {
                        LblMensaje.Text = "La creación del juego extremo falló.";
                    }
                }
                else
                {
                    JuegoCasual jCasual = new JuegoCasual();

                    jCasual.Nombre = TxtNombre.Text;
                    jCasual.PoseeCinturon = ChkPoseeCinturon.Checked;
                    jCasual.RequiereSupervision = ChkRequiereSupervision.Checked;

                    if (jCasual.Crear())
                    {
                        referencia.BuscarUno();
                        TxtID.Text = referencia.Id.ToString();
                        LblMensaje.Text = "El juego casual fue creado exitosamente";
                        BtnActualizar.Enabled = true;
                        BtnBorrar.Enabled = true;
                        BtnAgregar.Enabled = false;
                    }
                    else
                    {
                        LblMensaje.Text = "La creación del juego casual falló.";
                    }
                }
            }
        }


        protected void DdTipoJuego_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool tipoCasual = DdTipoJuego.SelectedValue == "1";
            bool tipoExtremo = DdTipoJuego.SelectedValue == "0";

            DdNivelRiesgo.Enabled = tipoExtremo;
            TxtAltura.Enabled = tipoExtremo;
            ChkPoseeCinturon.Enabled = tipoCasual;
            ChkRequiereSupervision.Enabled = tipoCasual;
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            String filtro = TxtNombre.Text;

            if (filtro == "")
            {
                LblMensaje.Text = "Debe ingresar un nombre.";
            }
            else
            {
                Juego juego = new Juego();
                bool success;

                juego.Nombre = filtro; //para buscar un juego a nivel general, usamos el nombre
                if (success = juego.BuscarUno())
                {
                    TxtID.Text = juego.Id.ToString(); //de este nombre sacamos el ID y lo mostramos
                    TxtNombre.Text = juego.Nombre;
                    DdTipoJuego.SelectedValue = (juego.EsTipoCasual) ? "1" : "0";
                    if (juego.EsTipoCasual)
                    {
                        JuegoCasual subtipo = new JuegoCasual();
                        subtipo.Id = juego.Id;
                        success = subtipo.BuscarUno(); //para ubicar la subclase con datos especificos usamos el ID
                        ChkPoseeCinturon.Checked = subtipo.PoseeCinturon;
                        ChkRequiereSupervision.Checked = subtipo.RequiereSupervision;
                    }
                    else
                    {
                        JuegoExtremo subtipo = new JuegoExtremo();
                        subtipo.Id = juego.Id;
                        success = subtipo.BuscarUno(); //para ubicar la subclase con datos especificos usamos el ID
                        DdNivelRiesgo.SelectedValue = subtipo.NivelRiesgo.ToString();
                        TxtAltura.Text = subtipo.Altura.ToString();
                    }

                    if (!success)
                    {
                        BtnLimpiar_Click(sender, e);
                        TxtNombre.Text = filtro;
                        LblMensaje.Text = "Hubo un problema al cargar la información (el juego no se encuentra en tabla subtipo correspondiente).";
                    }
                    else
                    {
                        LblMensaje.Text = "";
                    }
                }
                else
                {
                    BtnLimpiar_Click(sender, e);
                    TxtNombre.Text = filtro;
                    LblMensaje.Text = "El juego no pudo ser encontrado.";
                }

                BtnActualizar.Enabled = success;
                BtnBorrar.Enabled = success;
                BtnAgregar.Enabled = !success;
                DdTipoJuego_SelectedIndexChanged(sender, e);
            }
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            String nombre = TxtNombre.Text;
            String tipo = DdTipoJuego.SelectedValue;

            if (nombre == "")
            {
                LblMensaje.Text = "Debe ingresar un nombre.";
            }
            else if (tipo == "")
            {
                LblMensaje.Text = "Debe ingresar un tipo";
            }
            else
            {
                bool success = false;


                //este metodo asume que el ID se muestra en el formulario
                Juego referencia = new Juego();
                referencia.Id = int.Parse(TxtID.Text);
                referencia.BuscarUno();

                if (referencia.EsTipoCasual)
                {
                    JuegoCasual juego = new JuegoCasual
                    {
                        Id = referencia.Id,
                        Nombre = TxtNombre.Text,
                        RequiereSupervision = ChkRequiereSupervision.Checked,
                        PoseeCinturon = ChkPoseeCinturon.Checked
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
                            Nombre = TxtNombre.Text,
                            Altura = int.Parse(TxtAltura.Text),
                            NivelRiesgo = int.Parse(DdNivelRiesgo.SelectedValue)
                        };
                        success = nuevo.Crear(); //y creamos el nuevo casual
                    }
                }
                else
                {
                    String riesgo = DdNivelRiesgo.SelectedValue;
                    String altura = TxtAltura.Text;

                    if (riesgo == "")
                    {
                        LblMensaje.Text = "Debe seleccionar un nivel de riesgo.";
                    }
                    else if (altura == "")
                    {
                        LblMensaje.Text = "Debe indicar la altura mínima para este juego."
                    }
                    else
                    {
                        JuegoExtremo juego = new JuegoExtremo
                        {
                            Id = referencia.Id,
                            Nombre = TxtNombre.Text,
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
                                Nombre = TxtNombre.Text,
                                RequiereSupervision = ChkRequiereSupervision.Checked,
                                PoseeCinturon = ChkPoseeCinturon.Checked
                            };
                            success = nuevo.Crear(); //y creamos el nuevo extremo
                        }
                    }
                }

                if (success)
                {
                    LblMensaje.Text = "Actualización de datos completada.";
                }
                else
                {
                    LblMensaje.Text = "Fallo al actualizar información.";
                }

            }
        }

        protected void BtnBorrar_Click(object sender, EventArgs e)
        {
            bool success = false;
            Juego juego = new Juego();

            juego.Id = int.Parse(TxtID.Text); //lo unico que necesitamos es el ID, pues
            if (juego.BuscarUno()) //sacamos la informacion de la base de datos misma
            {
                if (!juego.EsTipoCasual)
                {
                    JuegoExtremo subtipo = new JuegoExtremo();
                    subtipo.Id = int.Parse(TxtID.Text);
                    success = subtipo.Delete();
                }
                else
                {
                    JuegoCasual subtipo = new JuegoCasual();
                    subtipo.Id = int.Parse(TxtID.Text);
                    success = subtipo.Delete();
                }
            }

            if (success)
            {
                BtnLimpiar_Click(sender, e);
                LblMensaje.Text = "Eliminación exitosa.";
            }
            else
            {
                LblMensaje.Text = "No se pudo eliminar el juego.";
            }
        }
    }
}