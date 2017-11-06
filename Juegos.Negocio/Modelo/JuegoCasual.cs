using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juegos.Negocio.Modelo
{
    public class JuegoCasual : Juego
    {
        #region campos
        private bool _requiereSupervision;
        private bool _poseeCinturon;

        public bool RequiereSupervision
        {
            get
            {
                return _requiereSupervision;
            }

            set
            {
                _requiereSupervision = value;
            }
        }

        public bool PoseeCinturon
        {
            get
            {
                return _poseeCinturon;
            }

            set
            {
                _poseeCinturon = value;
            }
        }
        #endregion

        #region atributos

        #endregion

        public JuegoCasual()
        {
            this.Init();
        }

        public JuegoCasual(int id, string nombre, bool tipo, bool requiereSupervision, bool poseeCinturon)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.EsTipoCasual = true;
            this.RequiereSupervision = requiereSupervision;
            this.PoseeCinturon = poseeCinturon;
        }

        private void Init()
        {
            this.Id = -1;
            this.Nombre = "";
            this.EsTipoCasual = true;
            this.RequiereSupervision = false;
            this.PoseeCinturon = false;
        }

        public new bool Crear()
        {
            try
            {
                Juegos.DALC.Juegos juego = new Juegos.DALC.Juegos
                {
                    juegoID = this.Id,
                    juegoNombre = this.Nombre,
                    juegoTipo = true
                };
                CommonBC.Modelo.Juegos.Add(juego);

                Juegos.DALC.JuegosCasuales juegoCasual = new Juegos.DALC.JuegosCasuales
                {
                    juegoID = this.Id,
                    juegoCasualPoseeCinturon = this.PoseeCinturon,
                    juegoCasualReqSupervision = this.RequiereSupervision
                };
                CommonBC.Modelo.JuegosCasuales.Add(juegoCasual);

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

                var juegoCasual = CommonBC.Modelo.JuegosCasuales.First
                    (aux => aux.juegoID == this.Id);
                CommonBC.Modelo.JuegosCasuales.Remove(juegoCasual);

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
                juego.juegoTipo = true;

                var juegoCasual = CommonBC.Modelo.JuegosCasuales.First
                    (aux => aux.juegoID == this.Id);
                juegoCasual.juegoID = this.Id;
                juegoCasual.juegoCasualReqSupervision = this.RequiereSupervision;
                juegoCasual.juegoCasualPoseeCinturon= this.PoseeCinturon;

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

                var juegoCasual = CommonBC.Modelo.JuegosCasuales.First
                    (aux => aux.juegoID == this.Id);
                this.RequiereSupervision = juegoCasual.juegoCasualReqSupervision;
                this.PoseeCinturon = juegoCasual.juegoCasualPoseeCinturon;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
