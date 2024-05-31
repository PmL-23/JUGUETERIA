using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DetalleFactura
    {
		private int _IDFactura;
		private string _IDProducto;
		private decimal _PrecioUnitario;
		private int _Cantidad;

        #region Props
        public int Cantidad
		{
			get { return _Cantidad; }
			set { _Cantidad = value; }
		}


		public decimal PrecioUnitario
		{
			get { return _PrecioUnitario; }
			set { _PrecioUnitario = value; }
		}


		public string IDProducto
		{
			get { return _IDProducto; }
			set { _IDProducto = value; }
		}


		public int IDFactura
		{
			get { return _IDFactura; }
			set { _IDFactura = value; }
		}
        #endregion

        public bool InsertarDetallesFactura(List<DetalleFactura> ListaDetalles)
        {

            using (SqlConnection connection = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDDJ;Data Source=.\sqlexpress"))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    foreach (DetalleFactura detalleFactura in ListaDetalles)
                    {
                        string query = "INSERT INTO [BDDJ].[dbo].[DETALLE_FACTURA] ([_IDFactura], [_IDProducto], [_PrecioUnitario], [_Cantidad]) VALUES (@IDFactura, @IDProducto, @PrecioUnitario, @Cantidad)";
                        using (SqlCommand command = new SqlCommand(query, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@IDFactura", detalleFactura.IDFactura);
                            command.Parameters.AddWithValue("@IDProducto", detalleFactura.IDProducto);
                            command.Parameters.AddWithValue("@PrecioUnitario", detalleFactura.PrecioUnitario);
                            command.Parameters.AddWithValue("@Cantidad", detalleFactura.Cantidad);

                            command.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return false;
                }
                finally 
                { 
                    connection.Close();
                    connection.Dispose();
                }
            }


            /*
            DAL.DetalleFactura detFactura= new DAL.DetalleFactura();

            if (detFactura.InsertarDetallesFactura(ListaDetalles) == true)
            {
                return true;
            }
            else 
            {
                return false;
            }*/
        }

        public bool ActualizarStockProductos(List<DetalleFactura> ListaDetalles)
        {
            using (SqlConnection connection = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDDJ;Data Source=.\sqlexpress"))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    foreach (DetalleFactura detalleFactura in ListaDetalles)
                    {
                        string query = "UPDATE [BDDJ].[dbo].[PRODUCTO] SET _CantidadEnStock = _CantidadEnStock - @CantidadComprada WHERE _IDProducto = @IDProducto";
                        using (SqlCommand command = new SqlCommand(query, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@IDProducto", detalleFactura.IDProducto);
                            command.Parameters.AddWithValue("@CantidadComprada", detalleFactura.Cantidad);

                            command.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return false;
                }
                finally
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }
    }
}
