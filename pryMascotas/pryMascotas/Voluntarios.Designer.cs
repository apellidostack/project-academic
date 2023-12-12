namespace pryMascotas
{
    partial class Voluntarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrarVoluntario = new System.Windows.Forms.Button();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.txtCarnetVoluntario = new System.Windows.Forms.TextBox();
            this.txtTelefonoV = new System.Windows.Forms.TextBox();
            this.txtDireccionV = new System.Windows.Forms.TextBox();
            this.txtMaternoV = new System.Windows.Forms.TextBox();
            this.txtPaternoV = new System.Windows.Forms.TextBox();
            this.txtNombreV = new System.Windows.Forms.TextBox();
            this.lbFechaNac = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvvoluntarios = new System.Windows.Forms.DataGridView();
            this.codVoluntarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direcciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teléfonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voluntarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSbdadopciones = new pryMascotas.DSbdadopciones();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.voluntarioTableAdapter = new pryMascotas.DSbdadopcionesTableAdapters.voluntarioTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvoluntarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voluntarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSbdadopciones)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.btnRegistrarVoluntario);
            this.panel1.Controls.Add(this.rbFemenino);
            this.panel1.Controls.Add(this.rbMasculino);
            this.panel1.Controls.Add(this.txtCarnetVoluntario);
            this.panel1.Controls.Add(this.txtTelefonoV);
            this.panel1.Controls.Add(this.txtDireccionV);
            this.panel1.Controls.Add(this.txtMaternoV);
            this.panel1.Controls.Add(this.txtPaternoV);
            this.panel1.Controls.Add(this.txtNombreV);
            this.panel1.Controls.Add(this.lbFechaNac);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 625);
            this.panel1.TabIndex = 0;
            // 
            // btnRegistrarVoluntario
            // 
            this.btnRegistrarVoluntario.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRegistrarVoluntario.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVoluntario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarVoluntario.Location = new System.Drawing.Point(66, 537);
            this.btnRegistrarVoluntario.Name = "btnRegistrarVoluntario";
            this.btnRegistrarVoluntario.Size = new System.Drawing.Size(169, 57);
            this.btnRegistrarVoluntario.TabIndex = 61;
            this.btnRegistrarVoluntario.Text = "Registrar Voluntario";
            this.btnRegistrarVoluntario.UseVisualStyleBackColor = false;
            this.btnRegistrarVoluntario.Click += new System.EventHandler(this.btnRegistrarVoluntario_Click);
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(137, 250);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 60;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(56, 250);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 59;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // txtCarnetVoluntario
            // 
            this.txtCarnetVoluntario.Location = new System.Drawing.Point(55, 293);
            this.txtCarnetVoluntario.Name = "txtCarnetVoluntario";
            this.txtCarnetVoluntario.Size = new System.Drawing.Size(148, 20);
            this.txtCarnetVoluntario.TabIndex = 58;
            // 
            // txtTelefonoV
            // 
            this.txtTelefonoV.Location = new System.Drawing.Point(58, 209);
            this.txtTelefonoV.Name = "txtTelefonoV";
            this.txtTelefonoV.Size = new System.Drawing.Size(150, 20);
            this.txtTelefonoV.TabIndex = 57;
            // 
            // txtDireccionV
            // 
            this.txtDireccionV.Location = new System.Drawing.Point(58, 170);
            this.txtDireccionV.Name = "txtDireccionV";
            this.txtDireccionV.Size = new System.Drawing.Size(211, 20);
            this.txtDireccionV.TabIndex = 56;
            // 
            // txtMaternoV
            // 
            this.txtMaternoV.Location = new System.Drawing.Point(58, 130);
            this.txtMaternoV.Name = "txtMaternoV";
            this.txtMaternoV.Size = new System.Drawing.Size(150, 20);
            this.txtMaternoV.TabIndex = 55;
            // 
            // txtPaternoV
            // 
            this.txtPaternoV.Location = new System.Drawing.Point(58, 91);
            this.txtPaternoV.Name = "txtPaternoV";
            this.txtPaternoV.Size = new System.Drawing.Size(150, 20);
            this.txtPaternoV.TabIndex = 54;
            // 
            // txtNombreV
            // 
            this.txtNombreV.Location = new System.Drawing.Point(58, 50);
            this.txtNombreV.Name = "txtNombreV";
            this.txtNombreV.Size = new System.Drawing.Size(177, 20);
            this.txtNombreV.TabIndex = 43;
            // 
            // lbFechaNac
            // 
            this.lbFechaNac.AutoSize = true;
            this.lbFechaNac.Location = new System.Drawing.Point(52, 341);
            this.lbFechaNac.Name = "lbFechaNac";
            this.lbFechaNac.Size = new System.Drawing.Size(16, 13);
            this.lbFechaNac.TabIndex = 53;
            this.lbFechaNac.Text = "...";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(35, 363);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 52;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Italic);
            this.label10.Location = new System.Drawing.Point(52, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 14);
            this.label10.TabIndex = 51;
            this.label10.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(52, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 14);
            this.label2.TabIndex = 50;
            this.label2.Text = "Carnet de Voluntario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(55, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 49;
            this.label3.Text = "Sexo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Italic);
            this.label11.Location = new System.Drawing.Point(55, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 14);
            this.label11.TabIndex = 48;
            this.label11.Text = "Telefono";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Italic);
            this.label12.Location = new System.Drawing.Point(55, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 14);
            this.label12.TabIndex = 47;
            this.label12.Text = "Direccion";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Italic);
            this.label13.Location = new System.Drawing.Point(53, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 14);
            this.label13.TabIndex = 46;
            this.label13.Text = "Apellido Materno";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Italic);
            this.label14.Location = new System.Drawing.Point(55, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 14);
            this.label14.TabIndex = 44;
            this.label14.Text = "Nombre";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Italic);
            this.label15.Location = new System.Drawing.Point(55, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 14);
            this.label15.TabIndex = 45;
            this.label15.Text = "Apellido Paterno";
            // 
            // dgvvoluntarios
            // 
            this.dgvvoluntarios.AllowUserToAddRows = false;
            this.dgvvoluntarios.AutoGenerateColumns = false;
            this.dgvvoluntarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvoluntarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codVoluntarioDataGridViewTextBoxColumn,
            this.apellidoMaternoDataGridViewTextBoxColumn,
            this.apellidoPaternoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direcciónDataGridViewTextBoxColumn,
            this.teléfonoDataGridViewTextBoxColumn,
            this.cIDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.idPersonalDataGridViewTextBoxColumn});
            this.dgvvoluntarios.DataSource = this.voluntarioBindingSource;
            this.dgvvoluntarios.Location = new System.Drawing.Point(24, 114);
            this.dgvvoluntarios.Name = "dgvvoluntarios";
            this.dgvvoluntarios.ReadOnly = true;
            this.dgvvoluntarios.Size = new System.Drawing.Size(451, 435);
            this.dgvvoluntarios.TabIndex = 1;
            // 
            // codVoluntarioDataGridViewTextBoxColumn
            // 
            this.codVoluntarioDataGridViewTextBoxColumn.DataPropertyName = "codVoluntario";
            this.codVoluntarioDataGridViewTextBoxColumn.HeaderText = "codVoluntario";
            this.codVoluntarioDataGridViewTextBoxColumn.Name = "codVoluntarioDataGridViewTextBoxColumn";
            this.codVoluntarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoMaternoDataGridViewTextBoxColumn
            // 
            this.apellidoMaternoDataGridViewTextBoxColumn.DataPropertyName = "apellidoMaterno";
            this.apellidoMaternoDataGridViewTextBoxColumn.HeaderText = "apellidoMaterno";
            this.apellidoMaternoDataGridViewTextBoxColumn.Name = "apellidoMaternoDataGridViewTextBoxColumn";
            this.apellidoMaternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoPaternoDataGridViewTextBoxColumn
            // 
            this.apellidoPaternoDataGridViewTextBoxColumn.DataPropertyName = "apellidoPaterno";
            this.apellidoPaternoDataGridViewTextBoxColumn.HeaderText = "apellidoPaterno";
            this.apellidoPaternoDataGridViewTextBoxColumn.Name = "apellidoPaternoDataGridViewTextBoxColumn";
            this.apellidoPaternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direcciónDataGridViewTextBoxColumn
            // 
            this.direcciónDataGridViewTextBoxColumn.DataPropertyName = "dirección";
            this.direcciónDataGridViewTextBoxColumn.HeaderText = "dirección";
            this.direcciónDataGridViewTextBoxColumn.Name = "direcciónDataGridViewTextBoxColumn";
            this.direcciónDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teléfonoDataGridViewTextBoxColumn
            // 
            this.teléfonoDataGridViewTextBoxColumn.DataPropertyName = "teléfono";
            this.teléfonoDataGridViewTextBoxColumn.HeaderText = "teléfono";
            this.teléfonoDataGridViewTextBoxColumn.Name = "teléfonoDataGridViewTextBoxColumn";
            this.teléfonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cIDataGridViewTextBoxColumn
            // 
            this.cIDataGridViewTextBoxColumn.DataPropertyName = "CI";
            this.cIDataGridViewTextBoxColumn.HeaderText = "CI";
            this.cIDataGridViewTextBoxColumn.Name = "cIDataGridViewTextBoxColumn";
            this.cIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "fechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPersonalDataGridViewTextBoxColumn
            // 
            this.idPersonalDataGridViewTextBoxColumn.DataPropertyName = "idPersonal";
            this.idPersonalDataGridViewTextBoxColumn.HeaderText = "idPersonal";
            this.idPersonalDataGridViewTextBoxColumn.Name = "idPersonalDataGridViewTextBoxColumn";
            this.idPersonalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // voluntarioBindingSource
            // 
            this.voluntarioBindingSource.DataMember = "voluntario";
            this.voluntarioBindingSource.DataSource = this.dSbdadopciones;
            // 
            // dSbdadopciones
            // 
            this.dSbdadopciones.DataSetName = "DSbdadopciones";
            this.dSbdadopciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dgvvoluntarios);
            this.panel2.Location = new System.Drawing.Point(337, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 625);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(160, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "VOLUNTARIO";
            // 
            // voluntarioTableAdapter
            // 
            this.voluntarioTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryMascotas.Properties.Resources.IMPRESORA_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(425, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 3;
            // 
            // Voluntarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 625);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Voluntarios";
            this.Text = "Voluntarios";
            this.Load += new System.EventHandler(this.Voluntarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvoluntarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voluntarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSbdadopciones)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegistrarVoluntario;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.TextBox txtCarnetVoluntario;
        private System.Windows.Forms.TextBox txtTelefonoV;
        private System.Windows.Forms.TextBox txtDireccionV;
        private System.Windows.Forms.TextBox txtMaternoV;
        private System.Windows.Forms.TextBox txtPaternoV;
        private System.Windows.Forms.TextBox txtNombreV;
        private System.Windows.Forms.Label lbFechaNac;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvvoluntarios;
        private System.Windows.Forms.Panel panel2;
        private DSbdadopciones dSbdadopciones;
        private System.Windows.Forms.BindingSource voluntarioBindingSource;
        private DSbdadopcionesTableAdapters.voluntarioTableAdapter voluntarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVoluntarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direcciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teléfonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
    }
}