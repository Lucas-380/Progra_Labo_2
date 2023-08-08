namespace FormEstacionamiento
{
    partial class Form1
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
            btnAgregar = new Button();
            cmbTipoVehiculo = new ComboBox();
            cmbTipoMoto = new ComboBox();
            txtPatente = new TextBox();
            txtMarca = new TextBox();
            lblTipoVehiculo = new Label();
            lblPatente = new Label();
            lblTipo = new Label();
            txtNombreEstacionamiento = new TextBox();
            lstVehiculos = new ListBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 361);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(171, 77);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar Vehiculo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Location = new Point(120, 34);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(151, 28);
            cmbTipoVehiculo.TabIndex = 1;
            cmbTipoVehiculo.SelectedIndexChanged += cmbTipoVehiculo_SelectedIndexChanged;
            // 
            // cmbTipoMoto
            // 
            cmbTipoMoto.FormattingEnabled = true;
            cmbTipoMoto.Location = new Point(120, 127);
            cmbTipoMoto.Name = "cmbTipoMoto";
            cmbTipoMoto.Size = new Size(151, 28);
            cmbTipoMoto.TabIndex = 2;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(120, 87);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(151, 27);
            txtPatente.TabIndex = 3;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(277, 127);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(151, 27);
            txtMarca.TabIndex = 4;
            // 
            // lblTipoVehiculo
            // 
            lblTipoVehiculo.AutoSize = true;
            lblTipoVehiculo.Location = new Point(12, 37);
            lblTipoVehiculo.Name = "lblTipoVehiculo";
            lblTipoVehiculo.Size = new Size(102, 20);
            lblTipoVehiculo.TabIndex = 5;
            lblTipoVehiculo.Text = "Tipo Vehiculo:";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(12, 87);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(58, 20);
            lblPatente.TabIndex = 6;
            lblPatente.Text = "Patente";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(12, 130);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(79, 20);
            lblTipo.TabIndex = 7;
            lblTipo.Text = "Tipo Moto";
            // 
            // txtNombreEstacionamiento
            // 
            txtNombreEstacionamiento.Location = new Point(473, 30);
            txtNombreEstacionamiento.Name = "txtNombreEstacionamiento";
            txtNombreEstacionamiento.Size = new Size(315, 27);
            txtNombreEstacionamiento.TabIndex = 8;
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.ItemHeight = 20;
            lstVehiculos.Location = new Point(473, 74);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(315, 364);
            lstVehiculos.TabIndex = 9;
            lstVehiculos.DoubleClick += lstVehiculos_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstVehiculos);
            Controls.Add(txtNombreEstacionamiento);
            Controls.Add(lblTipo);
            Controls.Add(lblPatente);
            Controls.Add(lblTipoVehiculo);
            Controls.Add(txtMarca);
            Controls.Add(txtPatente);
            Controls.Add(cmbTipoMoto);
            Controls.Add(cmbTipoVehiculo);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estacionamiento";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private ComboBox cmbTipoVehiculo;
        private ComboBox cmbTipoMoto;
        private TextBox txtPatente;
        private TextBox txtMarca;
        private Label lblTipoVehiculo;
        private Label lblPatente;
        private Label lblTipo;
        private TextBox txtNombreEstacionamiento;
        private ListBox lstVehiculos;
    }
}