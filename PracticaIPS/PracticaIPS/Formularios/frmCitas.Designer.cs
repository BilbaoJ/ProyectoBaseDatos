namespace PracticaIPS
{
    partial class frmCitas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.médicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegistrarCita = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.tbPacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPSDataSet1 = new PracticaIPS.IPSDataSet1();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.tbMedicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPSDataSet = new PracticaIPS.IPSDataSet();
            this.btnCitasIncump = new System.Windows.Forms.Button();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.tbMedicosTableAdapter = new PracticaIPS.IPSDataSetTableAdapters.tbMedicosTableAdapter();
            this.tbPacientesTableAdapter = new PracticaIPS.IPSDataSet1TableAdapters.tbPacientesTableAdapter();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIdBuscarCitas = new System.Windows.Forms.ComboBox();
            this.btnConfirmarCita = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMedicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.médicoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // médicoToolStripMenuItem
            // 
            this.médicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.médicoToolStripMenuItem1,
            this.pacienteToolStripMenuItem});
            this.médicoToolStripMenuItem.Name = "médicoToolStripMenuItem";
            this.médicoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.médicoToolStripMenuItem.Text = "Menú";
            // 
            // médicoToolStripMenuItem1
            // 
            this.médicoToolStripMenuItem1.Name = "médicoToolStripMenuItem1";
            this.médicoToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.médicoToolStripMenuItem1.Text = "Médico";
            this.médicoToolStripMenuItem1.Click += new System.EventHandler(this.médicoToolStripMenuItem1_Click);
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.pacienteToolStripMenuItem.Text = "Paciente";
            this.pacienteToolStripMenuItem.Click += new System.EventHandler(this.pacienteToolStripMenuItem_Click);
            // 
            // btnRegistrarCita
            // 
            this.btnRegistrarCita.Location = new System.Drawing.Point(170, 34);
            this.btnRegistrarCita.Name = "btnRegistrarCita";
            this.btnRegistrarCita.Size = new System.Drawing.Size(124, 23);
            this.btnRegistrarCita.TabIndex = 1;
            this.btnRegistrarCita.Text = "Registrar cita";
            this.btnRegistrarCita.UseVisualStyleBackColor = true;
            this.btnRegistrarCita.Click += new System.EventHandler(this.btnRegistrarCita_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Identificación del paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Identificación del médico";
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFechaCita.Location = new System.Drawing.Point(16, 118);
            this.dtpFechaCita.MinDate = new System.DateTime(2020, 11, 1, 0, 0, 0, 0);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(128, 20);
            this.dtpFechaCita.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha de la cita";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.cmbPaciente);
            this.groupBox1.Controls.Add(this.cmbMedico);
            this.groupBox1.Controls.Add(this.btnCitasIncump);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnRegistrarCita);
            this.groupBox1.Controls.Add(this.dtpFechaCita);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 148);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar cita";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(170, 115);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(124, 23);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPaciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPaciente.DataSource = this.tbPacientesBindingSource;
            this.cmbPaciente.DisplayMember = "Identificacion";
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(16, 36);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(128, 21);
            this.cmbPaciente.TabIndex = 10;
            this.cmbPaciente.ValueMember = "Identificacion";
            // 
            // tbPacientesBindingSource
            // 
            this.tbPacientesBindingSource.DataMember = "tbPacientes";
            this.tbPacientesBindingSource.DataSource = this.iPSDataSet1;
            // 
            // iPSDataSet1
            // 
            this.iPSDataSet1.DataSetName = "IPSDataSet1";
            this.iPSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMedico
            // 
            this.cmbMedico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMedico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMedico.DataSource = this.tbMedicosBindingSource;
            this.cmbMedico.DisplayMember = "Cedula";
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(16, 76);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(128, 21);
            this.cmbMedico.TabIndex = 9;
            this.cmbMedico.ValueMember = "Cedula";
            // 
            // tbMedicosBindingSource
            // 
            this.tbMedicosBindingSource.DataMember = "tbMedicos";
            this.tbMedicosBindingSource.DataSource = this.iPSDataSet;
            // 
            // iPSDataSet
            // 
            this.iPSDataSet.DataSetName = "IPSDataSet";
            this.iPSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCitasIncump
            // 
            this.btnCitasIncump.Location = new System.Drawing.Point(170, 74);
            this.btnCitasIncump.Name = "btnCitasIncump";
            this.btnCitasIncump.Size = new System.Drawing.Size(124, 23);
            this.btnCitasIncump.TabIndex = 8;
            this.btnCitasIncump.Text = "Ver citas incumplidas";
            this.btnCitasIncump.UseVisualStyleBackColor = true;
            this.btnCitasIncump.Click += new System.EventHandler(this.btnCitasIncump_Click);
            // 
            // dgvCitas
            // 
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(13, 263);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.Size = new System.Drawing.Size(416, 200);
            this.dgvCitas.TabIndex = 9;
            this.dgvCitas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitas_RowEnter);
            // 
            // tbMedicosTableAdapter
            // 
            this.tbMedicosTableAdapter.ClearBeforeFill = true;
            // 
            // tbPacientesTableAdapter
            // 
            this.tbPacientesTableAdapter.ClearBeforeFill = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(153, 44);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConfirmarCita);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbIdBuscarCitas);
            this.groupBox2.Controls.Add(this.btnConsultar);
            this.groupBox2.Location = new System.Drawing.Point(13, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 76);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver citas de un paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Identificación";
            // 
            // cmbIdBuscarCitas
            // 
            this.cmbIdBuscarCitas.DataSource = this.tbPacientesBindingSource;
            this.cmbIdBuscarCitas.DisplayMember = "Identificacion";
            this.cmbIdBuscarCitas.FormattingEnabled = true;
            this.cmbIdBuscarCitas.Location = new System.Drawing.Point(6, 46);
            this.cmbIdBuscarCitas.Name = "cmbIdBuscarCitas";
            this.cmbIdBuscarCitas.Size = new System.Drawing.Size(121, 21);
            this.cmbIdBuscarCitas.TabIndex = 12;
            this.cmbIdBuscarCitas.ValueMember = "Identificacion";
            // 
            // btnConfirmarCita
            // 
            this.btnConfirmarCita.Enabled = false;
            this.btnConfirmarCita.Location = new System.Drawing.Point(245, 44);
            this.btnConfirmarCita.Name = "btnConfirmarCita";
            this.btnConfirmarCita.Size = new System.Drawing.Size(104, 23);
            this.btnConfirmarCita.TabIndex = 14;
            this.btnConfirmarCita.Text = "Confirmar cita";
            this.btnConfirmarCita.UseVisualStyleBackColor = true;
            this.btnConfirmarCita.Click += new System.EventHandler(this.btnConfirmarCita_Click);
            // 
            // frmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 475);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvCitas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCitas";
            this.Text = "IPS";
            this.Load += new System.EventHandler(this.frmCitas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMedicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem médicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.Button btnRegistrarCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.Button btnCitasIncump;
        private System.Windows.Forms.ComboBox cmbMedico;
        private IPSDataSet iPSDataSet;
        private System.Windows.Forms.BindingSource tbMedicosBindingSource;
        private IPSDataSetTableAdapters.tbMedicosTableAdapter tbMedicosTableAdapter;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private IPSDataSet1 iPSDataSet1;
        private System.Windows.Forms.BindingSource tbPacientesBindingSource;
        private IPSDataSet1TableAdapters.tbPacientesTableAdapter tbPacientesTableAdapter;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbIdBuscarCitas;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmarCita;
    }
}