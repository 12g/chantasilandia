using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Juegos.DALC;

namespace BibliotecaClases
{
    class CommonBC
    {
        private static masterEntities _modelo;
        
        public static masterEntities Modelo
        {
            get
            {
                if (_modelo == null)
                {
                    _modelo = new masterEntities();
                }
                return _modelo;
            }
        }

        public CommonBC()
        {
            
        }
    }
}
