namespace FormTaller
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
            cmbTipoVehiculo = new ComboBox();
            cmbReparacion = new ComboBox();
            cmbTipoMoto = new ComboBox();
            txtPatente = new TextBox();
            txtMarca = new TextBox();
            btnAgregar = new Button();
            btnRetirar = new Button();
            rchtListadoVehiculos = new RichTextBox();
            lblPatente = new Label();
            lblReparacion = new Label();
            lblTipoVehiculo = new Label();
            lblMarca = new Label();
            SuspendLayout();
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Location = new Point(233, 60);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(151, 28);
            cmbTipoVehiculo.TabIndex = 0;
            cmbTipoVehiculo.SelectedIndexChanged += cmbTipoVehiculo_SelectedIndexChanged;
            // 
            // cmbReparacion
            // 
            cmbReparacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReparacion.FormattingEnabled = true;
            cmbReparacion.Location = new Point(26, 155);
            cmbReparacion.Name = "cmbReparacion";
            cmbReparacion.Size = new Size(151, 28);
            cmbReparacion.TabIndex = 1;
            // 
            // cmbTipoMoto
            // 
            cmbTipoMoto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMoto.FormattingEnabled = true;
            cmbTipoMoto.Location = new Point(450, 94);
            cmbTipoMoto.Name = "cmbTipoMoto";
            cmbTipoMoto.Size = new Size(151, 28);
            cmbTipoMoto.TabIndex = 2;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(26, 61);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(151, 27);
            txtPatente.TabIndex = 3;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(450, 61);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(151, 27);
            txtMarca.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 284);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(507, 284);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(94, 29);
            btnRetirar.TabIndex = 6;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // rchtListadoVehiculos
            // 
            rchtListadoVehiculos.Location = new Point(12, 319);
            rchtListadoVehiculos.Name = "rchtListadoVehiculos";
            rchtListadoVehiculos.Size = new Size(589, 186);
            rchtListadoVehiculos.TabIndex = 7;
            rchtListadoVehiculos.Text = "";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(26, 38);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(58, 20);
            lblPatente.TabIndex = 8;
            lblPatente.Text = "Patente";
            // 
            // lblReparacion
            // 
            lblReparacion.AutoSize = true;
            lblReparacion.Location = new Point(26, 132);
            lblReparacion.Name = "lblReparacion";
            lblReparacion.Size = new Size(84, 20);
            lblReparacion.TabIndex = 9;
            lblReparacion.Text = "Reparación";
            // 
            // lblTipoVehiculo
            // 
            lblTipoVehiculo.AutoSize = true;
            lblTipoVehiculo.Location = new Point(233, 38);
            lblTipoVehiculo.Name = "lblTipoVehiculo";
            lblTipoVehiculo.Size = new Size(99, 20);
            lblTipoVehiculo.TabIndex = 10;
            lblTipoVehiculo.Text = "Tipo Vehiculo";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(450, 38);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(50, 20);
            lblMarca.TabIndex = 11;
            lblMarca.Text = "Marca";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 517);
            Controls.Add(lblMarca);
            Controls.Add(lblTipoVehiculo);
            Controls.Add(lblReparacion);
            Controls.Add(lblPatente);
            Controls.Add(rchtListadoVehiculos);
            Controls.Add(btnRetirar);
            Controls.Add(btnAgregar);
            Controls.Add(txtMarca);
            Controls.Add(txtPatente);
            Controls.Add(cmbTipoMoto);
            Controls.Add(cmbReparacion);
            Controls.Add(cmbTipoVehiculo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipoVehiculo;
        private ComboBox cmbReparacion;
        private ComboBox cmbTipoMoto;
        private TextBox txtPatente;
        private TextBox txtMarca;
        private Button btnAgregar;
        private Button btnRetirar;
        private RichTextBox rchtListadoVehiculos;
        private Label lblPatente;
        private Label lblReparacion;
        private Label lblTipoVehiculo;
        private Label lblMarca;
    }
}