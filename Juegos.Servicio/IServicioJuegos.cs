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
        Juegos.Negocio.Modelo.Juego BuscarUnoJuegoServicio(int id);
        [OperationContract]
        Juegos.Negocio.Modelo.Juego BuscarUnoJuegoByNombreServicio(String nombre);



        [OperationContract]
        bool CrearJuegoCasualServicio(string nombre, bool requiereSupervision, bool poseeCinturon);

        [OperationContract]
        bool UpdateJuegoCasualServicio(int id, string nombre, bool requiereSupervision, bool poseeCinturon);

        [OperationContract]
        bool DeleteJuegoCasualServicio(int id);

        [OperationContract]
        Juegos.Negocio.Modelo.JuegoCasual BuscarUnoJuegoCasualServicio(int id);

        [OperationContract]
        Juegos.Negocio.Modelo.JuegoCasual BuscarUnoJuegoCasualByNombreServicio(String nombre);



        [OperationContract]
        bool CrearJuegoExtremoServicio(string nombre, int altura, int nivelRiesgo);

        [OperationContract]
        bool UpdateJuegoExtremoServicio(int id, string nombre, int altura, int nivelRiesgo);

        [OperationContract]
        bool DeleteJuegoExtremoServicio(int id);

        [OperationContract]
        Juegos.Negocio.Modelo.JuegoExtremo BuscarUnoJuegoExtremoServicio(int id);

        [OperationContract]
        Juegos.Negocio.Modelo.JuegoExtremo BuscarUnoJuegoExtremoByNombreServicio(String nombre);
    }
}
