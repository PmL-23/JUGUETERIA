using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class Usuario
    {
        protected string _Nombre;
        protected string _Apellido;
        protected int _Dni;
        protected string _NombreUsuario;
        protected string _Contraseña;

        #region Props
        public string Contraseña
        {
            get { return _Contraseña; }
            set { _Contraseña = value; }
        }


        public string NombreUsuario
        {
            get { return _NombreUsuario; }
            set { _NombreUsuario = value; }
        }


        public int DNI
        {
            get { return _Dni; }
            set { _Dni = value; }
        }


        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }


        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }


        #endregion

        public bool IniciarSesion(string nombreUsuario, string contrasenia)
        {

            if (string.IsNullOrEmpty(nombreUsuario)) throw new Exceptions.MyExceptions("Nombre de Usuario no puede estar vacio..");

            if (string.IsNullOrEmpty(contrasenia)) throw new Exceptions.MyExceptions("Contraseña no puede estar vacia..");

            DAL.Usuario usuario = new DAL.Usuario();

            if (usuario.IniciarSesion(nombreUsuario, contrasenia))
            {
                return true;
            }
            return false;
        }
    }
}
