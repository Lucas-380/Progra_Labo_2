namespace Ejercicio_23
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCandado = new Button();
            imlCandado = new ImageList(components);
            textCotizacionEuro = new TextBox();
            textCotizacionPeso = new TextBox();
            textCotizacionDolar = new TextBox();
            labelCotizacion = new Label();
            label1 = new Label();
            labelPeso = new Label();
            labelDolar = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEuroAEuro = new TextBox();
            txtDolarAEuro = new TextBox();
            txtPesoAEuro = new TextBox();
            txtPesoADolar = new TextBox();
            txtDolarADolar = new TextBox();
            txtEuroADolar = new TextBox();
            txtPesoAPeso = new TextBox();
            txtDolarAPeso = new TextBox();
            txtEuroAPeso = new TextBox();
            btnConvertEuro = new Button();
            btnConvertDolar = new Button();
            btnConvertPeso = new Button();
            txtPeso = new TextBox();
            txtDolar = new TextBox();
            txtEuro = new TextBox();
            SuspendLayout();
            // 
            // btnCandado
            // 
            btnCandado.ImageIndex = 1;
            btnCandado.ImageList = imlCandado;
            btnCandado.Location = new Point(279, 25);
            btnCandado.Name = "btnCandado";
            btnCandado.Size = new Size(102, 49);
            btnCandado.TabIndex = 0;
            btnCandado.UseVisualStyleBackColor = true;
            btnCandado.Click += btnCandado_Click;
            // 
            // imlCandado
            // 
            imlCandado.ColorDepth = ColorDepth.Depth32Bit;
            imlCandado.ImageStream = (ImageListStreamer)resources.GetObject("imlCandado.ImageStream");
            imlCandado.TransparentColor = Color.Transparent;
            imlCandado.Images.SetKeyName(0, "internet_lock_locked_padlock_password_secure_security_icon_127078.png");
            imlCandado.Images.SetKeyName(1, "internet_locked_padlock_password_secure_security_unlock_icon_127083.png");
            // 
            // textCotizacionEuro
            // 
            textCotizacionEuro.Location = new Point(420, 36);
            textCotizacionEuro.Name = "textCotizacionEuro";
            textCotizacionEuro.Size = new Size(133, 27);
            textCotizacionEuro.TabIndex = 1;
            textCotizacionEuro.Leave += textCotizacionEuro_Leave;
            // 
            // textCotizacionPeso
            // 
            textCotizacionPeso.Location = new Point(734, 36);
            textCotizacionPeso.Name = "textCotizacionPeso";
            textCotizacionPeso.Size = new Size(133, 27);
            textCotizacionPeso.TabIndex = 2;
            textCotizacionPeso.Leave += textCotizacionPeso_Leave;
            // 
            // textCotizacionDolar
            // 
            textCotizacionDolar.Enabled = false;
            textCotizacionDolar.Location = new Point(575, 36);
            textCotizacionDolar.Name = "textCotizacionDolar";
            textCotizacionDolar.Size = new Size(133, 27);
            textCotizacionDolar.TabIndex = 3;
            textCotizacionDolar.Text = "1";
            textCotizacionDolar.TextAlign = HorizontalAlignment.Center;
            // 
            // labelCotizacion
            // 
            labelCotizacion.AutoSize = true;
            labelCotizacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCotizacion.Location = new Point(130, 36);
            labelCotizacion.Name = "labelCotizacion";
            labelCotizacion.Size = new Size(104, 28);
            labelCotizacion.TabIndex = 4;
            labelCotizacion.Text = "Cotización";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(461, 76);
            label1.Name = "label1";
            label1.Size = new Size(52, 28);
            label1.TabIndex = 5;
            label1.Text = "Euro";
            // 
            // labelPeso
            // 
            labelPeso.AutoSize = true;
            labelPeso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPeso.Location = new Point(778, 76);
            labelPeso.Name = "labelPeso";
            labelPeso.Size = new Size(52, 28);
            labelPeso.TabIndex = 6;
            labelPeso.Text = "Peso";
            // 
            // labelDolar
            // 
            labelDolar.AutoSize = true;
            labelDolar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDolar.Location = new Point(615, 76);
            labelDolar.Name = "labelDolar";
            labelDolar.Size = new Size(60, 28);
            labelDolar.TabIndex = 7;
            labelDolar.Text = "Dólar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 170);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 10;
            label2.Text = "Dólar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 234);
            label3.Name = "label3";
            label3.Size = new Size(52, 28);
            label3.TabIndex = 9;
            label3.Text = "Peso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 109);
            label4.Name = "label4";
            label4.Size = new Size(52, 28);
            label4.TabIndex = 8;
            label4.Text = "Euro";
            // 
            // txtEuroAEuro
            // 
            txtEuroAEuro.Location = new Point(420, 110);
            txtEuroAEuro.Name = "txtEuroAEuro";
            txtEuroAEuro.Size = new Size(133, 27);
            txtEuroAEuro.TabIndex = 11;
            // 
            // txtDolarAEuro
            // 
            txtDolarAEuro.Location = new Point(420, 170);
            txtDolarAEuro.Name = "txtDolarAEuro";
            txtDolarAEuro.Size = new Size(133, 27);
            txtDolarAEuro.TabIndex = 12;
            // 
            // txtPesoAEuro
            // 
            txtPesoAEuro.Location = new Point(420, 234);
            txtPesoAEuro.Name = "txtPesoAEuro";
            txtPesoAEuro.Size = new Size(133, 27);
            txtPesoAEuro.TabIndex = 13;
            // 
            // txtPesoADolar
            // 
            txtPesoADolar.Location = new Point(575, 234);
            txtPesoADolar.Name = "txtPesoADolar";
            txtPesoADolar.Size = new Size(133, 27);
            txtPesoADolar.TabIndex = 16;
            // 
            // txtDolarADolar
            // 
            txtDolarADolar.Location = new Point(575, 170);
            txtDolarADolar.Name = "txtDolarADolar";
            txtDolarADolar.Size = new Size(133, 27);
            txtDolarADolar.TabIndex = 15;
            // 
            // txtEuroADolar
            // 
            txtEuroADolar.Location = new Point(575, 110);
            txtEuroADolar.Name = "txtEuroADolar";
            txtEuroADolar.Size = new Size(133, 27);
            txtEuroADolar.TabIndex = 14;
            // 
            // txtPesoAPeso
            // 
            txtPesoAPeso.Location = new Point(734, 234);
            txtPesoAPeso.Name = "txtPesoAPeso";
            txtPesoAPeso.Size = new Size(133, 27);
            txtPesoAPeso.TabIndex = 19;
            // 
            // txtDolarAPeso
            // 
            txtDolarAPeso.Location = new Point(734, 170);
            txtDolarAPeso.Name = "txtDolarAPeso";
            txtDolarAPeso.Size = new Size(133, 27);
            txtDolarAPeso.TabIndex = 18;
            // 
            // txtEuroAPeso
            // 
            txtEuroAPeso.Location = new Point(734, 110);
            txtEuroAPeso.Name = "txtEuroAPeso";
            txtEuroAPeso.Size = new Size(133, 27);
            txtEuroAPeso.TabIndex = 17;
            // 
            // btnConvertEuro
            // 
            btnConvertEuro.Location = new Point(279, 109);
            btnConvertEuro.Name = "btnConvertEuro";
            btnConvertEuro.Size = new Size(102, 29);
            btnConvertEuro.TabIndex = 20;
            btnConvertEuro.Text = "->";
            btnConvertEuro.UseVisualStyleBackColor = true;
            btnConvertEuro.Click += btnConvertEuro_Click;
            // 
            // btnConvertDolar
            // 
            btnConvertDolar.Location = new Point(279, 170);
            btnConvertDolar.Name = "btnConvertDolar";
            btnConvertDolar.Size = new Size(102, 29);
            btnConvertDolar.TabIndex = 21;
            btnConvertDolar.Text = "->";
            btnConvertDolar.UseVisualStyleBackColor = true;
            btnConvertDolar.Click += btnConvertDolar_Click;
            // 
            // btnConvertPeso
            // 
            btnConvertPeso.Location = new Point(279, 234);
            btnConvertPeso.Name = "btnConvertPeso";
            btnConvertPeso.Size = new Size(102, 29);
            btnConvertPeso.TabIndex = 22;
            btnConvertPeso.Text = "->";
            btnConvertPeso.UseVisualStyleBackColor = true;
            btnConvertPeso.Click += btnConvertPeso_Click;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(119, 234);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(133, 27);
            txtPeso.TabIndex = 25;
            // 
            // txtDolar
            // 
            txtDolar.Location = new Point(119, 170);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new Size(133, 27);
            txtDolar.TabIndex = 24;
            // 
            // txtEuro
            // 
            txtEuro.Location = new Point(119, 110);
            txtEuro.Name = "txtEuro";
            txtEuro.Size = new Size(133, 27);
            txtEuro.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(906, 296);
            Controls.Add(txtPeso);
            Controls.Add(txtDolar);
            Controls.Add(txtEuro);
            Controls.Add(btnConvertPeso);
            Controls.Add(btnConvertDolar);
            Controls.Add(btnConvertEuro);
            Controls.Add(txtPesoAPeso);
            Controls.Add(txtDolarAPeso);
            Controls.Add(txtEuroAPeso);
            Controls.Add(txtPesoADolar);
            Controls.Add(txtDolarADolar);
            Controls.Add(txtEuroADolar);
            Controls.Add(txtPesoAEuro);
            Controls.Add(txtDolarAEuro);
            Controls.Add(txtEuroAEuro);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(labelDolar);
            Controls.Add(labelPeso);
            Controls.Add(label1);
            Controls.Add(labelCotizacion);
            Controls.Add(textCotizacionDolar);
            Controls.Add(textCotizacionPeso);
            Controls.Add(textCotizacionEuro);
            Controls.Add(btnCandado);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 23";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCandado;
        private ImageList imlCandado;
        private TextBox textCotizacionEuro;
        private TextBox textCotizacionPeso;
        private TextBox textCotizacionDolar;
        private Label labelCotizacion;
        private Label label1;
        private Label labelPeso;
        private Label labelDolar;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEuroAEuro;
        private TextBox txtDolarAEuro;
        private TextBox txtPesoAEuro;
        private TextBox txtPesoADolar;
        private TextBox txtDolarADolar;
        private TextBox txtEuroADolar;
        private TextBox txtPesoAPeso;
        private TextBox txtDolarAPeso;
        private TextBox txtEuroAPeso;
        private Button btnConvertEuro;
        private Button btnConvertDolar;
        private Button btnConvertPeso;
        private TextBox txtPeso;
        private TextBox txtDolar;
        private TextBox txtEuro;
    }
}