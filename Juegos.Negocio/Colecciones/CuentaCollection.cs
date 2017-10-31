using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Colecciones
{
    class CuentaCollection
    {
        public CuentaCollection()
        {

        }

        public List<Cuenta> GenerarListado(List<Juegos.DALC.Cuentas> cuentasDALC)
        {
            List<Cuenta> cuentas = new List<Cuenta>();

            foreach (Juegos.DALC.Cuentas item in cuentasDALC)
            {
                Cuenta tmp = new Cuenta
                {
                    Id = item.cuentaID,
                    Usuario = item.cuentaUsuario,
                    Contraseña = item.cuentaPassword
                };
            }
            return cuentas;
        }

        public List<Cuenta> ReadAll()
        {
            var cuentas = CommonBC.Modelo.Cuentas;
            return GenerarListado(cuentas.ToList());
        }
    }
}
