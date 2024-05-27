using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UIJugueteria
{
    

    public partial class NOSE : Form
    {

        public NOSE()
        {
            InitializeComponent();
            
        }
         private void btnCancela_Load(object sender, EventArgs e)
                {
            
                }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string _NombreUsuario = tboxUsuario.Text;
            string _Contraseña = tboxContraseña.Text;
            BLL.LogIn UnLogIn = new BLL.LogIn();

            if (UnLogIn.IniciarSesion(_NombreUsuario, _Contraseña) == true)
            {
                MessageBox.Show("\tInicio Sesión Exitosamente.\t");

            }

            else
            {
                MessageBox.Show("\tEl usuario y la contraseña no coinciden.\t");
            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void tboxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tboxContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
