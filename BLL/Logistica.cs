﻿using DAL;
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
        //no faltaria la id de admin?
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

        public bool CargarNuevoProducto(string IDCreadorusuario, string NombreProducto, string IDProducto, float Costo, string FechaCreacion, float PrecioVenta, int CantidadStock, int CantidadMinimaPermitida)
        {
            DAL.Logistica logistica = new DAL.Logistica();
            //Producto producto = new Producto(NombreProducto, IDProducto, Costo, FechaCreacion, PrecioVenta, CantidadStock, CantidadMinimaPermitida, IDCreadorusuario );
            if (logistica.CargarNuevoProducto(IDCreadorusuario, NombreProducto, IDProducto, Costo, FechaCreacion, PrecioVenta, CantidadStock, CantidadMinimaPermitida))
            {
                return true;
            }

            return false;
        }

        public bool ModificarProducto(string NombreProducto, string IDProducto, float Costo, float PrecioVenta, int CantidadStock, int CantidadMinimaPermitida)
        {
            DAL.Logistica logistica = new DAL.Logistica();
            if (logistica.ModificarProducto(NombreProducto, IDProducto, Costo, PrecioVenta, CantidadStock, CantidadMinimaPermitida))
            {
                return true;
            }
            return false;
        }

        public bool AumentarStock(string IDProducto, int CantidadStockAAumentar)
        {
            DAL.Logistica logistica = new DAL.Logistica();
            if (logistica.AumentarStock(IDProducto, CantidadStockAAumentar))
            {
                return true;
            }
            return false;

        }
        /*
        public List<Producto> VerAlertarBajoStock() //pedir ayuda a patricio para haecr esto, ya que el hizo algo muy parecido.
        {
            List < Producto > listaDeProductos = new List<Producto>();

            DAL.Logistica logistica = new DAL.Logistica();
            DataTable Productodb= logistica.VerAlertarBajoStock();

            foreach (DataRow fila in Productodb.Rows)
            {
                Producto producto = new Producto();
                producto.IDCreadorProducto = fila["_IDCreadorProducto"].ToString();
                producto.NombreProducto = fila["_NombreProducto"].ToString();
                producto.IDProducto = fila["_NombreProducto"].ToString();
                producto.Costo = float.Parse(fila["_Costo"].ToString());
                producto.FechaDeCreacion = fila["_FechaDeCreacion"].ToString();
                producto.Precioventa = float.Parse(fila["_PrecioVenta"].ToString());
                producto.CantidadEnStock = int.Parse(fila["_CantidadEnStock"].ToString());
                producto.CantidadMinimaPermitida= int.Parse(fila["_CantidadMinimaPermitida"].ToString());
                listaDeProductos.Add(producto);
            }
            return listaDeProductos;

        
        }*/

        public Logistica()
        {

        }


    }
}
