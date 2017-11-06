using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Juegos.Negocio.Modelo
{
    public class Cuenta
    {
        private int _id;
        private string _usuario;
        private string _contraseña;

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

        public string Usuario
        {
            get
            {
                return _usuario;
            }

            set
            {
                _usuario = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return _contraseña;
            }

            set
            {
                _contraseña = value;
            }
        }

        public Cuenta()
        {
            this.Init();
        }

        public Cuenta(int id, string usuario, string contraseña)
        {
            this.Id = id;
            this.Usuario = usuario;
            this.Contraseña = contraseña;
        }

        private void Init()
        {
            this.Id = -1;
            this.Usuario = "";
            this.Contraseña = "";
        }

        public bool Crear()
        {
            try
            {
                Juegos.DALC.Cuentas cuenta = new Juegos.DALC.Cuentas
                {
                    cuentaID = this.Id,
                    cuentaUsuario = this.Usuario,
                    cuentaPassword = this.Contraseña
                };

                CommonBC.Modelo.Cuentas.Add(cuenta);

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
                var cuenta = CommonBC.Modelo.Cuentas.First
                    (aux => aux.cuentaID == this.Id);

                CommonBC.Modelo.Cuentas.Remove(cuenta);

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
                var cuenta = CommonBC.Modelo.Cuentas.First
                    (aux => aux.cuentaID == this.Id);

                cuenta.cuentaID = this.Id;
                cuenta.cuentaUsuario = this.Usuario;
                cuenta.cuentaPassword = this.Contraseña;
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
                var cuenta = CommonBC.Modelo.Cuentas.First
                    (aux => aux.cuentaID == this.Id);

                this.Id = cuenta.cuentaID;
                this.Usuario = cuenta.cuentaUsuario;
                this.Contraseña = cuenta.cuentaPassword;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
