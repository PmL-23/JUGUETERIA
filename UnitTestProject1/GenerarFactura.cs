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
            unaFactura._FechaEmision = "";
            unaFactura._Total = 1324;
            unaFactura._IDVendedor = "123";
            unaFactura. _IDCliente = "4567";

        bool parametroEsperado = true;

            //Verifico que la factura se carga correctamente en BDDJ
        Assert.AreEqual(parametroEsperado, unVendedor.GenerarFactura(unaFactura._IDVendedor, unaFactura._IDCliente, unaFactura._FechaEmision, unaFactura._Total));

        

        }
    }
}
