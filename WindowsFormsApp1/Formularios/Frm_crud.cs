using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios;
using WindowsFormsApp1.DAL;
using ProyectoBD;
using WindowsFormsApp1.BLL;


namespace WindowsFormsApp1
{
    public partial class Frm_login : Form
    {
        private static DataTable dt = new DataTable();
        
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Frm_login()
        {
            InitializeComponent();
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
                
       
            }
            catch(Exception ex)
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
            DialogResult respuesta =  MessageBox.Show("¿Seguro que desea salir?","¿Salir?",MessageBoxButtons.YesNo);

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
            nuevocliente.ShowDialog();

        }

        private void txt_coment_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttn_create_Click(object sender, EventArgs e)
        {
            frm_registrocl formcliente = new frm_registrocl();
            formcliente.Show();

            string limpiar = " ";
            txt_name.Text = limpiar;
            txt_incident.Text = limpiar;
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
            IncidenteBLL incidente = new IncidenteBLL
            {
                Estado = Convert.ToString(cmb_buscar.Text),
                Fecha = Convert.ToDateTime(DateTime.Now),
                Comentario = txt_coment.Text

              
            };
            FIncidencia.Insertar(incidente);




        }
    }
}
