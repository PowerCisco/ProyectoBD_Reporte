using System;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;
namespace WindowsFormsApp1.Formularios
{
    public partial class frm_reri_clien : Form
    {
        public frm_reri_clien()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            

           /* var cliente = new ClienteBLL();
            cliente.Nombre = txtNombre.Text; 
            cliente.Apellido= txtApellido.Text; 
            cliente.Cedula = txtCedula.Text; 
            cliente.Telefono = txtTelefono.Text; 
            cliente.Email= txtEmail.Text;

            ConexionDAL conexion = new ConexionDAL();


            MessageBox.Show("Conectado .. " + conexion.PruebaConectar());

            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
