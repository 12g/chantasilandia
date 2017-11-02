using Juegos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    class JuegoCollection
    {
        public JuegoCollection()
        {

        }

        private List<Juego> GenerarListado (List<Juegos.DALC.Juegos> juegosDALC)
        {
            List<Juego> juegos = new List<Juego>();

            foreach (Juegos.DALC.Juegos item in juegosDALC)
            {
                Juego tmp = new Juego();
                tmp.Id = item.juegoID;
                tmp.Nombre = item.juegoNombre; 
                tmp.EsTipoCasual = item.juegoTipo;

                juegos.Add(tmp);
            }

            return juegos;
        }

        public List<Juego> ReadAll()
        {
            var juegos = CommonBC.Modelo.Juegos;
            return GenerarListado(juegos.ToList());
        }
    }
}
