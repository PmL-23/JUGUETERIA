using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class ClaseUsuario
    {
        [TestMethod]
        public void TestMethod1()
        {
            BLL.Empleado unEmpleado = new BLL.Empleado();
          

            //Cargo Nombre de Usuario cargado en BDDJ
            unEmpleado.IDEmpleado = "davi";
            bool parametroEsperado = true;

            //Verifico que el Nombre de Usuario esta cargado en BDDJ
            Assert.AreEqual(parametroEsperado,unEmpleado. VerSiExisteNombreUsuario(unEmpleado.IDEmpleado), "El Nombre de Usuario no esta cargado en BDDJ");


            BLL.Empleado unEmpleado1 = new BLL.Empleado();


            //Cargo Nombre de Usuario no cargado en BDDJ
            unEmpleado1.IDEmpleado = "teo";
            bool parametroEsperado1 = false;

            //Verifico que el Nombre de Usuario no esta cargado en BDDJ
            Assert.AreEqual(parametroEsperado1, unEmpleado1.VerSiExisteNombreUsuario(unEmpleado1.IDEmpleado),"El Nombre de Usuario esta cargado en BDDJ");
        }
    }
}
