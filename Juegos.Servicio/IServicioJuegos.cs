using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Juegos.Servicio
{
    [ServiceContract]
    public interface IServicioJuegos
    {

        [OperationContract]
        bool CrearJuegoCasualServicio(string nombre, bool requiereSupervision, bool poseeCinturon);

        [OperationContract]
        bool UpdateJuegoCasualServicio(int id, string nombre, bool requiereSupervision, bool poseeCinturon);

        [OperationContract]
        bool DeleteJuegoCasualServicio(int id);

        [OperationContract]
        bool BuscarUnoJuegoCasualServicio(int id);

    }
}
