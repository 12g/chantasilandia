using Juegos.Negocio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class FormMantenedorCuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            String user = txtUser.Text.Trim();
            
            Cuenta referencia = new Cuenta();
            referencia.Usuario = user;
            if (referencia.BuscarUno())
            {
                btnBuscar_Click(sender, e);
                lblMensaje.Text = "Esta cuenta ya existe.";
            }
            else
            {
                String password = txtPass.Text;

                if (password.Length < 4)
                {
                    lblMensaje.Text = "La contraseña no puede poseer menos de 4 caracteres";
                }
                else
                {
                    referencia.Contraseña = password;

                    if (referencia.Crear())
                    {
                        referencia.BuscarUno();
                        txtId.Text = referencia.Id.ToString();
                        lblMensaje.Text = "Cuenta creada exitosamente";
                        btnActualizar.Enabled = true;
                        btnBorrar.Enabled = true;
                        btnAgregar.Enabled = false;
                    }
                    else
                    {

                        lblMensaje.Text = "Ticket no pudo ser creado";
                    }
                }
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtUser.Text.Trim();

            if (filtro == "")
            {
                lblMensaje.Text = "Debe ingresar un nombre";
            }
            else
            {
                bool success;
                Cuenta ct = new Cuenta();
                ct.Usuario = filtro;

                if (success = ct.BuscarUno())
                {
                    txtId.Text = ct.Id.ToString();
                    txtUser.Text = ct.Usuario;
                    txtPass.Text = ct.Contraseña;
                    lblMensaje.Text = "Los datos de la cuenta fueron cargados";
                }
                else
                {
                    lblMensaje.Text = "No existe una cuenta con este nombre.";
                }

                btnActualizar.Enabled = success;
                btnBorrar.Enabled = success;
                btnAgregar.Enabled = !success;

            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            bool success = false;
            Cuenta ct = new Cuenta();
            ct.Id = int.Parse(txtId.Text);

            if (ct.BuscarUno())
            {
                success = ct.Delete();
            }

            if (success)
            {
                btnLimpiar_Click(sender, e);
                lblMensaje.Text = "Eliminación exitosa.";
            }
            else
            {
                lblMensaje.Text = "No se pudo eliminar la cuenta.";
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            String usuario = txtUser.Text.Trim();
            String password = txtPass.Text.Trim();

            if (usuario == "")
            {
                lblMensaje.Text = "Debe ingresar un nombre de usuario.";
            }
            else if (password == "")
            {
                lblMensaje.Text = "Debe ingresar una contraseña.";
            }
            else { 
                Cuenta cuenta = new Cuenta { 
                    Id = int.Parse(txtId.Text),
                    Usuario = usuario,
                    Contraseña = password
                };

                if (cuenta.Update())
                {
                    lblMensaje.Text = "Datos de la cuenta actualizados exitosamente.";
                }
                else
                {
                    lblMensaje.Text = "No se pudo actualizar la cuenta.";
                }
            }
        }
    }
}

