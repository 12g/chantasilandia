using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Juegos.DALC;

namespace Juegos.Negocio.Modelo
{
    public class Juego 
    {
        #region campos
        private int _id;
        private string _nombre;
        private bool _esEsTipoCasualCasual;

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

        public bool EsTipoCasual
        {
            get
            {
                return _esEsTipoCasualCasual;
            }

            set
            {
                _esEsTipoCasualCasual = value;
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
            this.EsTipoCasual = false;
        }

        public Juego(int id, string nombre, bool tipo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.EsTipoCasual = tipo;
        }

        

        public bool Crear()
        {
            try
            {
                Juegos.DALC.Juegos juego = new Juegos.DALC.Juegos
                {
                    juegoID = this.Id,
                    juegoNombre = this.Nombre,
                    juegoTipo = this.EsTipoCasual
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
                consulta.juegoTipo = this.EsTipoCasual;

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
                    (aux => aux.juegoNombre == this.Nombre || aux.juegoID == this.Id);

                this.Id = consulta.juegoID;
                this.Nombre = consulta.juegoNombre;
                this.EsTipoCasual = consulta.juegoTipo;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
