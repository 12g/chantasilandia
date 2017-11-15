using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Juegos.Negocio.Modelo;

namespace Juegos.Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IServicioJuegos
    {

        public Juego BuscarUnoJuegoServicio(int id)
        {
            try
            {
                Juego juego = new Juego
                {
                    Id = id
                };

                juego.BuscarUno();
                return juego;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Juego BuscarUnoJuegoByNombreServicio(String nombre)
        {
            try
            {
                Juego juego = new Juego
                {
                    Nombre = nombre
                };

                juego.BuscarUno();
                return juego;
            }
            catch (Exception)
            {
                return null;
            }
        }

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

        public JuegoCasual BuscarUnoJuegoCasualServicio(int id)
        {
            try
            {
                JuegoCasual juego = new JuegoCasual
                {
                    Id = id
                };

                juego.BuscarUno();
                return juego;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public JuegoCasual BuscarUnoJuegoCasualByNombreServicio(String nombre)
        {
            try
            {
                JuegoCasual juego = new JuegoCasual
                {
                    Nombre = nombre
                };

                juego.BuscarUno();
                return juego;
            }
            catch (Exception)
            {
                return null;
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



        public bool CrearJuegoExtremoServicio(string nombre, int altura, int nivelRiesgo)
        {
            try
            {
                JuegoExtremo juego = new JuegoExtremo
                {
                    Nombre = nombre,
                    EsTipoCasual = false,
                    Altura = altura,
                    NivelRiesgo = nivelRiesgo
                };

                return juego.Update();
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateJuegoExtremoServicio(int id, string nombre, int altura, int nivelRiesgo)
        {
            try
            {
                JuegoExtremo juego = new JuegoExtremo
                {
                    Id = id,
                    Nombre = nombre,
                    EsTipoCasual = false,
                    Altura = altura,
                    NivelRiesgo = nivelRiesgo
                };

                return juego.Update();
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteJuegoExtremoServicio(int id)
        {
            try
            {
                JuegoExtremo juego = new JuegoExtremo
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

        public JuegoExtremo BuscarUnoJuegoExtremoByNombreServicio(String nombre)
        {
            try
            {
                JuegoExtremo juego = new JuegoExtremo
                {
                    Nombre = nombre
                };

                juego.BuscarUno();
                return juego;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public JuegoExtremo BuscarUnoJuegoExtremoServicio(int id)
        {
            try
            {
                JuegoExtremo juego = new JuegoExtremo
                {
                    Id = id
                };

                juego.BuscarUno();
                return juego;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
