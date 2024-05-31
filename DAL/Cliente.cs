using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Cliente
    {
        public DataTable ClienteBase()
        {
            Conexion conexion = new Conexion();

            return  conexion.LeerPorComando("SELECT * FROM [BDDJ].[dbo].[CLIENTES] ");
        }


    }
}
