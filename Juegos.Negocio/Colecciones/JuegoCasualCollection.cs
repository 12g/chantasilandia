﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Juegos.Negocio.Modelo;

namespace Juegos.Negocio.Colecciones
{
    public class JuegoCasualCollection
    {
        public JuegoCasualCollection()
        {

        }

        private List<JuegoCasual> GenerarListado(List<Juegos.DALC.JuegosCasuales> juegosDALC)
        {
            List<JuegoCasual> juegos = new List<JuegoCasual>();

            foreach (Juegos.DALC.JuegosCasuales item in juegosDALC)
            {
                var juego = CommonBC.Modelo.Juegos.First
                    (aux => aux.juegoID == item.juegoID);
                JuegoCasual tmp = new JuegoCasual
                {
                    Id = item.juegoID,
                    Nombre = juego.juegoNombre,
                    EsTipoCasual = true,
                    PoseeCinturon = item.juegoCasualPoseeCinturon,
                    RequiereSupervision = item.juegoCasualReqSupervision
                };

                juegos.Add(tmp);
            }

            return juegos;
        }

        public List<JuegoCasual> ReadAll()
        {
            var juegos = CommonBC.Modelo.JuegosCasuales;
            return GenerarListado(juegos.ToList());
        }
    }
}
