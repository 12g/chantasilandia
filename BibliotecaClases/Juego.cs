using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Juego 
    {
        private string id;
        private string nombre;
        private int capacidad;
        private TipoJuego tipojuego;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Capacidad
        {
            get
            {
                return capacidad;
            }

            set
            {
                capacidad = value;
            }
        }

        public TipoJuego Tipojuego
        {
            get
            {
                return tipojuego;
            }

            set
            {
                tipojuego = value;
            }
        }

        public Juego()
        {
            this.Init();
        }

        private void Init()
        {
            this.Id = string.Empty;
            this.Nombre = string.Empty;
            this.Capacidad = 0;
            this.Tipojuego = TipoJuego.JuegoCasual;
            
        }
    }
}
