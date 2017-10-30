using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class JuegoCasual : Juego
    {
        private byte _requiereSupervision;
        private byte _poseeCinturon;

        public JuegoCasual() : base()
        {
            this.Init();
        }

        private void Init()
        {
            RequiereSupervision = 255;
            PoseeCinturon = 255;
        }

        public JuegoCasual(int id, string nombre, byte tipo, byte requiereSupervision, byte poseeCinturon) : base(id, nombre, tipo)
        {
            this.RequiereSupervision = requiereSupervision;
            this.PoseeCinturon = poseeCinturon;
        }

        public byte RequiereSupervision { get => _requiereSupervision; set => _requiereSupervision = value; }
        public byte PoseeCinturon { get => _poseeCinturon; set => _poseeCinturon = value; }

        public new bool Crear()
        {
            try
            {
                Juegos.DALC.Juegos juego = new Juegos.DALC.Juegos();
                Juegos.DALC.JuegosCasuales juegoCasual = new Juegos.DALC.JuegosCasuales();

                juego.juegoID = this.Id;
                juego.juegoNombre = this.Nombre;
                juego.juegoTipo = this.Tipo;
                juegoCasual.juegoID = this.Id;
                juegoCasual.juegoCasualPoseeCinturon = this.PoseeCinturon;
                juegoCasual.juegoCasualReqSupervision = this.RequiereSupervision;

                CommonBC.Modelo.Juegos.Add(juego);
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
                var consulta1 = CommonBC.Modelo.Juegos.First
                    (aux => aux.juegoID == this.Id);

                var consulta2 = CommonBC.Modelo.JuegosCasuales.First
                    (aux => aux.juegoID == this.Id);

                CommonBC.Modelo.Juegos.Remove(consulta1);
                CommonBC.Modelo.JuegosCasuales.Remove(consulta2);

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
                var consulta1 = CommonBC.Modelo.Juegos.First
                    (aux => aux.juegoID == this.Id);
                var consulta2 = CommonBC.Modelo.JuegosCasuales.First
                    (aux => aux.juegoID == this.Id);

                consulta1.juegoID = this.Id;
                consulta1.juegoNombre = this.Nombre;
                consulta1.juegoTipo = this.Tipo;
                consulta2.juegoID = this.Id;
                consulta2.juegoCasualReqSupervision = this.RequiereSupervision;
                consulta2.juegoCasualPoseeCinturon= this.PoseeCinturon;

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
                var consulta1 = CommonBC.Modelo.Juegos.First
                    (aux => aux.juegoID == this.Id);
                var consulta2 = CommonBC.Modelo.JuegosCasuales.First
                    (aux => aux.juegoID == this.Id);

                this.Id = consulta1.juegoID;
                this.Nombre = consulta1.juegoNombre;
                this.Tipo = consulta1.juegoTipo;
                this.RequiereSupervision = consulta2.juegoCasualReqSupervision;
                this.PoseeCinturon = consulta2.juegoCasualPoseeCinturon;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
