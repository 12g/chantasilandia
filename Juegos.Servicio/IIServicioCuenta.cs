using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Juegos.Servicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IIServicioCuenta" in both code and config file together.
    [ServiceContract]
    public interface IIServicioCuenta
    {
        [OperationContract]
        bool ValidarUsuario(string username, string password);
    }
}
