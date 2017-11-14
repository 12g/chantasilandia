using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Juegos.Negocio;
using Juegos.Negocio.Modelo;
using Juegos.Negocio.Colecciones;

namespace Juegos.Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioJuegos : IServicioJuegos
    {

        public bool CrearJuegoCasualServicio(string nombre, bool requiereSupervision, bool poseeCinturon)
        {
            try
            {
                JuegoCasual juego = new JuegoCasual
                {
                    Nombre = nombre,
                    EsTipoCasual = true,
                    RequiereSupervision = requiereSupervision,
                    PoseeCinturon = poseeCinturon
                };
                
                return juego.Crear();
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool BuscarUnoJuegoCasualServicio(int id)
        {
            try
            {
                JuegoCasual juego = new JuegoCasual
                {
                    Id = id
                };

                return juego.BuscarUno();
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteJuegoCasualServicio(int id)
        {
            try
            {
                JuegoCasual juego = new JuegoCasual
                {
                    Id = id
                };

                return juego.Delete();
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateJuegoCasualServicio(int id, string nombre, bool requiereSupervision, bool poseeCinturon)
        {
            try
            {
                JuegoCasual juego = new JuegoCasual
                {
                    Id = id,
                    Nombre = nombre,
                    EsTipoCasual = true,
                    RequiereSupervision = requiereSupervision,
                    PoseeCinturon = poseeCinturon
                };

                return juego.Update();
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
