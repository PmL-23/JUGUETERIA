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

            //Cargo datos para la prueba
            string nombre = "Apu";
            string apellido = "Nahasa";
            int dni = 9096666;
            string nombreUsuario = "Manjula3";
            string contrasenia = "12345";
            string confirmContra = "12345";

            //Luego de la prueba espero un resultado
            bool parametroEsperado = true;
           
            //Verifico con test que se genere nuevo registro Usuario/Empleado con los datos anteriores
            Assert.AreEqual(parametroEsperado, unEmpleado.Registrarse(nombre, apellido, dni, nombreUsuario, contrasenia, confirmContra), "No se genero Registro");

            //Elimino registro de BDDJ
            unEmpleado.EliminarEmpleado(nombreUsuario);
        }

        [TestMethod]
        public void TestVerSiExisteNombreUsuario()
        {
            ///////////////////////////PRUEBA MÉTODO2////////////////////////////////

            BLL.Empleado unEmpleado = new BLL.Empleado();

            //Registro un usuario nuevo
            string nombre = "Apu";
            string apellido = "Nahasa";
            int dni = 9096666;
            string nombreUsuario = "Manjula3";
            string contrasenia = "12345";
            string confirmContra = "12345";
            unEmpleado.Registrarse(nombre, apellido, dni, nombreUsuario, contrasenia, confirmContra);

            //Luego de la prueba espero un resultado
            bool parametroEsperado = true;

            //Verifico con test que el Nombre de Usuario esta cargado en BDDJ
            Assert.AreEqual(parametroEsperado, unEmpleado.VerSiExisteNombreUsuario(nombreUsuario), "El Nombre de Usuario no esta cargado en BDDJ");

            //Elimino registro de BDDJ
            unEmpleado.EliminarEmpleado(nombreUsuario);

        }
    }
}
