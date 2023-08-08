namespace FormPersona
{
    partial class frmPersonas
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
            lstPersonas = new ListBox();
            btnGuardar = new Button();
            txtApellido = new TextBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLeer = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(139, 23);
            txtNombre.TabIndex = 0;
            // 
            // lstPersonas
            // 
            lstPersonas.FormattingEnabled = true;
            lstPersonas.ItemHeight = 15;
            lstPersonas.Location = new Point(173, 25);
            lstPersonas.Name = "lstPersonas";
            lstPersonas.Size = new Size(297, 229);
            lstPersonas.TabIndex = 2;
            lstPersonas.DoubleClick += lstPersonas_DoubleClick;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 139);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(139, 23);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(12, 77);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(139, 23);
            txtApellido.TabIndex = 4;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(12, 168);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(139, 23);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 197);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(12, 226);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(139, 23);
            btnLeer.TabIndex = 7;
            btnLeer.Text = "Leer";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Apellido";
            // 
            // frmPersonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 263);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLeer);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(txtApellido);
            Controls.Add(btnGuardar);
            Controls.Add(lstPersonas);
            Controls.Add(txtNombre);
            Name = "frmPersonas";
            Text = "Personas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private ListBox lstPersonas;
        private Button btnGuardar;
        private TextBox txtApellido;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLeer;
        private Label label1;
        private Label label2;
    }
}