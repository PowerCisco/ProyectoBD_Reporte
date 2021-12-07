
namespace WindowsFormsApp1
{
    partial class Frm_crud
    {


        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_crud));
            this.txt_name = new System.Windows.Forms.TextBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_incident_id = new System.Windows.Forms.TextBox();
            this.txt_coment = new System.Windows.Forms.TextBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.cmb_buscar = new System.Windows.Forms.ComboBox();
            this.bttn_guardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.bttn_create = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.iNCIDENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNCIDENTETableAdapter = new WindowsFormsApp1.sof108DataSetTableAdapters.INCIDENTETableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.sof108DataSet = new WindowsFormsApp1.sof108DataSet();
            this.sof108DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btt_insr = new System.Windows.Forms.Button();
            this.btt_Incidente = new System.Windows.Forms.Button();
            this.dtt_time = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNCIDENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sof108DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sof108DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.Honeydew;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_name.Location = new System.Drawing.Point(238, 105);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(138, 22);
            this.txt_name.TabIndex = 2;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // cmb_status
            // 
            this.cmb_status.BackColor = System.Drawing.Color.Honeydew;
            this.cmb_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Abierto",
            "En Proceso",
            "Completado",
            "Cancelado"});
            this.cmb_status.Location = new System.Drawing.Point(628, 221);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(100, 24);
            this.cmb_status.TabIndex = 5;
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.AllowUserToResizeColumns = false;
            this.dgv_datos.AllowUserToResizeRows = false;
            this.dgv_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(234, 314);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_datos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_datos.Size = new System.Drawing.Size(903, 297);
            this.dgv_datos.TabIndex = 7;
            this.dgv_datos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_datos_CellClick);
            this.dgv_datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(230, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(626, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "IDcliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(624, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Estatus:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(230, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Buscar:";
            // 
            // txt_incident_id
            // 
            this.txt_incident_id.BackColor = System.Drawing.Color.Honeydew;
            this.txt_incident_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_incident_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_incident_id.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_incident_id.Location = new System.Drawing.Point(628, 65);
            this.txt_incident_id.Name = "txt_incident_id";
            this.txt_incident_id.Size = new System.Drawing.Size(65, 22);
            this.txt_incident_id.TabIndex = 19;
            // 
            // txt_coment
            // 
            this.txt_coment.BackColor = System.Drawing.Color.Honeydew;
            this.txt_coment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_coment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coment.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_coment.Location = new System.Drawing.Point(863, 65);
            this.txt_coment.Multiline = true;
            this.txt_coment.Name = "txt_coment";
            this.txt_coment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_coment.Size = new System.Drawing.Size(274, 153);
            this.txt_coment.TabIndex = 20;
            this.txt_coment.TextChanged += new System.EventHandler(this.txt_coment_TextChanged);
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.Color.Honeydew;
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_buscar.Location = new System.Drawing.Point(234, 276);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(182, 22);
            this.txt_buscar.TabIndex = 21;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // cmb_buscar
            // 
            this.cmb_buscar.BackColor = System.Drawing.Color.Honeydew;
            this.cmb_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmb_buscar.FormattingEnabled = true;
            this.cmb_buscar.Items.AddRange(new object[] {
            "ESTADO",
            "NOMBRE_CLIENTE",
            "COMENTARIO"});
            this.cmb_buscar.Location = new System.Drawing.Point(422, 274);
            this.cmb_buscar.Name = "cmb_buscar";
            this.cmb_buscar.Size = new System.Drawing.Size(100, 24);
            this.cmb_buscar.TabIndex = 22;
            this.cmb_buscar.Text = "ESTADO";
            this.cmb_buscar.SelectedIndexChanged += new System.EventHandler(this.cmb_buscar_SelectedIndexChanged);
            // 
            // bttn_guardar
            // 
            this.bttn_guardar.BackColor = System.Drawing.Color.Turquoise;
            this.bttn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_guardar.ForeColor = System.Drawing.Color.Black;
            this.bttn_guardar.Location = new System.Drawing.Point(234, 628);
            this.bttn_guardar.Name = "bttn_guardar";
            this.bttn_guardar.Size = new System.Drawing.Size(85, 39);
            this.bttn_guardar.TabIndex = 23;
            this.bttn_guardar.Text = "Guardar Edicion";
            this.bttn_guardar.UseVisualStyleBackColor = false;
            this.bttn_guardar.Click += new System.EventHandler(this.bttn_guardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btt_Incidente);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.bttn_create);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 667);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_login_MouseDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.button3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button3.Location = new System.Drawing.Point(20, 470);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 62);
            this.button3.TabIndex = 28;
            this.button3.Text = "Registro Cliente";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bttn_create
            // 
            this.bttn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.bttn_create.FlatAppearance.BorderSize = 0;
            this.bttn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_create.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_create.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bttn_create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_create.Location = new System.Drawing.Point(20, 218);
            this.bttn_create.Name = "bttn_create";
            this.bttn_create.Size = new System.Drawing.Size(177, 71);
            this.bttn_create.TabIndex = 25;
            this.bttn_create.Text = "Nuevo incidente";
            this.bttn_create.UseVisualStyleBackColor = false;
            this.bttn_create.Click += new System.EventHandler(this.bttn_create_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 184);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_login_MouseDown);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Turquoise;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(1049, 631);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 39);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1137, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 27);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // iNCIDENTETableAdapter
            // 
            this.iNCIDENTETableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(230, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "ID:";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(234, 40);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(37, 20);
            this.txt_id.TabIndex = 37;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged_1);
            // 
            // sof108DataSet
            // 
            this.sof108DataSet.DataSetName = "sof108DataSet";
            this.sof108DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sof108DataSetBindingSource
            // 
            this.sof108DataSetBindingSource.DataSource = this.sof108DataSet;
            this.sof108DataSetBindingSource.Position = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(232, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Apellido:";
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(236, 227);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(100, 20);
            this.txtcedula.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(234, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Cedula:";
            // 
            // txtapellido
            // 
            this.txtapellido.BackColor = System.Drawing.Color.Honeydew;
            this.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtapellido.Location = new System.Drawing.Point(238, 165);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(138, 22);
            this.txtapellido.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(859, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Comentario";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Turquoise;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(958, 631);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 39);
            this.button4.TabIndex = 40;
            this.button4.Text = "Actualizar tabla";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btt_insr
            // 
            this.btt_insr.BackColor = System.Drawing.Color.Turquoise;
            this.btt_insr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_insr.ForeColor = System.Drawing.Color.Black;
            this.btt_insr.Location = new System.Drawing.Point(348, 628);
            this.btt_insr.Name = "btt_insr";
            this.btt_insr.Size = new System.Drawing.Size(85, 39);
            this.btt_insr.TabIndex = 42;
            this.btt_insr.Text = "Guardar Insercion";
            this.btt_insr.UseVisualStyleBackColor = false;
            this.btt_insr.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // btt_Incidente
            // 
            this.btt_Incidente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btt_Incidente.FlatAppearance.BorderSize = 0;
            this.btt_Incidente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_Incidente.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Incidente.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btt_Incidente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btt_Incidente.Location = new System.Drawing.Point(20, 346);
            this.btt_Incidente.Name = "btt_Incidente";
            this.btt_Incidente.Size = new System.Drawing.Size(177, 71);
            this.btt_Incidente.TabIndex = 29;
            this.btt_Incidente.Text = "Editar incidente";
            this.btt_Incidente.UseVisualStyleBackColor = false;
            this.btt_Incidente.Click += new System.EventHandler(this.btt_Incidente_Click);
            // 
            // dtt_time
            // 
            this.dtt_time.Location = new System.Drawing.Point(628, 141);
            this.dtt_time.Name = "dtt_time";
            this.dtt_time.Size = new System.Drawing.Size(200, 20);
            this.dtt_time.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(626, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Fecha:";
            // 
            // Frm_crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1172, 673);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtt_time);
            this.Controls.Add(this.btt_insr);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.bttn_guardar);
            this.Controls.Add(this.cmb_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.txt_coment);
            this.Controls.Add(this.txt_incident_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_crud";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iNCIDENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sof108DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sof108DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_incident_id;
        private System.Windows.Forms.TextBox txt_coment;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.ComboBox cmb_buscar;
        private System.Windows.Forms.Button bttn_guardar;

        private System.Windows.Forms.Button bttn_create;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource iNCIDENTEBindingSource;
        private sof108DataSetTableAdapters.INCIDENTETableAdapter iNCIDENTETableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.BindingSource sof108DataSetBindingSource;
        private sof108DataSet sof108DataSet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btt_insr;
        private System.Windows.Forms.Button btt_Incidente;
        private System.Windows.Forms.DateTimePicker dtt_time;
        private System.Windows.Forms.Label label4;
    }
}

