using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class JuegoCasual : Juego
    {
        #region campos
        private byte _requiereSupervision;
        private byte _poseeCinturon;
        #endregion

        #region atributos
        public byte RequiereSupervision { get => _requiereSupervision; set => _requiereSupervision = value; }
        public byte PoseeCinturon { get => _poseeCinturon; set => _poseeCinturon = value; }
        #endregion

        public JuegoCasual() : base()
        {
            this.Init();
        }

        public JuegoCasual(int id, string nombre, byte tipo, byte requiereSupervision, byte poseeCinturon) : base(id, nombre, tipo)
        {
            this.RequiereSupervision = requiereSupervision;
            this.PoseeCinturon = poseeCinturon;
        }

        private void Init()
        {
            this.RequiereSupervision = 255;
            this.PoseeCinturon = 255;
        }

        public new bool Crear()
        {
            try
            {
                Juegos.DALC.Juegos juego = new Juegos.DALC.Juegos();
                juego.juegoID = this.Id;
                juego.juegoNombre = this.Nombre;
                juego.juegoTipo = this.Tipo;
                CommonBC.Modelo.Juegos.Add(juego);

                Juegos.DALC.JuegosCasuales juegoCasual = new Juegos.DALC.JuegosCasuales();
                juegoCasual.juegoID = this.Id;
                juegoCasual.juegoCasualPoseeCinturon = this.PoseeCinturon;
                juegoCasual.juegoCasualReqSupervision = this.RequiereSupervision;
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
                juego.juegoTipo = this.Tipo;

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
                this.Tipo = juego.juegoTipo;

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
