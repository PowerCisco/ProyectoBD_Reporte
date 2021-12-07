using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios;
using WindowsFormsApp1.DAL;
using ProyectoBD;
using WindowsFormsApp1.BLL;
using System.Text;


namespace WindowsFormsApp1
{
    public partial class Frm_crud : Form
    {
        private static Frm_crud _instancia;
        private static DataTable dt = new DataTable();


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Frm_crud()
        {
            InitializeComponent();
        }

        public static Frm_crud Getinstance()
        {
            if (_instancia == null)

                _instancia = new Frm_crud();

            return _instancia;
        }

        public void SetCliente(string id, string nombre, string apellido, string cedula, string id_cliente)
        {
            txt_id.Text = id;
            txt_name.Text = nombre;
            txtapellido.Text = apellido;
            txtcedula.Text = cedula;
            txt_incident_id.Text= id_cliente;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_report_1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = FIncidencia.GetAll();
                dt = ds.Tables[0];
                dgv_datos.DataSource = dt;

                txtapellido.Enabled = false;
                txt_name.Enabled = false;
                txt_id.Enabled = false;
                txtcedula.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) {
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que desea salir?", "¿Salir?", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
                Application.Exit();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var formulario = new frm_registrocl();
            formulario.ShowDialog();
        }

        private void btnRegistroIncidente_Click(object sender, EventArgs e)
        {
            //  var formulario = new formRegistroIncidente();
            ///  formulario.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)

        {

        }

        private void btt_erase_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_registrocl nuevocliente = new frm_registrocl();
            nuevocliente.SetFlag("0");
            nuevocliente.Show();

        }

        private void txt_coment_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttn_create_Click(object sender, EventArgs e)
        {
            frm_registrocl formcliente = new frm_registrocl();
            formcliente.SetFlag("1");
            formcliente.ShowDialog();

            string limpiar = " ";
            txt_id.Text = limpiar;
            txt_name.Text = limpiar;
            txt_incident_id.Text = limpiar;
            txt_buscar.Text = limpiar;
            txt_coment.Text = limpiar;
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bttn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                IncidenteBLL incidente = new IncidenteBLL
                {
                    Estado = cmb_status.SelectedItem.ToString(),
                    Fecha = DateTime.Now,
                    IDCliente = Convert.ToInt32(txt_incident_id.Text),
                    Comentario = txt_coment.Text



                };
                if (FIncidencia.Insertar(incidente) > 0)
                {
                    MessageBox.Show("Insertado Correctamente");
                    Frm_login_Load(null, null);

                }




            }
            else {



                IncidenteBLL incidiente = new IncidenteBLL
                {
                    ID = Convert.ToInt32(txt_id.Text),
                    Estado = cmb_status.SelectedItem.ToString(),
                    Comentario = txt_coment.Text,
                    Fecha = DateTime.Now
                };
                if (FIncidencia.Actualizar(incidiente) == 1)
                {
                    MessageBox.Show("Datos modificados correctamente");

                    txtapellido.Text = "";
                    txtcedula.Text = "";
                    txt_id.Text = "";
                    txt_name.Text = "";
                    txt_coment.Text = "";
                    txt_incident_id.Text = "";
                    Frm_login_Load(null, null);


                }




            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmb_buscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dataView = new DataView(dt.Copy());
                dataView.RowFilter = cmb_buscar.Text + " Like '" + txt_buscar.Text + "%'";
                dgv_datos.DataSource = dataView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btt_acc_Click(object sender, EventArgs e)
        {

        }

        private void dgv_datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {//ID_CLIENTE, NOMBRE_CLIENTE, EMAIL, CEDULA, ID_INCIDENTE, ESTADO, COMENTARIO

            if (dgv_datos.CurrentRow != null)
            {
                txt_id.Text = dgv_datos.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text= dgv_datos.CurrentRow.Cells[1].Value.ToString();
                cmb_status.SelectedItem = dgv_datos.CurrentRow.Cells[5].Value.ToString();
                txt_coment.Text = dgv_datos.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Frm_login_Load(null, null);

        }

        private void txt_id_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
