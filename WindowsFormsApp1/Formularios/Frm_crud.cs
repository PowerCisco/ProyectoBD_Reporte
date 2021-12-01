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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta =  MessageBox.Show("¿Seguro que desea salir?","¿Salir?",MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
                Application.Exit();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var formulario = new formRegistroCliente();
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
    }
}
