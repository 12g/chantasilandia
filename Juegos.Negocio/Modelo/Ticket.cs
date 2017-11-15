using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juegos.Negocio.Modelo
{
    public class Ticket
    {
        #region campos
        private int _id;
        private int _valor;
        #endregion

        #region propiedades
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public int Valor
        {
            get
            {
                return _valor;
            }

            set
            {
                _valor = value;
            }
        }
        #endregion

        public Ticket()
        {
            this.Init();
        }

        public Ticket(int id, int valor)
        {
            this.Id = id;
            this.Valor = valor;
        }

        private void Init()
        {
            this.Id = -1;
            this.Valor = 0;
        }

        public bool Crear()
        {
            try
            {
                Juegos.DALC.Tickets ticket = new Juegos.DALC.Tickets
                {
                    ticketID = this.Id,
                    ticketPrecio = this.Valor
                };

                CommonBC.Modelo.Tickets.Add(ticket);
                CommonBC.Modelo.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                var consulta = CommonBC.Modelo.Tickets.First
                    (aux => aux.ticketID == this.Id);

                CommonBC.Modelo.Tickets.Remove(consulta);

                CommonBC.Modelo.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                var consulta = CommonBC.Modelo.Tickets.First
                    (aux => aux.ticketID == this.Id);

                consulta.ticketID = this.Id;
                consulta.ticketPrecio = this.Valor;
                CommonBC.Modelo.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool BuscarUno()
        {
            try
            {
                var consulta = CommonBC.Modelo.Tickets.First
                    (aux => aux.ticketID == this.Id);

                this.Id = consulta.ticketID;
                this.Valor = consulta.ticketPrecio;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
