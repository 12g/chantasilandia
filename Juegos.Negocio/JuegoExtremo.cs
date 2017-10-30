using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class JuegoExtremo : Juego
    {
        private int _nivelRiesgo;
        private int _altura;

        public JuegoExtremo() : base()
        {
            this.Init();
        }

        private void Init()
        {
            NivelRiesgo = 255;
            Altura = 255;
        }

        public JuegoExtremo(int id, string nombre, byte tipo, byte requiereSupervision, byte poseeCinturon) : base(id, nombre, tipo)
        {
            this.NivelRiesgo = requiereSupervision;
            this.Altura = poseeCinturon;
        }

        public int NivelRiesgo { get => _nivelRiesgo; set => _nivelRiesgo = value; }
        public int Altura { get => _altura; set => _altura = value; }

        public new bool Crear()
        {
            try
            {
                Juegos.DALC.Juegos juego = new Juegos.DALC.Juegos();
                Juegos.DALC.JuegosExtremos juegoExtremo = new Juegos.DALC.JuegosExtremos();

                juego.juegoID = this.Id;
                juego.juegoNombre = this.Nombre;
                juego.juegoTipo = this.Tipo;
                juegoExtremo.juegoID = this.Id;
                juegoExtremo.juegoExtremoNivelRiesgo = this.NivelRiesgo;
                juegoExtremo.juegoExtremoAltura = this.Altura;

                CommonBC.Modelo.Juegos.Add(juego);
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
                var consulta1 = CommonBC.Modelo.Juegos.First
                    (aux => aux.juegoID == this.Id);

                var consulta2 = CommonBC.Modelo.JuegosExtremos.First
                    (aux => aux.juegoID == this.Id);

                CommonBC.Modelo.Juegos.Remove(consulta1);
                CommonBC.Modelo.JuegosExtremos.Remove(consulta2);

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
                var consulta2 = CommonBC.Modelo.JuegosExtremos.First
                    (aux => aux.juegoID == this.Id);

                consulta1.juegoID = this.Id;
                consulta1.juegoNombre = this.Nombre;
                consulta1.juegoTipo = this.Tipo;
                consulta2.juegoID = this.Id;
                consulta2.juegoExtremoNivelRiesgo = this.NivelRiesgo;
                consulta2.juegoExtremoAltura = this.Altura;

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
                var consulta2 = CommonBC.Modelo.JuegosExtremos.First
                    (aux => aux.juegoID == this.Id);

                this.Id = consulta1.juegoID;
                this.Nombre = consulta1.juegoNombre;
                this.Tipo = consulta1.juegoTipo;
                this.NivelRiesgo = consulta2.juegoExtremoNivelRiesgo;
                this.Altura = consulta2.juegoExtremoAltura;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
