namespace Ejercicio_I02
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
            lblLitro = new Label();
            label2 = new Label();
            txtLitros = new TextBox();
            txtKilometros = new TextBox();
            btnCalcular = new Button();
            rtbCalculador = new RichTextBox();
            SuspendLayout();
            // 
            // lblLitro
            // 
            lblLitro.AutoSize = true;
            lblLitro.Location = new Point(12, 74);
            lblLitro.Name = "lblLitro";
            lblLitro.Size = new Size(36, 15);
            lblLitro.TabIndex = 0;
            lblLitro.Text = "Litros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Kilometros";
            // 
            // txtLitros
            // 
            txtLitros.Location = new Point(12, 92);
            txtLitros.Name = "txtLitros";
            txtLitros.Size = new Size(171, 23);
            txtLitros.TabIndex = 2;
            // 
            // txtKilometros
            // 
            txtKilometros.Location = new Point(12, 36);
            txtKilometros.Name = "txtKilometros";
            txtKilometros.Size = new Size(171, 23);
            txtKilometros.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 143);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(171, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // rtbCalculador
            // 
            rtbCalculador.Location = new Point(234, 12);
            rtbCalculador.Name = "rtbCalculador";
            rtbCalculador.Size = new Size(190, 154);
            rtbCalculador.TabIndex = 5;
            rtbCalculador.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 186);
            Controls.Add(rtbCalculador);
            Controls.Add(btnCalcular);
            Controls.Add(txtKilometros);
            Controls.Add(txtLitros);
            Controls.Add(label2);
            Controls.Add(lblLitro);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLitro;
        private Label label2;
        private TextBox txtLitros;
        private TextBox txtKilometros;
        private Button btnCalcular;
        private RichTextBox rtbCalculador;
    }
}