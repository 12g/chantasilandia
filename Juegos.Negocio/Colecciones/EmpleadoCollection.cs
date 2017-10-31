using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Colecciones
{
    class EmpleadoCollection
    {
        public EmpleadoCollection()
        {

        }

        private List<Empleado> GenerarListado(List<Juegos.DALC.Empleados> empleadosDALC)
        {
            List<Empleado> empleados = new List<Empleado>();

            foreach (Juegos.DALC.Empleados item in empleadosDALC)
            {
                Empleado tmp = new Empleado
                {
                    Id = item.empleadoID,
                    Nombre = item.empleadoNombre,
                    TrabajoID = item.empleadoTrabajoID
                };

                empleados.Add(tmp);
            }

            return empleados;
        }

        public List<Empleado> ReadAll()
        {
            var empleados = CommonBC.Modelo.Empleados;
            return GenerarListado(empleados.ToList());
        }
    }
}
