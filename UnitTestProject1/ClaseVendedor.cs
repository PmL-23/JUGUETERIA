using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public class ClaseVendedor
    {
        [TestMethod]
        public void TestMethod2()
        {
            BLL.Vendedor unVendedor = new BLL.Vendedor();
            BLL.Factura unaFactura = new BLL.Factura();
            BLL.Cliente unCliente1 = new BLL.Cliente();


            ///////////////////////////PRUEBA MÉTODO1////////////////////////////////
            
            //Cargo un Factura que no esta cargada en BDDJ 
            unaFactura.FechaEmision = "";
            unaFactura.Total = 1324;
            unaFactura.Vendedor.IDEmpleado = "davi";
            unaFactura.Cliente.IDCliente = "4567";

             bool parametroEsperado = true;
            
            //Verifico con primer test que la factura se carga correctamente en BDDJ
            Assert.AreEqual(parametroEsperado, unVendedor.GenerarFactura(unaFactura.Vendedor.IDEmpleado, unaFactura.Cliente.IDCliente, unaFactura.FechaEmision, unaFactura.Total));
            
            //Elimino registro de BDDJ
            unaFactura.EliminarFactura();

            ///////////////////////////PRUEBA MÉTODO2////////////////////////////////


            //Cargo Nombre de Cliente no cargado en BDDJ
            unCliente1.IDCliente = "1234";
            unCliente1.Nombre = "PEPE";
            unCliente1.Apellido = "Sala";
            unCliente1.DNI = 999999;
            unCliente1.CantidadCompras = 4;
            //Verifico que el ID Cliente no  está cargado  en la base datos
            bool parametroEsperado1 = true;
            unCliente1.EliminarCliente(unCliente1.IDCliente);

            //Verifico com Segundo test que el cliente se carga en BDDJ usando Método
            Assert.AreEqual(parametroEsperado1, unVendedor.RegistrarCliente(unCliente1.IDCliente, unCliente1.Nombre, unCliente1.Apellido, unCliente1.DNI, unCliente1.CantidadCompras));

            //Elimino el Cliente nuevo de BDDJ en el caso de cumplirse con el Test
            unCliente1.EliminarCliente(unCliente1.IDCliente);
        }
    }
}
