using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Juegos.DALC;

namespace Juegos.Negocio
{
    public class CommonBC
    {
        private static ChantasilandiaEntities1  _modelo;
        
        public static ChantasilandiaEntities1 Modelo
        {
            get
            {
                if (_modelo == null) 
                {
                    _modelo = new ChantasilandiaEntities1();
                }
                return _modelo;
            }
        }

        public CommonBC()
        {
            
        }
    }
}
