
namespace WindowsFormsApp1
{
    partial class Frm_login
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            this.txt_name = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEDULADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sof108DataSet = new WindowsFormsApp1.sof108DataSet();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_incident = new System.Windows.Forms.TextBox();
            this.txt_coment = new System.Windows.Forms.TextBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.cmb_buscar = new System.Windows.Forms.ComboBox();
            this.bttn_guardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btt_erase = new System.Windows.Forms.Button();
            this.btt_acc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bttn_create = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cLIENTETableAdapter = new WindowsFormsApp1.sof108DataSetTableAdapters.CLIENTETableAdapter();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sof108DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.Honeydew;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_name.Location = new System.Drawing.Point(266, 76);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(158, 22);
            this.txt_name.TabIndex = 2;
            this.txt_name.Text = "Texto de prueba";
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.MediumTurquoise;
            this.dateTimePicker1.Location = new System.Drawing.Point(587, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            this.cmb_status.Location = new System.Drawing.Point(587, 164);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(100, 24);
            this.cmb_status.TabIndex = 5;
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.AllowUserToResizeColumns = false;
            this.dgv_datos.AllowUserToResizeRows = false;
            this.dgv_datos.AutoGenerateColumns = false;
            this.dgv_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.aPELLIDODataGridViewTextBoxColumn,
            this.cEDULADataGridViewTextBoxColumn,
            this.tELEFONODataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn});
            this.dgv_datos.DataSource = this.cLIENTEBindingSource;
            this.dgv_datos.Location = new System.Drawing.Point(266, 298);
            this.dgv_datos.Name = "dgv_datos";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_datos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_datos.Size = new System.Drawing.Size(885, 300);
            this.dgv_datos.TabIndex = 7;
            this.dgv_datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            // 
            // aPELLIDODataGridViewTextBoxColumn
            // 
            this.aPELLIDODataGridViewTextBoxColumn.DataPropertyName = "APELLIDO";
            this.aPELLIDODataGridViewTextBoxColumn.HeaderText = "APELLIDO";
            this.aPELLIDODataGridViewTextBoxColumn.Name = "aPELLIDODataGridViewTextBoxColumn";
            // 
            // cEDULADataGridViewTextBoxColumn
            // 
            this.cEDULADataGridViewTextBoxColumn.DataPropertyName = "CEDULA";
            this.cEDULADataGridViewTextBoxColumn.HeaderText = "CEDULA";
            this.cEDULADataGridViewTextBoxColumn.Name = "cEDULADataGridViewTextBoxColumn";
            // 
            // tELEFONODataGridViewTextBoxColumn
            // 
            this.tELEFONODataGridViewTextBoxColumn.DataPropertyName = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.HeaderText = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.Name = "tELEFONODataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.sof108DataSet;
            // 
            // sof108DataSet
            // 
            this.sof108DataSet.DataSetName = "sof108DataSet";
            this.sof108DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(266, 51);
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
            this.label3.Location = new System.Drawing.Point(266, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Incidente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(583, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(584, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(873, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Comentario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(266, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Buscar:";
            // 
            // txt_incident
            // 
            this.txt_incident.BackColor = System.Drawing.Color.Honeydew;
            this.txt_incident.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_incident.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_incident.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_incident.Location = new System.Drawing.Point(266, 165);
            this.txt_incident.Name = "txt_incident";
            this.txt_incident.Size = new System.Drawing.Size(158, 22);
            this.txt_incident.TabIndex = 19;
            this.txt_incident.Text = "Texto de prueba";
            // 
            // txt_coment
            // 
            this.txt_coment.BackColor = System.Drawing.Color.Honeydew;
            this.txt_coment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_coment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coment.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_coment.Location = new System.Drawing.Point(877, 74);
            this.txt_coment.Multiline = true;
            this.txt_coment.Name = "txt_coment";
            this.txt_coment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_coment.Size = new System.Drawing.Size(274, 153);
            this.txt_coment.TabIndex = 20;
            this.txt_coment.Text = "Texto de prueba";
            this.txt_coment.TextChanged += new System.EventHandler(this.txt_coment_TextChanged);
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.Color.Honeydew;
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_buscar.Location = new System.Drawing.Point(266, 257);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(182, 22);
            this.txt_buscar.TabIndex = 21;
            this.txt_buscar.Text = "Texto de prueba";
            // 
            // cmb_buscar
            // 
            this.cmb_buscar.BackColor = System.Drawing.Color.Honeydew;
            this.cmb_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmb_buscar.FormattingEnabled = true;
            this.cmb_buscar.Location = new System.Drawing.Point(454, 257);
            this.cmb_buscar.Name = "cmb_buscar";
            this.cmb_buscar.Size = new System.Drawing.Size(100, 24);
            this.cmb_buscar.TabIndex = 22;
            // 
            // bttn_guardar
            // 
            this.bttn_guardar.BackColor = System.Drawing.Color.Turquoise;
            this.bttn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_guardar.ForeColor = System.Drawing.Color.Black;
            this.bttn_guardar.Location = new System.Drawing.Point(266, 628);
            this.bttn_guardar.Name = "bttn_guardar";
            this.bttn_guardar.Size = new System.Drawing.Size(85, 39);
            this.bttn_guardar.TabIndex = 23;
            this.bttn_guardar.Text = "Guardar";
            this.bttn_guardar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(375, 628);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 39);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btt_erase
            // 
            this.btt_erase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btt_erase.FlatAppearance.BorderSize = 0;
            this.btt_erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_erase.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.btt_erase.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btt_erase.Location = new System.Drawing.Point(3, 295);
            this.btt_erase.Name = "btt_erase";
            this.btt_erase.Size = new System.Drawing.Size(177, 71);
            this.btt_erase.TabIndex = 26;
            this.btt_erase.Text = "Eliminar incidente";
            this.btt_erase.UseVisualStyleBackColor = false;
            this.btt_erase.Click += new System.EventHandler(this.btt_erase_Click);
            // 
            // btt_acc
            // 
            this.btt_acc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btt_acc.FlatAppearance.BorderSize = 0;
            this.btt_acc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_acc.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.btt_acc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btt_acc.Location = new System.Drawing.Point(0, 440);
            this.btt_acc.Name = "btt_acc";
            this.btt_acc.Size = new System.Drawing.Size(177, 62);
            this.btt_acc.TabIndex = 27;
            this.btt_acc.Text = "Editar incidente";
            this.btt_acc.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.bttn_create);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btt_acc);
            this.panel1.Controls.Add(this.btt_erase);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 667);
            this.panel1.TabIndex = 28;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.button4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button4.Location = new System.Drawing.Point(3, 508);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 62);
            this.button4.TabIndex = 29;
            this.button4.Text = "Historial";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.button3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button3.Location = new System.Drawing.Point(3, 372);
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
            this.bttn_create.Location = new System.Drawing.Point(0, 218);
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
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Turquoise;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(821, 628);
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
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1172, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bttn_guardar);
            this.Controls.Add(this.cmb_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.txt_coment);
            this.Controls.Add(this.txt_incident);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_login";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sof108DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_incident;
        private System.Windows.Forms.TextBox txt_coment;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.ComboBox cmb_buscar;
        private System.Windows.Forms.Button bttn_guardar;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button bttn_create;
        private System.Windows.Forms.Button btt_erase;
        private System.Windows.Forms.Button btt_acc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private sof108DataSet sof108DataSet;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private sof108DataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEDULADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

