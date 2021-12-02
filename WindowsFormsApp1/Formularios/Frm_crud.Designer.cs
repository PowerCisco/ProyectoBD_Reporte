
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            this.txt_name = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.bttn_guardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.bttn_create = new System.Windows.Forms.Button();
            this.btt_erase = new System.Windows.Forms.Button();
            this.btt_acc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.sof108DataSet = new WindowsFormsApp1.sof108DataSet();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter = new WindowsFormsApp1.sof108DataSetTableAdapters.CLIENTETableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEDULADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
            this.button5 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistroIncidente = new System.Windows.Forms.Button();
            this.btnRegistroCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
>>>>>>> eb1123f8b667efe32d28620bd450275187bc6af9
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sof108DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_name.Location = new System.Drawing.Point(266, 76);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(158, 22);
            this.txt_name.TabIndex = 2;
            this.txt_name.Text = "Texto de prueba";
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
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Abierto",
            "En Proceso",
            "Completado",
            "Cancelado"});
            this.comboBox1.Location = new System.Drawing.Point(587, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.aPELLIDODataGridViewTextBoxColumn,
            this.cEDULADataGridViewTextBoxColumn,
            this.tELEFONODataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLIENTEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(266, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(900, 335);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox2.Location = new System.Drawing.Point(266, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 22);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "Texto de prueba";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox3.Location = new System.Drawing.Point(877, 74);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(274, 153);
            this.textBox3.TabIndex = 20;
            this.textBox3.Text = "Texto de prueba";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox5.Location = new System.Drawing.Point(266, 257);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(182, 22);
            this.textBox5.TabIndex = 21;
            this.textBox5.Text = "Texto de prueba";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(454, 257);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 24);
            this.comboBox3.TabIndex = 22;
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
<<<<<<< HEAD
            // bttn_create
            // 
            this.bttn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.bttn_create.FlatAppearance.BorderSize = 0;
            this.bttn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_create.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_create.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bttn_create.Location = new System.Drawing.Point(3, 205);
            this.bttn_create.Name = "bttn_create";
            this.bttn_create.Size = new System.Drawing.Size(177, 71);
            this.bttn_create.TabIndex = 25;
            this.bttn_create.Text = "Nuevo";
            this.bttn_create.UseVisualStyleBackColor = false;
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
            this.btt_erase.Text = "Eliminar";
            this.btt_erase.UseVisualStyleBackColor = false;
            // 
            // btt_acc
            // 
            this.btt_acc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btt_acc.FlatAppearance.BorderSize = 0;
            this.btt_acc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_acc.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.btt_acc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btt_acc.Location = new System.Drawing.Point(3, 412);
            this.btt_acc.Name = "btt_acc";
            this.btt_acc.Size = new System.Drawing.Size(177, 62);
            this.btt_acc.TabIndex = 27;
            this.btt_acc.Text = "Actualizar";
            this.btt_acc.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
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
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 184);
            this.panel2.TabIndex = 0;
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
            // sof108DataSet
            // 
            this.sof108DataSet.DataSetName = "sof108DataSet";
            this.sof108DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.sof108DataSet;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
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
=======
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleGreen;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.button5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button5.Location = new System.Drawing.Point(21, 179);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(205, 70);
            this.button5.TabIndex = 27;
            this.button5.Text = "Buscar Incidente";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Turquoise;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(1063, 628);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 39);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistroIncidente
            // 
            this.btnRegistroIncidente.BackColor = System.Drawing.Color.PaleGreen;
            this.btnRegistroIncidente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroIncidente.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroIncidente.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnRegistroIncidente.Location = new System.Drawing.Point(21, 102);
            this.btnRegistroIncidente.Name = "btnRegistroIncidente";
            this.btnRegistroIncidente.Size = new System.Drawing.Size(205, 71);
            this.btnRegistroIncidente.TabIndex = 29;
            this.btnRegistroIncidente.Text = "Registrar Incidente";
            this.btnRegistroIncidente.UseVisualStyleBackColor = false;
            this.btnRegistroIncidente.Click += new System.EventHandler(this.btnRegistroIncidente_Click);
            // 
            // btnRegistroCliente
            // 
            this.btnRegistroCliente.BackColor = System.Drawing.Color.PaleGreen;
            this.btnRegistroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroCliente.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroCliente.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnRegistroCliente.Location = new System.Drawing.Point(21, 23);
            this.btnRegistroCliente.Name = "btnRegistroCliente";
            this.btnRegistroCliente.Size = new System.Drawing.Size(205, 71);
            this.btnRegistroCliente.TabIndex = 30;
            this.btnRegistroCliente.Text = "Registrar Cliente";
            this.btnRegistroCliente.UseVisualStyleBackColor = false;
            this.btnRegistroCliente.Click += new System.EventHandler(this.button4_Click);
>>>>>>> eb1123f8b667efe32d28620bd450275187bc6af9
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1172, 673);
<<<<<<< HEAD
            this.Controls.Add(this.panel1);
=======
            this.Controls.Add(this.btnRegistroCliente);
            this.Controls.Add(this.btnRegistroIncidente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button5);
>>>>>>> eb1123f8b667efe32d28620bd450275187bc6af9
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bttn_guardar);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_login";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sof108DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button bttn_guardar;
        private System.Windows.Forms.Button button2;
<<<<<<< HEAD
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
=======
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistroIncidente;
        private System.Windows.Forms.Button btnRegistroCliente;
>>>>>>> eb1123f8b667efe32d28620bd450275187bc6af9
    }
}

