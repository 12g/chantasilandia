using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Juegos.Negocio.Modelo;

namespace Juegos.Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioTickets" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioTickets.svc o ServicioTickets.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioTickets : IServicioTickets
    {
        public Ticket BuscarUnoTicketServicio(int id)
        {
            Ticket ticket = new Ticket();
            ticket.Id = id;
            ticket.BuscarUno();

            return ticket;
        }

        public bool CrearTicketServicio(int id, int valor)
        {
            Ticket ticket = new Ticket();
            ticket.Id = id;
            ticket.Valor = valor;
            return ticket.Crear();
        }

        public bool DeleteTicketServicio(int id)
        {
            Ticket ticket = new Ticket();
            ticket.Id = id;
            return ticket.Delete();
        }

        public bool UpdateTicketServicio(int id, int valor)
        {
            Ticket ticket = new Ticket();
            ticket.Id = id;
            ticket.Valor = valor;
            return ticket.Update();
        }
    }
}
