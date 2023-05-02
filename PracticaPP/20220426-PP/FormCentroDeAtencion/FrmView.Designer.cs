namespace FormCentroDeAtencion
{
    partial class FrmView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtLegajo = new TextBox();
            cmbTipo = new ComboBox();
            cmbGrupo = new ComboBox();
            dtpHoraIngreso = new DateTimePicker();
            lstEmpleados = new ListBox();
            btnIngresoEmp = new Button();
            btnRetiroEmp = new Button();
            btnImpNomina = new Button();
            lblNombre = new Label();
            lblLegajo = new Label();
            lblTipo = new Label();
            lblHoraIngreso = new Label();
            lblGrupo = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(165, 48);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(125, 27);
            txtLegajo.TabIndex = 1;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(329, 48);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(151, 28);
            cmbTipo.TabIndex = 2;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // cmbGrupo
            // 
            cmbGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrupo.FormattingEnabled = true;
            cmbGrupo.Location = new Point(12, 125);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.Size = new Size(151, 28);
            cmbGrupo.TabIndex = 3;
            // 
            // dtpHoraIngreso
            // 
            dtpHoraIngreso.Format = DateTimePickerFormat.Time;
            dtpHoraIngreso.Location = new Point(526, 49);
            dtpHoraIngreso.Name = "dtpHoraIngreso";
            dtpHoraIngreso.Size = new Size(99, 27);
            dtpHoraIngreso.TabIndex = 4;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 20;
            lstEmpleados.Location = new Point(12, 218);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(468, 164);
            lstEmpleados.TabIndex = 5;
            // 
            // btnIngresoEmp
            // 
            btnIngresoEmp.Location = new Point(12, 183);
            btnIngresoEmp.Name = "btnIngresoEmp";
            btnIngresoEmp.Size = new Size(94, 29);
            btnIngresoEmp.TabIndex = 6;
            btnIngresoEmp.Text = "Ingreso";
            btnIngresoEmp.UseVisualStyleBackColor = true;
            btnIngresoEmp.Click += btnIngresoEmp_Click;
            // 
            // btnRetiroEmp
            // 
            btnRetiroEmp.Location = new Point(386, 183);
            btnRetiroEmp.Name = "btnRetiroEmp";
            btnRetiroEmp.Size = new Size(94, 29);
            btnRetiroEmp.TabIndex = 7;
            btnRetiroEmp.Text = "Retiro";
            btnRetiroEmp.UseVisualStyleBackColor = true;
            btnRetiroEmp.Click += btnRetiroEmp_Click;
            // 
            // btnImpNomina
            // 
            btnImpNomina.Location = new Point(495, 305);
            btnImpNomina.Name = "btnImpNomina";
            btnImpNomina.Size = new Size(179, 77);
            btnImpNomina.TabIndex = 8;
            btnImpNomina.Text = "Imprimir Nomina";
            btnImpNomina.UseVisualStyleBackColor = true;
            btnImpNomina.Click += btnImpNomina_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 23);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre";
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(165, 23);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(54, 20);
            lblLegajo.TabIndex = 10;
            lblLegajo.Text = "Legajo";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(329, 23);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 20);
            lblTipo.TabIndex = 11;
            lblTipo.Text = "Tipo";
            // 
            // lblHoraIngreso
            // 
            lblHoraIngreso.AutoSize = true;
            lblHoraIngreso.Location = new Point(526, 23);
            lblHoraIngreso.Name = "lblHoraIngreso";
            lblHoraIngreso.Size = new Size(95, 20);
            lblHoraIngreso.TabIndex = 12;
            lblHoraIngreso.Text = "Hora Ingreso";
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(12, 102);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(82, 20);
            lblGrupo.TabIndex = 13;
            lblGrupo.Text = "Grupo RAC";
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 393);
            Controls.Add(lblGrupo);
            Controls.Add(lblHoraIngreso);
            Controls.Add(lblTipo);
            Controls.Add(lblLegajo);
            Controls.Add(lblNombre);
            Controls.Add(btnImpNomina);
            Controls.Add(btnRetiroEmp);
            Controls.Add(btnIngresoEmp);
            Controls.Add(lstEmpleados);
            Controls.Add(dtpHoraIngreso);
            Controls.Add(cmbGrupo);
            Controls.Add(cmbTipo);
            Controls.Add(txtLegajo);
            Controls.Add(txtNombre);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtLegajo;
        private ComboBox cmbTipo;
        private ComboBox cmbGrupo;
        private DateTimePicker dtpHoraIngreso;
        private ListBox lstEmpleados;
        private Button btnIngresoEmp;
        private Button btnRetiroEmp;
        private Button btnImpNomina;
        private Label lblNombre;
        private Label lblLegajo;
        private Label lblTipo;
        private Label lblHoraIngreso;
        private Label lblGrupo;
    }
}