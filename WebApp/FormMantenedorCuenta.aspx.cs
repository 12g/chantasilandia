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
            int id = int.Parse(txtId.Text);

            if (id == 0)
            {
                lblMensaje.Text = "id no puede estar vacio";

            }
            else
            {
                Cuenta referencia = new Cuenta();
                referencia.Id = id;
                if (referencia.BuscarUno())
                {
                    btnBuscar_Click(sender, e);
                    lblMensaje.Text = "Id de ticket ya existe";
                }
                else
                {
                    Cuenta ct = new Cuenta();

                    ct.Id = int.Parse(txtId.Text);
                    ct.Usuario = txtUser.Text;
                    ct.Contraseña = txtPass.Text;

                    if (ct.BuscarUno())
                    {
                        referencia.BuscarUno();
                        txtId.Text = referencia.Id.ToString();
                        lblMensaje.Text = "Ticket creado exitosamente";
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
            int filtro = int.Parse(txtId.Text);

            if (filtro == int.Parse(""))
            {
                lblMensaje.Text = "Debe ingresar un id";
            }
            else
            {
                Cuenta ct = new Cuenta();
                bool success;

                ct.Id = filtro;
                if (success = ct.BuscarUno())
                {
                    txtId.Text = ct.Id.ToString();
                    txtUser.Text = ct.Usuario.ToString();
                    txtPass.Text = ct.Contraseña.ToString();

                }
                else
                {
                    btnLimpiar_Click(sender, e);
                    filtro = int.Parse(txtId.Text);
                    lblMensaje.Text = "La cuenta no pudo ser encontrada.";
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
                Ticket tk = new Ticket();
                tk.Id = int.Parse(txtId.Text);
                success = tk.Delete();

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
            int id = int.Parse(txtId.Text);


            if (id == int.Parse(""))
            {
                lblMensaje.Text = "Debe ingresar un id.";
            }

            else
            {
                bool success = false;


                Cuenta referencia = new Cuenta();
                referencia.Id = int.Parse(txtId.Text);
                referencia.BuscarUno();


                Cuenta tk = new Cuenta
                {
                    Id = referencia.Id,
                    Usuario = txtUser.Text,
                    Contraseña = txtPass.Text

                };

                success = tk.Update();
            }
        }
    }
}
    
