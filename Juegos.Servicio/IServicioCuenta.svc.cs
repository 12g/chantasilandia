using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Juegos.Servicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IServicioCuenta" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select IServicioCuenta.svc or IServicioCuenta.svc.cs at the Solution Explorer and start debugging.
    public class IServicioCuenta : IIServicioCuenta
    {
       public bool ValidarUsuario(string username, string password)
        {
            Juegos.Negocio.Modelo.Cuenta c = new Negocio.Modelo.Cuenta();
            c.Usuario = username;
            c.Contraseña = password;

            return c.Autenticar();
        }
    }
}
