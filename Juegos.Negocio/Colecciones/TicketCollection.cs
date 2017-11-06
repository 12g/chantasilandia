using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Juegos.Negocio.Modelo;

namespace Juegos.Negocio.Colecciones
{
    public class TicketCollection
    {
        public TicketCollection()
        {

        }

        private List<Ticket> GenerarListado(List<Juegos.DALC.Tickets> ticketsDALC)
        {
            List<Ticket> tickets = new List<Ticket>();

            foreach (Juegos.DALC.Tickets item in ticketsDALC)
            {
                Ticket tmp = new Ticket
                {
                    Id = item.ticketID,
                    Valor = item.ticketPrecio
                };

                tickets.Add(tmp);
            }

            return tickets;
        }

        public List<Ticket> ReadAll()
        {
            var tickets = CommonBC.Modelo.Tickets;
            return GenerarListado(tickets.ToList());
        }
    }
}
