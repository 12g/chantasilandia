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
            int id = int.Parse(txtId.Text);

            if (id == 0)
            {
                lblMensaje.Text = "id no puede estar vacio";

            }
            else
            {
                Ticket referencia = new Ticket();
                referencia.Id = id;
                if (referencia.BuscarUno())
                {
                    btnBuscar_Click(sender, e);
                    lblMensaje.Text = "Id de ticket ya existe";
                }
                else
                {
                    Ticket tc = new Ticket();

                    tc.Id = int.Parse(txtId.Text);
                    tc.Valor = int.Parse(txtValor.Text);

                    if (tc.BuscarUno())
                    {
                        referencia.BuscarUno();
                        txtId.Text = referencia.Id.ToString();
                        lblMensaje.Text = "Ticket creado exitosamente";
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
        }



        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtValor.Text = "";

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
                Ticket tc = new Ticket();
                bool success;

                tc.Id = filtro;
                if (success = tc.BuscarUno())
                {
                    txtId.Text = tc.Id.ToString();
                    txtValor.Text = tc.Valor.ToString();

                }
                else
                {
                    btnLimpiar_Click(sender, e);
                    filtro = int.Parse(txtId.Text);
                    lblMensaje.Text = "El juego no pudo ser encontrado.";
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
               
