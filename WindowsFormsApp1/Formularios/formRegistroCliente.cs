using System;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;
using System.Data;
using ProyectoBD;
using WindowsFormsApp1.Formularios;

namespace WindowsFormsApp1.Formularios
{
    public partial class frm_registrocl : Form
    {
        private static DataTable dt = new DataTable();

        public frm_registrocl()
        {
            InitializeComponent();
        }
        public void SetFlag(string valor)
        {
            flag.Text = valor;

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
            if (flag.Text == "1")
            {
                dgvCliente.Enabled = true;
            }
            try
            {
               
                DataSet ds = FCliente.GetAll();
                dt = ds.Tables[0];
                dgvCliente.DataSource = dt;
                dgvCliente_CellClick(null, null);

                txtEmail.Enabled = false;
                txtApellido.Enabled = false;
                txtCedula.Enabled = false;
                txtNombre.Enabled = false;
                txtTelefono.Enabled = false;


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
                if (txtid.Text == "")
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
                        txtNombre.Text = " ";
                        txtApellido.Text = " ";
                        txtCedula.Text = " ";
                        txtEmail.Text = " ";
                        txtTelefono.Text = " ";
                    }
                }
                else
                {
                    ClienteBLL cliente = new ClienteBLL
                    {
                        ID = Convert.ToInt32(txtid.Text),
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Cedula = txtCedula.Text,
                        Email = txtEmail.Text,
                        Telefono = txtTelefono.Text
                    };
                    if (FCliente.Actualizar(cliente) == 1)
                    {
                        MessageBox.Show("Datos modificados correctamente");
                        frm_reri_clien_Load(null, null);
                        txtNombre.Text = " ";
                        txtApellido.Text = " ";
                        txtCedula.Text = " ";
                        txtEmail.Text = " ";
                        txtTelefono.Text = " ";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }


        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCliente.CurrentRow != null)
            {
                txtid.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
                txtCedula.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
                txtTelefono.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
                txtEmail.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_reri_clien_Load(null, null);
            dgvCliente.Enabled = false;
            txtid.Text = "";
            btn_editar.Enabled = false;
            textBox1.Text = "";
            txtNombre.Text = " ";
            txtApellido.Text = " ";
            txtCedula.Text = " ";
            txtEmail.Text = " ";
            txtTelefono.Text = " ";
            button1.Enabled = false;
            txtEmail.Enabled = true;
            txtApellido.Enabled = true;
            txtCedula.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            dgvCliente.Enabled = true;
            button1.Enabled = false;
            txtEmail.Enabled = true;
            txtApellido.Enabled = true;
            txtCedula.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dataView = new DataView(dt.Copy());
                dataView.RowFilter = cmb_buscar.Text + " Like '" + textBox1.Text + "%'";
                dgvCliente.DataSource = dataView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            btn_editar.Enabled = true;
            button1.Enabled = true;
            DataSet ds = FCliente.GetAll();
            dt = ds.Tables[0];
            dgvCliente.DataSource = dt;
            dgvCliente_CellClick(null, null);

            textBox1.Text = " ";
            txtNombre.Text = " ";
            txtApellido.Text = " ";
            txtCedula.Text = " ";
            txtEmail.Text = " ";
            txtTelefono.Text = " ";

        }

        private void cmb_buscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {if (flag.Text == "1") 
            {
                Frm_crud facrud = Frm_crud.Getinstance();


                if (dgvCliente.CurrentRow != null)
                {
                    facrud.SetCliente(
                    txtid.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString(),
                    txtNombre.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString(),
                    txtApellido.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString(),
                    txtCedula.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString(),
                    txtid.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString()

                    );
                    facrud.Show();
                    Close();


                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void flag_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
