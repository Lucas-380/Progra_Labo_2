namespace FormCentroDeAtencion
{
    partial class Nomina
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
            RchtNomina = new RichTextBox();
            SuspendLayout();
            // 
            // RchtNomina
            // 
            RchtNomina.Location = new Point(12, 12);
            RchtNomina.Name = "RchtNomina";
            RchtNomina.ReadOnly = true;
            RchtNomina.Size = new Size(407, 264);
            RchtNomina.TabIndex = 0;
            RchtNomina.Text = "";
            // 
            // Nomina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 288);
            Controls.Add(RchtNomina);
            Name = "Nomina";
            Text = "Nomina";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox RchtNomina;
    }
}