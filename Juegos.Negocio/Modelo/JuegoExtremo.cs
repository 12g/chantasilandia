using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juegos.Negocio.Modelo
{
    public class JuegoExtremo : Juego
    {
        #region campos
        private int _nivelRiesgo;
        private int _altura;
        #endregion

        #region atributos
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

        public JuegoExtremo()
        {
            this.Init();
        }

        public JuegoExtremo(int id, string nombre, bool tipo, int nivelRiesgo, int altura)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.EsTipoCasual = false;
            this.NivelRiesgo = nivelRiesgo;
            this.Altura = altura;
        }

        private void Init()
        {
            this.Id = -1;
            this.Nombre = "";
            this.EsTipoCasual = false;
            this.NivelRiesgo = -1;
            this.Altura = -1;
        }

        public new bool Crear()
        {
            try
            {
                Juegos.DALC.Juegos juego = new Juegos.DALC.Juegos
                {
                    juegoID = this.Id,
                    juegoNombre = this.Nombre,
                    juegoTipo = false
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
                juego.juegoTipo = false;

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
                this.EsTipoCasual = false;

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
