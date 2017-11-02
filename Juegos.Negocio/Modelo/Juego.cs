using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Juegos.DALC;
using Juegos.Negocio;

namespace BibliotecaClases
{
    public class Juego 
    {
        #region campos
        private int _id;
        private string _nombre;
        private byte _tipo;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public byte Tipo
        {
            get
            {
                return _tipo;
            }

            set
            {
                _tipo = value;
            }
        }
        #endregion

        public Juego()
        {
            this.Init();
        }

        private void Init()
        {
            this.Id = -1;
            this.Nombre = "";
            this.Tipo = 255;
        }

        public Juego(int id, string nombre, byte tipo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Tipo = tipo;
        }

        

        public bool Crear()
        {
            try
            {
                Juegos.DALC.Juegos juego = new Juegos.DALC.Juegos
                {
                    juegoID = this.Id,
                    juegoNombre = this.Nombre,
                    juegoTipo = this.Tipo
                };
                CommonBC.Modelo.Juegos.Add(juego);

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
                var consulta = CommonBC.Modelo.Juegos.First
                    (aux => aux.juegoID == this.Id);

                CommonBC.Modelo.Juegos.Remove(consulta);

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
                var consulta = CommonBC.Modelo.Juegos.First
                    (aux => aux.juegoID == this.Id);

                consulta.juegoID = this.Id;
                consulta.juegoNombre = this.Nombre;
                consulta.juegoTipo = this.Tipo;

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
                var consulta = CommonBC.Modelo.Juegos.First
                    (aux => aux.juegoID == this.Id);

                this.Id = consulta.juegoID;
                this.Nombre = consulta.juegoNombre;
                this.Tipo = consulta.juegoTipo;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
