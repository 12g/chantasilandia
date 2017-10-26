using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class JuegoCasual : Juego
    {
        private bool _poseeCinturon;
        private bool _requiereSupervision;

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

        public JuegoCasual()
        {
            this.Init();
        }

        private void Init()
        {
            this.PoseeCinturon = false;
            this.RequiereSupervision = false;
        }
    }
}
