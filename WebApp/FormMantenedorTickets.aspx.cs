using Juegos.Negocio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class FormMantenedorTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            String precio = txtValor.Text.Trim();

            if (precio == "")
            {
                lblMensaje.Text = "Debe asignar un precio.";
            }
            else
            {
                Ticket ticket = new Ticket();
                ticket.Valor = int.Parse(precio);

                if (ticket.Crear())
                {
                    ticket.BuscarUno();
                    txtId.Text = ticket.Id.ToString();
                    lblMensaje.Text = "Ticket creado exitosamente.";
                    btnActualizar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnAgregar.Enabled = false;
                }
                else
                {

                    lblMensaje.Text = "Ticket no pudo ser creado";
                }
            }
        }



        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtValor.Text = "";

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            String filtro = txtId.Text.Trim();

            if (filtro == "")
            {
                lblMensaje.Text = "Debe ingresar un número ID del ticket.";
            }
            else
            {
                Ticket tc = new Ticket();
                bool success;

                tc.Id = int.Parse(filtro);
                if (success = tc.BuscarUno())
                {
                    txtId.Text = tc.Id.ToString();
                    txtValor.Text = tc.Valor.ToString();
                    lblMensaje.Text = "Ticket encontrado.";
                }
                else
                {
                    lblMensaje.Text = "No existe un ticket con este ID.";
                }

                btnActualizar.Enabled = success;
                btnEliminar.Enabled = success;
                btnAgregar.Enabled = !success;

            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            bool success = false;
            Ticket tc = new Ticket();

            tc.Id = int.Parse(txtId.Text);
            if (tc.BuscarUno())
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
                lblMensaje.Text = "No se pudo eliminar el juego.";
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


                //este metodo asume que el ID se muestra en el formulario
                Ticket referencia = new Ticket();
                referencia.Id = int.Parse(txtId.Text);
                referencia.BuscarUno();


                Ticket tk = new Ticket
                {
                    Id = referencia.Id,
                    Valor = int.Parse(txtValor.Text),

                };

                success = tk.Update();
            }
        }
    }
}

