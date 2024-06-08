﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class CalcularTotal
    {
        [TestMethod]
        public void TestMethod1()
        {
            BLL.Factura unaFactura = new BLL.Factura();
            
            BLL.DetalleFactura ListaDetalle = new BLL.DetalleFactura();
            //Cargo una Lista de Detalle 
            ListaDetalle.Producto.IDProducto = "123";
            ListaDetalle.Cantidad = 3;
            ListaDetalle.Producto.Precioventa = 2;
            ListaDetalle.Factura.IDFactura = "333";
            //La incorporo a una lista de la clase Factura
            unaFactura.ListaDetalles.Add(ListaDetalle);

            //Resuelvo el cálculo del Método "CalcularTotal()"
            decimal parametroEsperado = 7.26M;

            //Verifico la prueba unitaria 
            Assert.AreEqual(parametroEsperado, unaFactura.CalcularTotal(), "El cálculo es erróneo");
          
      
        }
    }
}