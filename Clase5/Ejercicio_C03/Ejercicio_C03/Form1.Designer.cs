namespace Ejercicio_C03
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
            label1 = new Label();
            label2 = new Label();
            txtBinario = new TextBox();
            txtDecimal = new TextBox();
            btnBinToDec = new Button();
            btnDecToBin = new Button();
            txtResultadoDec = new TextBox();
            txtResultadoBin = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 33);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "Binario a Decimal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 77);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 1;
            label2.Text = "Decimal a Binario";
            // 
            // txtBinario
            // 
            txtBinario.Location = new Point(156, 30);
            txtBinario.Name = "txtBinario";
            txtBinario.Size = new Size(145, 27);
            txtBinario.TabIndex = 2;
            // 
            // txtDecimal
            // 
            txtDecimal.Location = new Point(156, 74);
            txtDecimal.Name = "txtDecimal";
            txtDecimal.Size = new Size(145, 27);
            txtDecimal.TabIndex = 3;
            // 
            // btnBinToDec
            // 
            btnBinToDec.Location = new Point(319, 30);
            btnBinToDec.Name = "btnBinToDec";
            btnBinToDec.Size = new Size(77, 27);
            btnBinToDec.TabIndex = 4;
            btnBinToDec.Text = "->";
            btnBinToDec.UseVisualStyleBackColor = true;
            btnBinToDec.Click += btnBinToDec_Click;
            // 
            // btnDecToBin
            // 
            btnDecToBin.Location = new Point(319, 74);
            btnDecToBin.Name = "btnDecToBin";
            btnDecToBin.Size = new Size(77, 27);
            btnDecToBin.TabIndex = 5;
            btnDecToBin.Text = "->";
            btnDecToBin.UseVisualStyleBackColor = true;
            btnDecToBin.Click += btnDecToBin_Click;
            // 
            // txtResultadoDec
            // 
            txtResultadoDec.Location = new Point(413, 30);
            txtResultadoDec.Name = "txtResultadoDec";
            txtResultadoDec.Size = new Size(145, 27);
            txtResultadoDec.TabIndex = 6;
            // 
            // txtResultadoBin
            // 
            txtResultadoBin.Location = new Point(413, 74);
            txtResultadoBin.Name = "txtResultadoBin";
            txtResultadoBin.Size = new Size(145, 27);
            txtResultadoBin.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 144);
            Controls.Add(txtResultadoBin);
            Controls.Add(txtResultadoDec);
            Controls.Add(btnDecToBin);
            Controls.Add(btnBinToDec);
            Controls.Add(txtDecimal);
            Controls.Add(txtBinario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Conversor Numérico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBinario;
        private TextBox txtDecimal;
        private Button btnBinToDec;
        private Button btnDecToBin;
        private TextBox txtResultadoDec;
        private TextBox txtResultadoBin;
    }
}