using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    /// <summary>
    /// Enumeración de los tipos de cuenta. 
    /// Con estos tipos, podemos configurar el
    /// acceso a las distintas partes de la aplicación.
    /// </summary>
    public enum TipoCuenta
    {
        Administrador
        ,RecursosHumanos
        //,Contabilidad
        //,ServicioTecnico
    }

    public enum TipoJuego
    {
        JuegoCasual,
        JuegoExtremo

    }

    public enum NivelDeRiesgo
    {
        Alto,
        MuyAlto,
        Extremo
    }
}
