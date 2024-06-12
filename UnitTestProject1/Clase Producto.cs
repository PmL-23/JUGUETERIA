using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Permissions;

namespace UnitTestProject1
{
    [TestClass]
    public class ClaseProducto
    {
        [TestMethod]
        public void TestCrearProducto()
        {
            BLL.Producto producto = new BLL.Producto();
            BLL.Logistica logistica = new BLL.Logistica();

            producto.NombreProducto = "Producto prueba";
            producto.IDProducto = "13idPRUEBA";
            producto.Costo = 144.2M ;
            producto.Precioventa = 190.99M;
            producto.FechaDeCreacion = "2024-06-02 04:20:04.444";
            producto.CantidadEnStock = 7;
            producto.CantidadMinimaPermitida = 5;
            producto.IDCreadorProducto = "MPaez4";

            bool ResultadoEsperado = true;
            bool ResultadoMetodo = logistica.CargarProducto(producto.IDCreadorProducto, producto.NombreProducto, producto.IDProducto, producto.Costo, producto.FechaDeCreacion, producto.Precioventa, producto.CantidadEnStock, producto.CantidadMinimaPermitida);

            //string IDCreadorusuario, string NombreProducto, string IDProducto, decimal Costo, string FechaCreacion, decimal PrecioVenta, int CantidadStock, int CantidadMinimaPermitida
            //Verifico la prueba unitaria 
            Assert.AreEqual(ResultadoEsperado, ResultadoMetodo, "Falló al CREAR");
        }

        [TestMethod]
        public void TestEditarProducto()    //para que se ejecute correctamente, primero debe ejecutarse la prueba de crear producto.
        {
            //EditarProducto(string NombreProducto, decimal Costo, decimal PrecioVenta, int CantidadStock, int CantidadMinimaPermitida, string IDProducto)
            BLL.Producto EditandoProducto = new BLL.Producto();
            BLL.Logistica logistica = new BLL.Logistica();
                        EditandoProducto.NombreProducto = "Producto Editado";        //los campos tabulados seran editados.
            EditandoProducto.IDProducto = "13idPRUEBA";  //producto creado en el primer test "TestCrearProducto", ahora lo editaremos
            EditandoProducto.Costo = 300;
                        EditandoProducto.Precioventa = 500.1M;
            EditandoProducto.FechaDeCreacion = "2024-06-02 04:20:04.444";
                        EditandoProducto.CantidadEnStock = 66;
                        EditandoProducto.CantidadMinimaPermitida = 15;
            EditandoProducto.IDCreadorProducto = "MPaez4"; //este campo no se modifica.

            //Basicamente Le cambiamos valores al objeto creado en la pueba "TestCrearProducto". entonces si traemos el objeto con esa ID deberia ser igual al que mandamo a cambiar.
            logistica.EditarProducto(EditandoProducto.NombreProducto, EditandoProducto.Costo, EditandoProducto.Precioventa, EditandoProducto.CantidadEnStock, EditandoProducto.CantidadMinimaPermitida, EditandoProducto.IDProducto);
            bool ResultadoMetodo = false;

            BLL.Producto ProductoEditadoTraido = new BLL.Producto();
            ProductoEditadoTraido = logistica.TraerUnProducto("13idPRUEBA");//metodo al que le damos una id y nos devuelve el producto con esa ID.
                                                                            //si el producto que nos trae la bdd es igual a que editamos, entonces si se edito correctamente el producto.


            
            if (EditandoProducto.NombreProducto == ProductoEditadoTraido.NombreProducto && EditandoProducto.IDProducto == ProductoEditadoTraido.IDProducto && EditandoProducto.Costo == ProductoEditadoTraido.Costo && EditandoProducto.Precioventa == ProductoEditadoTraido.Precioventa  && EditandoProducto.CantidadEnStock == ProductoEditadoTraido.CantidadEnStock && EditandoProducto.CantidadMinimaPermitida == ProductoEditadoTraido.CantidadMinimaPermitida && EditandoProducto.IDCreadorProducto == ProductoEditadoTraido.IDCreadorProducto )
            {
                ResultadoMetodo = true;
            }
            bool ResultadoEsperado = true;

            Assert.AreEqual(ResultadoEsperado, ResultadoMetodo, "Falló al EDITAR");
        }


        [TestMethod]
        public void TestEliminarProducto()
        {
            BLL.Producto producto = new BLL.Producto();
            BLL.Logistica logistica = new BLL.Logistica();

            producto.IDProducto = "13idPRUEBA";


            bool ResultadoEsperado = true;
            bool ResultadoMetodo = logistica.EliminarProducto(producto.IDProducto);

            //string IDCreadorusuario, string NombreProducto, string IDProducto, decimal Costo, string FechaCreacion, decimal PrecioVenta, int CantidadStock, int CantidadMinimaPermitida
            //Verifico la prueba unitaria 
            Assert.AreEqual(ResultadoEsperado, ResultadoMetodo, "Falló al ELIMINAR");
        }

    }
}
