using System;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;
using System.Data;
using System.Data.Sql;

namespace WindowsFormsApp1.Formularios
{
    public partial class frm_registrocl : Form
    {
        private static DataTable dt = new DataTable();

        public frm_registrocl()
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

        private void frm_reri_clien_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = FCliente.GetAll();
                dt = ds.Tables[0];
                dgvCliente.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }


        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                ClienteBLL cliente = new ClienteBLL
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Cedula = txtCedula.Text,
                    Email = txtEmail.Text,
                    Telefono = txtTelefono.Text
                };
                if (FCliente.Insertar(cliente) > 0)
                {
                    MessageBox.Show("Insertado correctamente");
                    frm_reri_clien_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }


        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          txtid.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            txtApellido.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
            txtCedula.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
            txtTelefono.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
            txt


        }
    }
}
