using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIJugueteria.ILogistica;

namespace UIJugueteria
{
    public partial class ILOGISTICA : Form
    {
        private string _NombreUsuario;

        public ILOGISTICA(string _NombreUsuario)
        {
            InitializeComponent();
             this._NombreUsuario = _NombreUsuario;                  //guardamos el nombre del usuario que incio sesion
            AbrirFormEnPanel(() => new IGestionarProductos());      //abrimos por defecto la interfaz de Gestionar Productos
        }



                        //metodo que sirve para abrir formularios en el PanelCentral.
                    private void AbrirFormEnPanel<MiForm>(Func<MiForm> formFactory) where MiForm : Form
                    {
                        // Cerrar y eliminar cualquier instancia existente del formulario
                        var existingForm = PanelCentral.Controls.OfType<MiForm>().FirstOrDefault();
                        if (existingForm != null)
                        {
                            PanelCentral.Controls.Remove(existingForm);
                            existingForm.Close();
                            existingForm.Dispose();
                        }
                        // Crear una nueva instancia del formulario
                        Form formulario = formFactory();
                        formulario.TopLevel = false;
                        formulario.FormBorderStyle = FormBorderStyle.None;
                        formulario.Dock = DockStyle.Fill;
                        PanelCentral.Controls.Add(formulario);
                        PanelCentral.Tag = formulario;
                        formulario.Show();
                        formulario.BringToFront();
                    }


        private void btnCargarNuevoProducto_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(() => new ICrearNuevoProducto(_NombreUsuario));    //si presiona el boton abrimos ese formulario y le pasamos
                                                                                //el parametro necesario
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(() => new IGestionarProductos());//si presiona el boton abrimos ese formulario y le pasamos
                                                              //el parametro necesario
        }



        private void btnCargarStock_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(() => new IControlarSoloStock());//si presiona el boton abrimos ese formulario y le pasamos
                                                              //el parametro necesario
        }

        private void btnVerAlertaDeStock_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(() => new IVerAlertaStock());//si presiona el boton abrimos ese formulario y le pasamos
                                                          //el parametro necesario
        }

        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanelCERRAR(() => new ILogIn());//si presiona el boton abrimos ese formulario y le pasamos
                                                       //el parametro necesario
        }


                            //metodo que sirve para CERRAR todos los formularios y paneles para volver al LOG IN.
                            private void AbrirFormEnPanelCERRAR<MiForm>(Func<MiForm> formFactory) where MiForm : Form
                            {
                                                    // Cierra y elimina todos los controles en paneltodo
                                CloseAndRemoveAllControls(paneltodo);

                                Form formulario = formFactory();
                                formulario.TopLevel = false;
                                formulario.FormBorderStyle = FormBorderStyle.None;
                                formulario.Dock = DockStyle.Fill;
                                paneltodo.Controls.Add(formulario);
                                paneltodo.Tag = formulario;
                                formulario.Show();
                                formulario.BringToFront();
                            }

                            // Método auxiliar para cerrar y eliminar todos los controles en un panel
                            private void CloseAndRemoveAllControls(Panel panel)
                            {
                                foreach (Control control in panel.Controls)
                                {
                                    if (control is Form form)
                                    {
                                        form.Close();
                                    }
                                }
                                panel.Controls.Clear();
                            }

        private void btnLogistica_Click(object sender, EventArgs e)     //si presiona este boton, vamos cerrando los formularios que abrio.
        {
            if (this.PanelCentral.Controls.Count > 0)
            {
                this.PanelCentral.Controls.RemoveAt(0);
            }
        }
        private void ILOGISTICA_Load(object sender, EventArgs e) { }        //eventos que no agregamos codigo

        private void lblLogistic(object sender, EventArgs e) { }

        private void PanelCentral_Paint(object sender, PaintEventArgs e) { }

        private void PanelLateral_Paint(object sender, PaintEventArgs e) { }
    }
}
