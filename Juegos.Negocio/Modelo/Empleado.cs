using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    class Empleado
    {
        #region campos
        private int _id;
        private string _nombre;
        private short _edad;
        private int _trabajoID;
        #endregion

        #region atributos
        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public short Edad { get => _edad; set => _edad = value; }
        public int TrabajoID { get => _trabajoID; set => _trabajoID = value; }
        #endregion

        public Empleado()
        {
            this.Init();
        }

        public Empleado(int id, string nombre, short edad, int trabajoID)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Edad = edad;
            this.TrabajoID = trabajoID;
        }

        private void Init()
        {
            this.Id = -1;
            this.Nombre = "";
            this.Edad = 10;
        }

        public bool Crear()
        {
            try
            {
                Juegos.DALC.Empleados empleado = new Juegos.DALC.Empleados
                {
                    empleadoID = this.Id,
                    empleadoNombre = this.Nombre,
                    empleadoEdad = this.Edad,
                    empleadoTrabajoID = this.TrabajoID
                };

                CommonBC.Modelo.Empleados.Add(empleado);

                CommonBC.Modelo.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                var consulta = CommonBC.Modelo.Empleados.First
                    (aux => aux.empleadoID == this.Id);

                CommonBC.Modelo.Empleados.Remove(consulta);

                CommonBC.Modelo.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                var consulta = CommonBC.Modelo.Empleados.First
                    (aux => aux.empleadoID == this.Id);

                consulta.empleadoID = this.Id;
                consulta.empleadoNombre = this.Nombre;
                consulta.empleadoEdad = this.Edad;
                consulta.empleadoTrabajoID = this.TrabajoID;
                CommonBC.Modelo.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool BuscarUno()
        {
            try
            {
                var consulta = CommonBC.Modelo.Empleados.First
                    (aux => aux.empleadoID == this.Id);

                this.Id = consulta.empleadoID;
                this.Nombre = consulta.empleadoNombre;
                this.Edad = consulta.empleadoEdad;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
