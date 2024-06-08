using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public class GenerarFactura
    {
        [TestMethod]
        public void TestMethod2()
        {
            BLL.Vendedor unVendedor = new BLL.Vendedor();
            BLL.Factura unaFactura = new BLL.Factura();
            
            //Cargo un Factura que no esta cargada en BDDJ 
            unaFactura.FechaEmision = "";
            unaFactura.Total = 1324;
            unaFactura.Vendedor.IDEmpleado = "123";
            unaFactura.Cliente._IDCliente = "4567";

             bool parametroEsperado = true;

            //Verifico que la factura se carga correctamente en BDDJ
            Assert.AreEqual(parametroEsperado, unVendedor.GenerarFactura(unaFactura.Vendedor.IDEmpleado, unaFactura.Cliente._IDCliente, unaFactura.FechaEmision, unaFactura.Total));

        

        }
    }
}
