namespace FormRpp
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
            txtDniCliente = new TextBox();
            lstHamburguesas = new ListBox();
            grpIngredientes = new GroupBox();
            btnAgregarIngrediente = new Button();
            cmbIngredientes = new ComboBox();
            rdbGuarnicion = new RadioButton();
            rdbHamburguesa = new RadioButton();
            lblIngredientes = new Label();
            cmbGuarnicion = new ComboBox();
            lblHamburguesa = new Label();
            lblGuarnicion = new Label();
            rchTicket = new RichTextBox();
            btnAgregarGuarnicion = new Button();
            grpIngredientes.SuspendLayout();
            SuspendLayout();
            // 
            // txtDniCliente
            // 
            txtDniCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDniCliente.Location = new Point(12, 22);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.PlaceholderText = "Dni del cliente";
            txtDniCliente.Size = new Size(158, 29);
            txtDniCliente.TabIndex = 0;
            txtDniCliente.TextChanged += txtDniCliente_TextChanged;
            txtDniCliente.Leave += txtDniCliente_Leave;
            // 
            // lstHamburguesas
            // 
            lstHamburguesas.FormattingEnabled = true;
            lstHamburguesas.ItemHeight = 15;
            lstHamburguesas.Location = new Point(12, 90);
            lstHamburguesas.Name = "lstHamburguesas";
            lstHamburguesas.Size = new Size(269, 94);
            lstHamburguesas.TabIndex = 1;
            lstHamburguesas.MouseClick += lstHamburguesas_MouseClick;
            // 
            // grpIngredientes
            // 
            grpIngredientes.Controls.Add(btnAgregarIngrediente);
            grpIngredientes.Controls.Add(cmbIngredientes);
            grpIngredientes.Controls.Add(rdbGuarnicion);
            grpIngredientes.Controls.Add(rdbHamburguesa);
            grpIngredientes.Controls.Add(lblIngredientes);
            grpIngredientes.Location = new Point(297, 70);
            grpIngredientes.Name = "grpIngredientes";
            grpIngredientes.Size = new Size(285, 192);
            grpIngredientes.TabIndex = 2;
            grpIngredientes.TabStop = false;
            grpIngredientes.Text = "Ingredientes";
            // 
            // btnAgregarIngrediente
            // 
            btnAgregarIngrediente.Location = new Point(237, 151);
            btnAgregarIngrediente.Name = "btnAgregarIngrediente";
            btnAgregarIngrediente.Size = new Size(35, 35);
            btnAgregarIngrediente.TabIndex = 10;
            btnAgregarIngrediente.Text = "+";
            btnAgregarIngrediente.UseVisualStyleBackColor = true;
            btnAgregarIngrediente.Click += btnAgregarIngrediente_Click;
            // 
            // cmbIngredientes
            // 
            cmbIngredientes.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cmbIngredientes.FormattingEnabled = true;
            cmbIngredientes.Location = new Point(6, 151);
            cmbIngredientes.Name = "cmbIngredientes";
            cmbIngredientes.Size = new Size(225, 33);
            cmbIngredientes.TabIndex = 9;
            // 
            // rdbGuarnicion
            // 
            rdbGuarnicion.AutoSize = true;
            rdbGuarnicion.Location = new Point(22, 66);
            rdbGuarnicion.Name = "rdbGuarnicion";
            rdbGuarnicion.Size = new Size(83, 19);
            rdbGuarnicion.TabIndex = 8;
            rdbGuarnicion.TabStop = true;
            rdbGuarnicion.Text = "Guarnicion";
            rdbGuarnicion.UseVisualStyleBackColor = true;
            // 
            // rdbHamburguesa
            // 
            rdbHamburguesa.AutoSize = true;
            rdbHamburguesa.Location = new Point(22, 32);
            rdbHamburguesa.Name = "rdbHamburguesa";
            rdbHamburguesa.Size = new Size(100, 19);
            rdbHamburguesa.TabIndex = 7;
            rdbHamburguesa.TabStop = true;
            rdbHamburguesa.Text = "Hamburguesa";
            rdbHamburguesa.UseVisualStyleBackColor = true;
            // 
            // lblIngredientes
            // 
            lblIngredientes.AutoSize = true;
            lblIngredientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngredientes.Location = new Point(6, 127);
            lblIngredientes.Name = "lblIngredientes";
            lblIngredientes.Size = new Size(110, 21);
            lblIngredientes.TabIndex = 6;
            lblIngredientes.Text = "Ingredientes:";
            // 
            // cmbGuarnicion
            // 
            cmbGuarnicion.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGuarnicion.FormattingEnabled = true;
            cmbGuarnicion.Location = new Point(12, 222);
            cmbGuarnicion.Name = "cmbGuarnicion";
            cmbGuarnicion.Size = new Size(225, 33);
            cmbGuarnicion.TabIndex = 3;
            cmbGuarnicion.SelectedIndexChanged += cmbGuarnicion_SelectedIndexChanged;
            // 
            // lblHamburguesa
            // 
            lblHamburguesa.AutoSize = true;
            lblHamburguesa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHamburguesa.Location = new Point(12, 67);
            lblHamburguesa.Name = "lblHamburguesa";
            lblHamburguesa.Size = new Size(226, 21);
            lblHamburguesa.TabIndex = 4;
            lblHamburguesa.Text = "Seleccione su hamburguesa:";
            // 
            // lblGuarnicion
            // 
            lblGuarnicion.AutoSize = true;
            lblGuarnicion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGuarnicion.Location = new Point(12, 198);
            lblGuarnicion.Name = "lblGuarnicion";
            lblGuarnicion.Size = new Size(204, 21);
            lblGuarnicion.TabIndex = 5;
            lblGuarnicion.Text = "Seleccione su guarnicion:";
            // 
            // rchTicket
            // 
            rchTicket.Location = new Point(12, 275);
            rchTicket.Name = "rchTicket";
            rchTicket.Size = new Size(570, 174);
            rchTicket.TabIndex = 6;
            rchTicket.Text = "";
            // 
            // btnAgregarGuarnicion
            // 
            btnAgregarGuarnicion.Location = new Point(243, 222);
            btnAgregarGuarnicion.Name = "btnAgregarGuarnicion";
            btnAgregarGuarnicion.Size = new Size(35, 35);
            btnAgregarGuarnicion.TabIndex = 7;
            btnAgregarGuarnicion.Text = "+";
            btnAgregarGuarnicion.UseVisualStyleBackColor = true;
            btnAgregarGuarnicion.Click += btnAgregarGuarnicion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 461);
            Controls.Add(btnAgregarGuarnicion);
            Controls.Add(rchTicket);
            Controls.Add(lblGuarnicion);
            Controls.Add(lblHamburguesa);
            Controls.Add(cmbGuarnicion);
            Controls.Add(grpIngredientes);
            Controls.Add(lstHamburguesas);
            Controls.Add(txtDniCliente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hamburgueseria Dure Div 2C";
            Load += Form1_Load;
            grpIngredientes.ResumeLayout(false);
            grpIngredientes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDniCliente;
        private ListBox lstHamburguesas;
        private GroupBox grpIngredientes;
        private Button btnAgregarIngrediente;
        private ComboBox cmbIngredientes;
        private RadioButton rdbGuarnicion;
        private RadioButton rdbHamburguesa;
        private Label lblIngredientes;
        private ComboBox cmbGuarnicion;
        private Label lblHamburguesa;
        private Label lblGuarnicion;
        private RichTextBox rchTicket;
        private Button btnAgregarGuarnicion;
    }
}