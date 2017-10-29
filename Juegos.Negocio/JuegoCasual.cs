using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class JuegoCasual : Juego
    {
        private bool PoseeCinturon;
        private bool RequiereSupervision;

        public bool PoseeCinturon1
        {
            get
            {
                return PoseeCinturon;
            }

            set
            {
                PoseeCinturon = value;
            }
        }

        public bool RequiereSupervision1
        {
            get
            {
                return RequiereSupervision;
            }

            set
            {
                RequiereSupervision = value;
            }
        }

        public JuegoCasual()
        {
            this.Init();
        }

        private void Init()
        {
            this.PoseeCinturon1 = false;
            this.RequiereSupervision1 = false;
        }
    }
}
