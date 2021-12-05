using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios;

namespace WindowsFormsApp1
{
    public partial class Frm_login : Form
    {
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
            // TODO: esta línea de código carga datos en la tabla 'sof108DataSet.CLIENTE' Puede moverla o quitarla según sea necesario.
            this.cLIENTETableAdapter.Fill(this.sof108DataSet.CLIENTE);

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
            var formulario = new frm_reri_clien();
            formulario.ShowDialog();
        }

        private void btnRegistroIncidente_Click(object sender, EventArgs e)
        {
            var formulario = new formRegistroIncidente();
            formulario.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)

        {

        }

        private void btt_erase_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_reri_clien nuevocliente = new frm_reri_clien();
            nuevocliente.ShowDialog();

        }

        private void txt_coment_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttn_create_Click(object sender, EventArgs e)
        {
            string limpiar = " ";
            txt_name.Text = limpiar;
            txt_incident.Text = limpiar;
            txt_buscar.Text = limpiar;
            txt_coment.Text = limpiar;
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
