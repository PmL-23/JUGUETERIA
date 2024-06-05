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

            unaFactura._FechaEmision = "";
            unaFactura._Total = 1324;
            unaFactura._IDVendedor = "123";
            unaFactura. _IDCliente = "4567";

        bool parametroEsperado = true;

        Assert.AreEqual(parametroEsperado, unVendedor.GenerarFactura(unaFactura._IDVendedor, unaFactura._IDCliente, unaFactura._FechaEmision, unaFactura._Total));

        

        }
    }
}
