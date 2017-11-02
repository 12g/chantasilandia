using Juegos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class JuegoExtremo : Juego
    {
        #region campos
        private int _nivelRiesgo;
        private int _altura;

        public int NivelRiesgo
        {
            get
            {
                return _nivelRiesgo;
            }

            set
            {
                _nivelRiesgo = value;
            }
        }

        public int Altura
        {
            get
            {
                return _altura;
            }

            set
            {
                _altura = value;
            }
        }
        #endregion

        #region atributos

        #endregion

        public JuegoExtremo() : base()
        {
            this.Init();
        }

        public JuegoExtremo(int id, string nombre, byte tipo, byte requiereSupervision, byte poseeCinturon) : base(id, nombre, tipo)
        {
            this.NivelRiesgo = requiereSupervision;
            this.Altura = poseeCinturon;
        }

        private void Init()
        {
            this.NivelRiesgo = 255;
            this.Altura = 255;
        }

        public new bool Crear()
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

                Juegos.DALC.JuegosExtremos juegoExtremo = new Juegos.DALC.JuegosExtremos
                {
                    juegoID = this.Id,
                    juegoExtremoNivelRiesgo = this.NivelRiesgo,
                    juegoExtremoAltura = this.Altura
                };
                CommonBC.Modelo.JuegosExtremos.Add(juegoExtremo);

                CommonBC.Modelo.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public new bool Delete()
        {
            try
            {
                var juego = CommonBC.Modelo.Juegos.First
                    (aux => aux.juegoID == this.Id);
                CommonBC.Modelo.Juegos.Remove(juego);

                var juegoExtremo = CommonBC.Modelo.JuegosExtremos.First
                    (aux => aux.juegoID == this.Id);
                CommonBC.Modelo.JuegosExtremos.Remove(juegoExtremo);

                CommonBC.Modelo.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public new bool Update()
        {
            try
            {
                var juego = CommonBC.Modelo.Juegos.First
                    (aux => aux.juegoID == this.Id);
                juego.juegoID = this.Id;
                juego.juegoNombre = this.Nombre;
                juego.juegoTipo = this.Tipo;

                var juegoExtremo = CommonBC.Modelo.JuegosExtremos.First
                    (aux => aux.juegoID == this.Id);
                juegoExtremo.juegoID = this.Id;
                juegoExtremo.juegoExtremoNivelRiesgo = this.NivelRiesgo;
                juegoExtremo.juegoExtremoAltura = this.Altura;

                CommonBC.Modelo.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public new bool BuscarUno()
        {
            try
            {
                var juego = CommonBC.Modelo.Juegos.First
                    (aux => aux.juegoID == this.Id);
                this.Id = juego.juegoID;
                this.Nombre = juego.juegoNombre;
                this.Tipo = juego.juegoTipo;

                var juegoExtremo = CommonBC.Modelo.JuegosExtremos.First
                    (aux => aux.juegoID == this.Id);
                this.NivelRiesgo = juegoExtremo.juegoExtremoNivelRiesgo;
                this.Altura = juegoExtremo.juegoExtremoAltura;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
