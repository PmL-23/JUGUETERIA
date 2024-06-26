﻿using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class Empleado : Usuario
    {
        protected string _Rol;
        protected string _IDEmpleado;
        protected decimal _Sueldo;
        protected string _Habilitado;

        #region Props
        public string Habilitado
        {
            get { return _Habilitado; }
            set { _Habilitado = value; }
        }


        public decimal Sueldo
        {
            get { return _Sueldo; }
            set { _Sueldo = value; }
        }


        public string IDEmpleado
        {
            get { return _IDEmpleado; }
            set { _IDEmpleado = value; }
        }


        public string Rol
        {
            get { return _Rol; }
            set { _Rol = value; }
        }
        #endregion

        public Empleado()
        {
            this.Rol = "Indefinido";
            this.Sueldo = 50000;
            this.Habilitado = "Deshabilitado";
        }

        #region Métodos Principales
        public bool Registrarse(string nombre, string apellido, int dni, string nombreUsuario, string contrasenia, string confirmContra)
        {

            if (!(string.Equals(contrasenia, confirmContra))) throw new Exceptions.MyExceptions("Las contraseñas ingresadas no coinciden..");

            DAL.Empleado empleado = new DAL.Empleado();

            if (empleado.Registrarse(nombre, apellido, dni, nombreUsuario, contrasenia, this.Rol, this.Sueldo, this.Habilitado))
            {
                return true;
            }

            return false;
        }

        #endregion

        #region Métodos Auxiliares

        public bool VerSiExisteNombreUsuario(string _NombreUsuarioParametro) {

            DAL.Empleado empleado = new DAL.Empleado();

            bool ver = empleado.VerSiExisteNombreUsuario(_NombreUsuarioParametro);
            if (ver==true)
            {
                return true;
            }

            return false;

        }

        public string VerificarRol(string nombreUsuario)
        {
            DAL.Empleado empleado = new DAL.Empleado();

            return empleado.VerificarRol(nombreUsuario);
        }

        public bool EliminarEmpleado(string IDEmpleado)
        {
            DAL.Empleado unEmpleado = new DAL.Empleado();

            if (unEmpleado.EliminarEmpleado(IDEmpleado))
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
