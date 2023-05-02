namespace FrmCompetencia
{
    partial class FrmTorneo
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
            cmbEquipoUno = new ComboBox();
            cmbEquipoDos = new ComboBox();
            btnDesafiar = new Button();
            rchtDatosTorneo = new RichTextBox();
            dgvResultados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // cmbEquipoUno
            // 
            cmbEquipoUno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipoUno.FormattingEnabled = true;
            cmbEquipoUno.Location = new Point(12, 32);
            cmbEquipoUno.Name = "cmbEquipoUno";
            cmbEquipoUno.Size = new Size(367, 28);
            cmbEquipoUno.TabIndex = 0;
            cmbEquipoUno.SelectedIndexChanged += cmbEquipoUno_SelectedIndexChanged;
            // 
            // cmbEquipoDos
            // 
            cmbEquipoDos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipoDos.FormattingEnabled = true;
            cmbEquipoDos.Location = new Point(421, 32);
            cmbEquipoDos.Name = "cmbEquipoDos";
            cmbEquipoDos.Size = new Size(367, 28);
            cmbEquipoDos.TabIndex = 1;
            // 
            // btnDesafiar
            // 
            btnDesafiar.Location = new Point(192, 79);
            btnDesafiar.Name = "btnDesafiar";
            btnDesafiar.Size = new Size(367, 29);
            btnDesafiar.TabIndex = 2;
            btnDesafiar.Text = "Jugar Partido";
            btnDesafiar.UseVisualStyleBackColor = true;
            btnDesafiar.Click += btnDesafiar_Click;
            // 
            // rchtDatosTorneo
            // 
            rchtDatosTorneo.Location = new Point(12, 373);
            rchtDatosTorneo.Name = "rchtDatosTorneo";
            rchtDatosTorneo.Size = new Size(776, 195);
            rchtDatosTorneo.TabIndex = 3;
            rchtDatosTorneo.Text = "";
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(12, 127);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.RowTemplate.Height = 29;
            dgvResultados.Size = new Size(776, 240);
            dgvResultados.TabIndex = 4;
            // 
            // FrmTorneo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 580);
            Controls.Add(dgvResultados);
            Controls.Add(rchtDatosTorneo);
            Controls.Add(btnDesafiar);
            Controls.Add(cmbEquipoDos);
            Controls.Add(cmbEquipoUno);
            Name = "FrmTorneo";
            Text = "Form1";
            Load += FrmTorneo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbEquipoUno;
        private ComboBox cmbEquipoDos;
        private Button btnDesafiar;
        private RichTextBox rchtDatosTorneo;
        private DataGridView dgvResultados;
    }
}