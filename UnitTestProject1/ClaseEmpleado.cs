using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class ClaseEmpleado
    {
        [TestMethod]
        public void TestRegistrarse()
        {
            ///////////////////////////PRUEBA MÉTODO1////////////////////////////////
            
            BLL.Empleado unEmpleado = new BLL.Empleado();

            //Cargo Nombre de Usuario cargado en BDDJ
            string nombre = "Apu";
            string apellido = "Nahasa";
            int dni = 9096666;
            string nombreUsuario = "Manjula3";
            string contrasenia = "12345";
            string confirmContra = "12345";

            //En las dos métodos espero el mismo resultado de prueba 
            bool parametroEsperado = true;

            //Verifico con primer test que se genere nuevo registro Usuario/Empleado
            Assert.AreEqual(parametroEsperado, unEmpleado.Registrarse(nombre, apellido, dni, nombreUsuario, contrasenia, confirmContra), "No se genero Registro");





        }

        [TestMethod]
        public void TestVerSiExisteNombreUsuario()
        {
            ///////////////////////////PRUEBA MÉTODO2////////////////////////////////

            BLL.Empleado unEmpleado = new BLL.Empleado();

            unEmpleado.IDEmpleado = "Manjula3";
            //En las dos métodos espero el mismo resultado de prueba 
            bool parametroEsperado = true;

            //Verifico con segundo test que el Nombre de Usuario esta cargado en BDDJ
            Assert.AreEqual(parametroEsperado, unEmpleado.VerSiExisteNombreUsuario(unEmpleado.IDEmpleado), "El Nombre de Usuario no esta cargado en BDDJ");

            //Elimino registro de BDDJ
            unEmpleado.EliminarEmpleado(unEmpleado.IDEmpleado);

        }
    }
}
