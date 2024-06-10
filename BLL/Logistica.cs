using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Logistica : Empleado
    {

        public Logistica()
        {

        }

        #region Metodos Principales
    

        public bool CargarProducto(string IDCreadorusuario, string NombreProducto, string IDProducto, decimal Costo, string FechaCreacion, decimal PrecioVenta, int CantidadStock, int CantidadMinimaPermitida)
        {
            DAL.Logistica logistica = new DAL.Logistica();  //instanciamos un objeto de la DAL, para usar un metodo y enviar a la Base de Datos

            if (logistica.CargarProducto(IDCreadorusuario, NombreProducto, IDProducto, Costo, FechaCreacion, PrecioVenta, CantidadStock, CantidadMinimaPermitida))
            {       //llamamos a CargarProducto de la DAL, el cual nos devuelve true si se CARGO correctamente y false si NO pudo.
                return true;
            }

            return false;
        }


        public bool EditarProducto(string NombreProducto, decimal Costo, decimal PrecioVenta, int CantidadStock, int CantidadMinimaPermitida, string IDProducto)
        {
            DAL.Logistica logistica = new DAL.Logistica();//instanciamos un objeto de la DAL, para usar un metodo y enviar a la Base de Datos

            if (logistica.EditarProducto(NombreProducto, Costo, PrecioVenta, CantidadStock, CantidadMinimaPermitida, IDProducto))
            {   //llamamos a EditarProducto de la DAL, el cual nos devuelve true si se EDITO correctamente y false si NO pudo.
                return true;
            }
            return false;
        }

        public bool EliminarProducto(string IDProducto)
        {
            DAL.Logistica logistica = new DAL.Logistica();//instanciamos un objeto de la DAL, para usar un metodo y enviar a la Base de Datos

            if (logistica.EliminarProducto(IDProducto))
            {   //llamamos a EliminarProducto de la DAL, el cual nos devuelve true si se ELIMINO correctamente y false si NO pudo por
                //que se encuentra en otra tabla u otro error.
                return true;
            }
            return false;
        }
        public bool ControlarStock(string nombreproducto, int stockdisponible, int stockminimoideal, string IDProducto)
        {
            DAL.Logistica logistica = new DAL.Logistica();//instanciamos un objeto de la DAL, para usar un metodo y enviar a la Base de Datos

            if (logistica.ControlarStock(nombreproducto, stockdisponible, stockminimoideal, IDProducto))
            {//llamamos a ControlarStock de la DAL, el cual nos devuelve true si se EDITO correctamente y false si NO pudo.
                return true;
            }
            return false;

        }

        public List<Producto> VerAlertarBajoStock() //pedir ayuda a patricio para haecr esto, ya que el hizo algo muy parecido.
        {
            List<Producto> listaDeProductos = new List<Producto>(); //instanciamos una lista del tipo Lista Producto, en la que guardaremos
                                                                    //todos los productos traidos por el metodo VerAlertarBajoStock().

            DAL.Logistica logistica = new DAL.Logistica();//instanciamos un objeto de la DAL, para usar un metodo y enviar a la Base de Datos
            DataTable Productodb = logistica.VerAlertarBajoStock();
            //llamamos a VerAlertarBajoStock de la DAL, el cual nos devuelve todos los producto con stock menor al sugerido.

            foreach (DataRow fila in Productodb.Rows)   //recorremos todo el DataTable traido por el metodo VerAlertarBajoStock
            {                                       //y lo guardamos en un objeto del tipo producto.
                Producto producto = new Producto();
                producto.IDCreadorProducto = fila["_IDCreadorProducto"].ToString();
                producto.NombreProducto = fila["_NombreProducto"].ToString();
                producto.IDProducto = fila["_NombreProducto"].ToString();
                producto.Costo = decimal.Parse(fila["_Costo"].ToString());
                producto.FechaDeCreacion = fila["_FechaCreacion"].ToString();
                producto.Precioventa = decimal.Parse(fila["_Precio"].ToString());
                producto.CantidadEnStock = int.Parse(fila["_CantidadEnStock"].ToString());
                producto.CantidadMinimaPermitida = int.Parse(fila["_CantidadMinimaPermitida"].ToString());
                listaDeProductos.Add(producto); 
            }
            return listaDeProductos; //finalmente retornamos la lista, que contendra todos los productos agregados
                                     //en el foreach, si es que se trajieron productos.
        }
        #endregion
        

        #region Metodos Auxiliares
        public bool VerSiExisteProducto(string IDProducto)
        {
            DAL.Logistica logistica = new DAL.Logistica();//instanciamos un objeto de la DAL, para usar un metodo y enviar
                                                          //a la Base de Datos
            bool ver = logistica.VerSiExisteProducto(IDProducto);
            //llamamos a VerSiExisteProducto de la DAL, el cual nos devuelve true si el IDProducto ya se encuentra como ID de un producto
            //y false si no.
            
            if (ver == true)
            {
                return true;
            }

            return false;
        }

        public Producto TraerUnProducto(string idproducto)
        {
            DAL.Logistica logistica = new DAL.Logistica();//instanciamos un objeto de la DAL, para usar un metodo y enviar
                                                          //a la Base de Datos

            DataTable logisticabd = logistica.TraerUnProducto(idproducto);
            //llamamos a TraerUnProducto de la DAL, el cual nos devuelve un DataTable con el producto traido de la BDD

            if (logisticabd.Rows.Count == 1)//verificamos que el DataTable traido tenga solo una fila.
            {
                Producto ProductoRetornar = new Producto();
                //instanciamos un objeto del tipo producto, el cual cargaremos con la información traida de la BDD y retornaremos
                DataRow row = logisticabd.Rows[0];  //nos posicionamos en la posicion 0.

                ProductoRetornar.IDCreadorProducto = row["_IDCreadorProducto"].ToString(); // Convertir el ID del creador a cadena
                ProductoRetornar.IDProducto = row["_IDProducto"].ToString(); // Convertir el ID del creador a cadena
                ProductoRetornar.NombreProducto = row["_NombreProducto"].ToString(); // Convertir el nombre del producto a cadena
                ProductoRetornar.Costo = Convert.ToDecimal(row["_Costo"]); // Convertir el costo a float
                ProductoRetornar.FechaDeCreacion = row["_FechaCreacion"].ToString(); // Convertir la fecha de creación a cadena
                ProductoRetornar.Precioventa = Convert.ToDecimal(row["_Precio"]); // Convertir el precio de venta a float
                ProductoRetornar.CantidadEnStock = Convert.ToInt32(row["_CantidadEnStock"]); // Convertir la cantidad en stock a int
                ProductoRetornar.CantidadMinimaPermitida = Convert.ToInt32(row["_CantidadMinimaPermitida"]); // Convertir la cantidad mínima permitida a int

                return ProductoRetornar;    
            }
            else
            {
                return null;// si fallamos al traer el producto retornamos null
            }
        }

        public List<Producto> TraerListaProductos()
        {
            List<Producto> ListaProductos = new List<Producto>();//instanciamos una lista del tipo Lista Producto, en la que guardaremos
                                                                 //todos los productos traidos por el metodo TraerListaProductos().

            DAL.Logistica logistica = new DAL.Logistica();//instanciamos un objeto de la DAL, para usar un metodo y enviar
                                                          //a la Base de Datos

            DataTable logisticabd = logistica.TraerListaProductos();
            //llamamos a TraerListaProductos de la DAL, el cual nos devuelve un DataTable con TODOS los productsos de la BDD


            foreach (DataRow row in logisticabd.Rows)
            {
                Producto ProductoALista = new Producto(); //instanciamos un objeto del ripo producto, lo llenamos recorriendo la lista
                                                          //traida y los agregamos a la lista a retornar.
                ProductoALista.IDCreadorProducto = row["_IDCreadorProducto"].ToString(); // Convertir el ID del creador a cadena
                ProductoALista.IDProducto = row["_IDProducto"].ToString(); // Convertir el ID del creador a cadena
                ProductoALista.NombreProducto = row["_NombreProducto"].ToString(); // Convertir el nombre del producto a cadena
                ProductoALista.Costo = Convert.ToDecimal(row["_Costo"]); // Convertir el costo a float
                ProductoALista.FechaDeCreacion = row["_FechaCreacion"].ToString(); // Convertir la fecha de creación a cadena
                ProductoALista.Precioventa = Convert.ToDecimal(row["_Precio"]); // Convertir el precio de venta a float
                ProductoALista.CantidadEnStock = Convert.ToInt32(row["_CantidadEnStock"]); // Convertir la cantidad en stock a int
                ProductoALista.CantidadMinimaPermitida = Convert.ToInt32(row["_CantidadMinimaPermitida"]); // Convertir la cantidad mínima permitida a int
                ListaProductos.Add(ProductoALista);
            }
            return ListaProductos;  //retornamos la lista manipuolada en el foreach
        }
        #endregion

    }
}