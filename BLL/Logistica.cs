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
        //atributos

        //propiedades

        public Logistica()
        {

        }

        #region Metodos Principales

        public bool CargarProducto(string IDCreadorusuario, string NombreProducto, string IDProducto, decimal Costo, string FechaCreacion, decimal PrecioVenta, int CantidadStock, int CantidadMinimaPermitida)
        {
            DAL.Logistica logistica = new DAL.Logistica();
                                //producto debe tener NombreProducto, IDProducto, Costo, FechaCreacion, PrecioVenta, CantidadStock, CantidadMinimaPermitida, IDCreadorusuario 
            if (logistica.CargarProducto(IDCreadorusuario, NombreProducto, IDProducto, Costo, FechaCreacion, PrecioVenta, CantidadStock, CantidadMinimaPermitida))
            {
                return true;
            }

            return false;
        }


        public bool EditarProducto(string NombreProducto, decimal Costo, decimal PrecioVenta, int CantidadStock, int CantidadMinimaPermitida, string IDProducto)
        {
            DAL.Logistica logistica = new DAL.Logistica();

            if (logistica.EditarProducto(NombreProducto, Costo, PrecioVenta, CantidadStock, CantidadMinimaPermitida, IDProducto))
            {
                return true;
            }
            return false;
        }

        public bool EliminarProducto(string IDProducto)
        {
            DAL.Logistica logistica = new DAL.Logistica();

            if (logistica.EliminarProducto(IDProducto))
            {
                return true;
            }
            return false;


        }
        public bool ControlarStock(string nombreproducto, int stockdisponible, int stockminimoideal, string IDProducto)
        {
            DAL.Logistica logistica = new DAL.Logistica();

            if (logistica.ControlarStock(nombreproducto, stockdisponible, stockminimoideal, IDProducto))
            {
                return true;
            }
            return false;

        }

        public List<Producto> VerAlertarBajoStock() //pedir ayuda a patricio para haecr esto, ya que el hizo algo muy parecido.
        {
            List<Producto> listaDeProductos = new List<Producto>();

            DAL.Logistica logistica = new DAL.Logistica();
            DataTable Productodb = logistica.VerAlertarBajoStock();

            foreach (DataRow fila in Productodb.Rows)
            {
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
            return listaDeProductos;

        }
        #endregion
        

        #region Metodos Auxiliares
        public bool VerSiExisteProducto(string IDProducto)
        {
            DAL.Logistica logistica = new DAL.Logistica();
            bool ver = logistica.VerSiExisteProducto(IDProducto);
            if (ver == true)
            {
                return true;
            }

            return false;
        }

        public Producto TraerUnProducto(string idproducto)
        {
            DAL.Logistica logistica = new DAL.Logistica();

            DataTable logisticabd = logistica.TraerUnProducto(idproducto);

            Producto ProductoRetornar = new Producto();

            if (logisticabd.Rows.Count == 1)
            {
                DataRow row = logisticabd.Rows[0];

                // Asignar los valores de las columnas a las propiedades de ProductoRetornar
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
                return null;
            }
        }

        public List<Producto> TraerListaProductos()
        {
            List<Producto> ListaProductos = new List<Producto>();

            DAL.Logistica logistica = new DAL.Logistica();

            DataTable logisticabd = logistica.TraerListaProductos();



            foreach (DataRow row in logisticabd.Rows)
            {
                Producto ProductoALista = new Producto();
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
            return ListaProductos;
        }
        #endregion

    }
}
