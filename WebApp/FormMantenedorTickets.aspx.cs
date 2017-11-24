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
            String id = txtId.Text.Trim();
            String precio = txtValor.Text.Trim();

            if (id == "" || precio == "")
            {
                lblMensaje.Text = "Debe asignar un ID y un precio.";
            }
            else
            {
                SvcTickets.ServicioTicketsClient servicio = new SvcTickets.ServicioTicketsClient();
                bool creado = servicio.CrearTicketServicio(int.Parse(id), int.Parse(precio));

                if (creado)
                {
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
            String id = txtId.Text.Trim();

            if (id == "")
            {
                lblMensaje.Text = "Debe ingresar un número ID del ticket.";
            }
            else
            {
                SvcTickets.ServicioTicketsClient servicio = new SvcTickets.ServicioTicketsClient();
                Juegos.Negocio.Modelo.Ticket ticket = servicio.BuscarUnoTicketServicio(int.Parse(id));
                bool encontrado = (ticket != null);
                
                if (encontrado)
                {
                    txtId.Text = ticket.Id.ToString();
                    txtValor.Text = ticket.Valor.ToString();
                    lblMensaje.Text = "Ticket encontrado.";
                }
                else
                {
                    lblMensaje.Text = "No existe un ticket con este ID.";
                }

                btnActualizar.Enabled = encontrado;
                btnEliminar.Enabled = encontrado;
                btnAgregar.Enabled = !encontrado;

            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            String id = txtId.Text;

            if (id == "null")
            {
                lblMensaje.Text = "Debe ingresar un ID.";
            }
            else
            {
                SvcTickets.ServicioTicketsClient servicio = new SvcTickets.ServicioTicketsClient();
                bool encontrado = (servicio.BuscarUnoTicketServicio(int.Parse(id)) != null);

                if (encontrado)
                {
                    if (servicio.DeleteTicketServicio(int.Parse(id)))
                    {
                        btnLimpiar_Click(sender, e);
                        lblMensaje.Text = "Eliminación exitosa.";
                    }
                    else
                    {
                        lblMensaje.Text = "No se pudo eliminar el juego.";
                    }
                }
                else
                {
                    lblMensaje.Text = "No se pudo encontrar el juego.";
                }
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {

            String id = txtId.Text;
            String valor = txtValor.Text;


            if (id == "" || valor == "")
            {
                lblMensaje.Text = "Debe ingresar un ID y un precio.";
            }

            else
            {
                SvcTickets.ServicioTicketsClient servicio = new SvcTickets.ServicioTicketsClient();
                
                if (servicio.UpdateTicketServicio(int.Parse(id), int.Parse(valor)))
                {
                    lblMensaje.Text = "Ticket actualizado.";
                }
                else
                {
                    lblMensaje.Text = "El ticket no pudo ser actualizado.";
                }
            }
        }
    }
}

