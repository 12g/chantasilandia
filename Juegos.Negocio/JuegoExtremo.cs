using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class JuegoExtremo : Juego
    {
        private NivelDeRiesgo Riesgo;
        private int altura;

       

        public int Altura
        {
            get
            {
                return altura;
            }

            set
            {
                altura = value;
            }
        }

        public NivelDeRiesgo Riesgo1
        {
            get
            {
                return Riesgo;
            }

            set
            {
                Riesgo = value;
            }
        }

        public JuegoExtremo()
        {
            this.Init();
        }

        private void Init()
        {
            this.Altura = 0;
            this.Riesgo1 = NivelDeRiesgo.Alto;
            
        }
    }
}
