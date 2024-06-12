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
            producto.IDProducto = "13idPRUEBA";//
            producto.Costo = 144.2M ;                       //relleno un producto y lo cargo en la BDD, con el Método "CargarProducto"
            producto.Precioventa = 190.99M;
            producto.FechaDeCreacion = "2024-06-02 04:20:04.444";
            producto.CantidadEnStock = 7;
            producto.CantidadMinimaPermitida = 5;
            producto.IDCreadorProducto = "Logistica";      //DEBEMOS TENER SI O SI ESTE EMPLEADO DEL TIPO LOGISTICA CARGADO EN LA BBD.

            bool ResultadoTest = false;   //si es el producto se creo como indicamos, se cambiará a true.

            bool ResultadoMetodo = logistica.CargarProducto(producto.IDCreadorProducto, producto.NombreProducto, producto.IDProducto, producto.Costo, producto.FechaDeCreacion, producto.Precioventa, producto.CantidadEnStock, producto.CantidadMinimaPermitida);
            
            if (ResultadoMetodo == true){ 
            BLL.Producto ProductoCreadoTraido = new BLL.Producto();
                ProductoCreadoTraido = logistica.TraerUnProducto("13idPRUEBA");//metodo al que le damos una id y nos devuelve el producto con esa ID.
                                                                            //si el producto que nos trae la bdd es igual a que editamos, entonces si se edito correctamente el producto.
                if (producto.NombreProducto == ProductoCreadoTraido.NombreProducto && producto.IDProducto == ProductoCreadoTraido.IDProducto && producto.Costo == ProductoCreadoTraido.Costo && producto.Precioventa == ProductoCreadoTraido.Precioventa && producto.CantidadEnStock == ProductoCreadoTraido.CantidadEnStock && producto.CantidadMinimaPermitida == ProductoCreadoTraido.CantidadMinimaPermitida && producto.IDCreadorProducto == ProductoCreadoTraido.IDCreadorProducto)
                {
                        ResultadoTest = true;
                }
                else
                {
                    ResultadoTest = false;
                }
            }
            else
            {
                ResultadoTest = false;

            }
            bool ResultadoEsperado = true;
            //Verifico la prueba unitaria 
            Assert.AreEqual(ResultadoEsperado, ResultadoTest, "Falló al CREAR");
        }

        [TestMethod]
        public void TestEditarProducto()    //para que se ejecute correctamente, primero debe ejecutarse el test "TestCrearProducto"
        {
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

            bool ResultadoTest = false;   //si es el producto se creo como indicamos, se cambiará a true.

            //Basicamente Le cambiamos valores al objeto creado en la pueba "TestCrearProducto". entonces si traemos el objeto con esa ID deberia ser igual al que mandamo a cambiar.
            bool ResultadoMetodo = logistica.EditarProducto(EditandoProducto.NombreProducto, EditandoProducto.Costo, EditandoProducto.Precioventa, EditandoProducto.CantidadEnStock, EditandoProducto.CantidadMinimaPermitida, EditandoProducto.IDProducto);

            if (ResultadoMetodo == true)
            {
                BLL.Producto ProductoEditadoTraido = new BLL.Producto();
                ProductoEditadoTraido = logistica.TraerUnProducto("13idPRUEBA");//metodo al que le damos una id y nos devuelve el producto con esa ID.
                                                                                //si el producto que nos trae la bdd es igual a que editamos, entonces si se edito correctamente el producto.

                if (EditandoProducto.NombreProducto == ProductoEditadoTraido.NombreProducto && EditandoProducto.IDProducto == ProductoEditadoTraido.IDProducto && EditandoProducto.Costo == ProductoEditadoTraido.Costo && EditandoProducto.Precioventa == ProductoEditadoTraido.Precioventa && EditandoProducto.CantidadEnStock == ProductoEditadoTraido.CantidadEnStock && EditandoProducto.CantidadMinimaPermitida == ProductoEditadoTraido.CantidadMinimaPermitida && EditandoProducto.IDCreadorProducto == ProductoEditadoTraido.IDCreadorProducto)
                {
                    ResultadoTest = true;
                }
                else
                {
                    ResultadoTest = false;
                }
                
            }
            else
            {
                ResultadoTest = false;

            }
            bool ResultadoEsperado = true;

            Assert.AreEqual(ResultadoEsperado, ResultadoTest, "Falló al EDITAR PRODUCTO.");
        }
        [TestMethod]
        public void TestEditarStockProducto()    //para que se ejecute correctamente, primero debe ejecutarse el test "TestCrearProducto".
        {
            BLL.Producto EditandoStockProducto = new BLL.Producto();
            BLL.Logistica logistica = new BLL.Logistica();
                    EditandoStockProducto.NombreProducto = "Producto Editado en Stock";        //los campos tabulados seran editados.
            EditandoStockProducto.IDProducto = "13idPRUEBA";  //producto creado en el primer test "TestCrearProducto", y editado en "", ahora le editaremos los stocks y el nombre.
            EditandoStockProducto.Costo = 300;
            EditandoStockProducto.Precioventa = 500.1M;
            EditandoStockProducto.FechaDeCreacion = "2024-06-02 04:20:04.444";
                    EditandoStockProducto.CantidadEnStock = 13;
                    EditandoStockProducto.CantidadMinimaPermitida = 1;
            EditandoStockProducto.IDCreadorProducto = "MPaez4"; //este campo no se modifica.

            bool ResultadoTest = false;   //si es el producto se creo como indicamos, se cambiará a true.

            //Basicamente Le cambiamos valores al objeto creado en la pueba "TestCrearProducto". entonces si traemos el objeto con esa ID deberia ser igual al que mandamo a cambiar.
            bool ResultadoMetodo = logistica.ControlarStock(EditandoStockProducto.NombreProducto, EditandoStockProducto.CantidadEnStock, EditandoStockProducto.CantidadMinimaPermitida, EditandoStockProducto.IDProducto);

            if (ResultadoMetodo)
            {
                BLL.Producto ProductoEditadoTraido = new BLL.Producto();
                ProductoEditadoTraido = logistica.TraerUnProducto("13idPRUEBA");//metodo al que le damos una id y nos devuelve el producto con esa ID.
                                                                                //si el producto que nos trae la bdd es igual a que editamos, entonces si se edito correctamente el producto.

                if (EditandoStockProducto.NombreProducto == ProductoEditadoTraido.NombreProducto && EditandoStockProducto.IDProducto == ProductoEditadoTraido.IDProducto && EditandoStockProducto.Costo == ProductoEditadoTraido.Costo && EditandoStockProducto.Precioventa == ProductoEditadoTraido.Precioventa && EditandoStockProducto.CantidadEnStock == ProductoEditadoTraido.CantidadEnStock && EditandoStockProducto.CantidadMinimaPermitida == ProductoEditadoTraido.CantidadMinimaPermitida && EditandoStockProducto.IDCreadorProducto == ProductoEditadoTraido.IDCreadorProducto)
                {
                    ResultadoTest = true;
                }
                else
                {
                    ResultadoTest = false;
                }
            }
            else
            {
                ResultadoTest = false;
            }
            bool ResultadoEsperado = true;
            Assert.AreEqual(ResultadoEsperado, ResultadoTest, "Falló al EDITAR STOCK PRODUCTO.");
        }

        [TestMethod]
        public void TestEliminarProducto()
        {
            BLL.Producto producto = new BLL.Producto();
            BLL.Logistica logistica = new BLL.Logistica();

            producto.IDProducto = "13idPRUEBA";


            bool ResultadoTest = false;   //si es el producto se creo como indicamos, se cambiará a true.
            bool ResultadoMetodo = logistica.EliminarProducto(producto.IDProducto);

            if (ResultadoMetodo==true) {
                bool VerSiExisteProducto =logistica.VerSiExisteProducto(producto.IDProducto);//metodo que devuelve FALSE si NO encontro un producto con esa ID en la BDD
                if (VerSiExisteProducto==false)
                {
                    ResultadoTest = true;
                }
                else
                {
                    ResultadoTest=false;
                }
            }
            else
            {
                ResultadoTest = false;
            }
            //string IDCreadorusuario, string NombreProducto, string IDProducto, decimal Costo, string FechaCreacion, decimal PrecioVenta, int CantidadStock, int CantidadMinimaPermitida
            //Verifico la prueba unitaria 
            bool ResultadoEsperado = true;
            Assert.AreEqual(ResultadoEsperado, ResultadoTest, "Falló al ELIMINAR");
        }

    }
}
