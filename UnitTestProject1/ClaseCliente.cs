using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class ClaseCliente
    {
        [TestMethod]
        public void TestMethod1()
        {
            BLL.Vendedor unVendedor1 = new BLL.Vendedor();
            BLL.Cliente unCliente1 = new BLL.Cliente();

            ///////////////////////////PRUEBA MÉTODO1////////////////////////////////
            
            //Cargo Nombre de Cliente no cargado en BDDJ
            unCliente1.IDCliente = "1234";
            unCliente1.Nombre = "PEPE";
            unCliente1.Apellido = "Sala";
            unCliente1.DNI = 999999;
            unCliente1.CantidadCompras = 4;
            //Verifico que el ID Cliente no  está cargado  en la base datos
            bool parametroEsperado1 = true;
            unCliente1.EliminarCliente(unCliente1.IDCliente);

            //Verifico com primer test que el cliente se carga en BDDJ usando Método
            Assert.AreEqual(parametroEsperado1, unVendedor1.RegistrarCliente(unCliente1.IDCliente, unCliente1.Nombre, unCliente1.Apellido, unCliente1.DNI, unCliente1.CantidadCompras));
            
            //Elimino el Cliente nuevo de BDDJ en el caso de cumplirse con el Test
            unCliente1.EliminarCliente(unCliente1.IDCliente);

        }
    }
}
