using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public class ClaseVendedor
    {
        [TestMethod]
        public void TestGenerarFactura()
        {
            ///////////////////////////PRUEBA MÉTODO1////////////////////////////////
            
            BLL.Vendedor unVendedor = new BLL.Vendedor();
            BLL.Factura unaFactura = new BLL.Factura();
            BLL.Cliente unCliente1 = new BLL.Cliente();
            BLL.Empleado unEmpleado = new BLL.Empleado();

            //Se usa el ID Empleado reservado para pruebas
            unEmpleado.IDEmpleado = "Vendedor";
                        
            //Cargo Nombre de Cliente no cargado en BDDJ
            unCliente1.IDCliente = "4567";
            unCliente1.Nombre = "PEPE";
            unCliente1.Apellido = "Sala";
            unCliente1.DNI = 999999;
            unCliente1.CantidadCompras = 4;
            unVendedor.RegistrarCliente(unCliente1.IDCliente, unCliente1.Nombre, unCliente1.Apellido, unCliente1.DNI, unCliente1.CantidadCompras);
           
            //Cargo un Factura que no esta cargada en BDDJ 
            string FechaEmision = "2024-06-02 04:20:04.444";
            decimal Total = 32.4M;

            bool parametroEsperado = true;

            //Verifico con test que la factura se carga correctamente en BDDJ
            Assert.AreEqual(parametroEsperado, unVendedor.GenerarFactura(unEmpleado.IDEmpleado, unCliente1.IDCliente, FechaEmision, Total));

            //Elimino registro de BDDJ
            unaFactura.EliminarFactura();
            unCliente1.EliminarCliente(unCliente1.IDCliente);
            
        }
        [TestMethod]
        public void TestRegistrarCliente()
        {
            ///////////////////////////PRUEBA MÉTODO2////////////////////////////////

            BLL.Cliente unCliente1 = new BLL.Cliente();
            BLL.Vendedor unVendedor = new BLL.Vendedor();

            //Cargo Nombre de Cliente no cargado en BDDJ
            unCliente1.IDCliente = "1234";
            unCliente1.Nombre = "PEPE";
            unCliente1.Apellido = "Sala";
            unCliente1.DNI = 999999;
            unCliente1.CantidadCompras = 4;
            //Verifico que el ID Cliente no  está cargado  en la base datos
            bool parametroEsperado1 = true;

            //Elimino posible registro
            unCliente1.EliminarCliente(unCliente1.IDCliente);

            //Verifico con Segundo test que el cliente se carga en BDDJ usando Método
            Assert.AreEqual(parametroEsperado1, unVendedor.RegistrarCliente(unCliente1.IDCliente, unCliente1.Nombre, unCliente1.Apellido, unCliente1.DNI, unCliente1.CantidadCompras), "El Cliente no pudo ser registrado");

            //Elimino el Cliente nuevo de BDDJ en el caso de cumplirse con el Test
            unCliente1.EliminarCliente(unCliente1.IDCliente);
        }
    }
}
