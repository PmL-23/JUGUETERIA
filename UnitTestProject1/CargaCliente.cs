using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class CargarCliente
    {
        [TestMethod]
        public void TestMethod1()
        {
            BLL.Vendedor unVendedor1 = new BLL.Vendedor();
            BLL.Cliente unCliente1 = new BLL.Cliente();
            unCliente1._IDCliente = "1234";
            unCliente1._Nombre = "PEPE";
            unCliente1._Apellido = "Sala";
            unCliente1._DNI = 999999;
            unCliente1._CantidadCompras = 4;
            //Verifico que el ID Cliente no  está cargado  en la base datos
            bool parametroEsperado1 = true;

            //Verifico que el cliente se carga en BD usando Método
            Assert.AreEqual(parametroEsperado1, unVendedor1.RegistrarCliente(unCliente1._IDCliente, unCliente1._Nombre, unCliente1._Apellido, unCliente1._DNI, unCliente1._CantidadCompras));

        }
    }
}
