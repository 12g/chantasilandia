using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Juegos.Negocio.Modelo;

namespace Juegos.Negocio.Colecciones
{
    public class JuegoExtremoCollection
    {
        public JuegoExtremoCollection()
        {

        }

        private List<JuegoExtremo> GenerarListado(List<Juegos.DALC.JuegosExtremos> juegosDALC)
        {
            List<JuegoExtremo> juegos = new List<JuegoExtremo>();

            foreach (Juegos.DALC.JuegosExtremos item in juegosDALC)
            {
                var juego = CommonBC.Modelo.Juegos.First
                    (aux => aux.juegoID == item.juegoID);
                JuegoExtremo tmp = new JuegoExtremo
                {
                    Id = item.juegoID,
                    Nombre = juego.juegoNombre,
                    EsTipoCasual = false,
                    Altura = item.juegoExtremoAltura,
                    NivelRiesgo = item.juegoExtremoNivelRiesgo
                };

                juegos.Add(tmp);
            }

            return juegos;
        }

        public List<JuegoExtremo> ReadAll()
        {
            var juegos = CommonBC.Modelo.JuegosExtremos;
            return GenerarListado(juegos.ToList());
        }
    }
}
