using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Juegos.Negocio.Modelo;

namespace Juegos.Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioTickets" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioTickets
    {
        [OperationContract]
        Ticket BuscarUnoTicketServicio(int id);

        [OperationContract]
        bool CrearTicketServicio(int id, int valor);

        [OperationContract]
        bool DeleteTicketServicio(int id);

        [OperationContract]
        bool UpdateTicketServicio(int id, int valor);
    }
}
