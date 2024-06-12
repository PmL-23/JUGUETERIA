using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class ClaseFactura
    {
        [TestMethod]
        public void TestMethod1()
        {
            BLL.Factura unaFactura = new BLL.Factura();
            //Istancio una Lista para la prueba
            BLL.Factura listaEsperada = new BLL.Factura();
            BLL.DetalleFactura detalleEsperado = new BLL.DetalleFactura();  
            
           //Cargo una Lista de Detalle 
            string IDProducto = "123";
            int Cantidad = 3;
            decimal Precioventa = 2M;
            unaFactura.IDFactura = "333";

            detalleEsperado.Producto.IDProducto = IDProducto;
            detalleEsperado.Cantidad = Cantidad;
            detalleEsperado.Producto.Precioventa = Precioventa;
            listaEsperada.IDFactura = "333";
            listaEsperada.ListaDetalles.Add(detalleEsperado);

           ///////////////////////////PRUEBA MÉTODO1////////////////////////////////
           
            //Se agrega un detalle usando Método
            unaFactura.AgregarProductos(IDProducto, Cantidad, Precioventa);

            
            // Comprueba si las listas tienen la misma cantidad de elementos 
            Assert.AreEqual(listaEsperada.ListaDetalles.Count, unaFactura.ListaDetalles.Count);

            //Se hace una prueba mas detallada de los componente de las listas
            foreach (var detalleEsperado1 in listaEsperada.ListaDetalles)
            {
                // Encuentra un detalle correspondiente en la lista de detalles de la factura
                var detalleEncontrado = unaFactura.ListaDetalles.FirstOrDefault(detalle =>
                    detalle.Producto.IDProducto == detalleEsperado1.Producto.IDProducto &&
                    detalle.Cantidad == detalleEsperado1.Cantidad &&
                    detalle.Producto.Precioventa == detalleEsperado1.Producto.Precioventa);

                // Si no se encuentra un detalle correspondiente, la prueba fallará
                Assert.IsNotNull(detalleEncontrado);

                // Puedes incluso verificar más detalladamente las propiedades si lo deseas
                Assert.AreEqual(detalleEsperado1.Producto.IDProducto, detalleEncontrado.Producto.IDProducto);
                Assert.AreEqual(detalleEsperado1.Cantidad, detalleEncontrado.Cantidad);
                Assert.AreEqual(detalleEsperado1.Producto.Precioventa, detalleEncontrado.Producto.Precioventa);
            }


            //////////////////////////PRUEBA MÉTODO2////////////////////////////////


            //Resuelvo el cálculo del Método "CalcularTotal()"
            decimal parametroEsperado = 7.26M;

     
            
            //Verifico la prueba unitaria Aplicando Metodo
            Assert.AreEqual(parametroEsperado, unaFactura.CalcularTotal(), "El cálculo es erróneo");

            
        }
    }
}
