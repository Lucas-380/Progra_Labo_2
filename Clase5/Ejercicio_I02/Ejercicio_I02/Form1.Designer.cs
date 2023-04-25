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
            grpDetalles = new GroupBox();
            numericEdad = new NumericUpDown();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpGenero = new GroupBox();
            radBtnNoBinario = new RadioButton();
            radBtnFemenino = new RadioButton();
            radBtnMasculino = new RadioButton();
            grpCursos = new GroupBox();
            checkBoxCurso3 = new CheckBox();
            checkBoxCurso2 = new CheckBox();
            checkBoxCurso1 = new CheckBox();
            listBoxPaises = new ListBox();
            label4 = new Label();
            btnIngresar = new Button();
            grpDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericEdad).BeginInit();
            grpGenero.SuspendLayout();
            grpCursos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDetalles
            // 
            grpDetalles.Controls.Add(numericEdad);
            grpDetalles.Controls.Add(txtDireccion);
            grpDetalles.Controls.Add(txtNombre);
            grpDetalles.Controls.Add(label3);
            grpDetalles.Controls.Add(label2);
            grpDetalles.Controls.Add(label1);
            grpDetalles.Location = new Point(25, 27);
            grpDetalles.Name = "grpDetalles";
            grpDetalles.Size = new Size(250, 163);
            grpDetalles.TabIndex = 0;
            grpDetalles.TabStop = false;
            grpDetalles.Text = "Detalles del usuario";
            // 
            // numericEdad
            // 
            numericEdad.Location = new Point(105, 117);
            numericEdad.Name = "numericEdad";
            numericEdad.Size = new Size(125, 27);
            numericEdad.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(105, 78);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 27);
            txtDireccion.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(105, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 124);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 3;
            label3.Text = "Edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 81);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Dirección";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // grpGenero
            // 
            grpGenero.Controls.Add(radBtnNoBinario);
            grpGenero.Controls.Add(radBtnFemenino);
            grpGenero.Controls.Add(radBtnMasculino);
            grpGenero.Location = new Point(306, 27);
            grpGenero.Name = "grpGenero";
            grpGenero.Size = new Size(156, 144);
            grpGenero.TabIndex = 1;
            grpGenero.TabStop = false;
            grpGenero.Text = "Género";
            // 
            // radBtnNoBinario
            // 
            radBtnNoBinario.AutoSize = true;
            radBtnNoBinario.Location = new Point(26, 104);
            radBtnNoBinario.Name = "radBtnNoBinario";
            radBtnNoBinario.Size = new Size(101, 24);
            radBtnNoBinario.TabIndex = 2;
            radBtnNoBinario.TabStop = true;
            radBtnNoBinario.Text = "No binario";
            radBtnNoBinario.UseVisualStyleBackColor = true;
            // 
            // radBtnFemenino
            // 
            radBtnFemenino.AutoSize = true;
            radBtnFemenino.Location = new Point(26, 64);
            radBtnFemenino.Name = "radBtnFemenino";
            radBtnFemenino.Size = new Size(95, 24);
            radBtnFemenino.TabIndex = 1;
            radBtnFemenino.TabStop = true;
            radBtnFemenino.Text = "Femenino";
            radBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // radBtnMasculino
            // 
            radBtnMasculino.AutoSize = true;
            radBtnMasculino.Location = new Point(26, 26);
            radBtnMasculino.Name = "radBtnMasculino";
            radBtnMasculino.Size = new Size(97, 24);
            radBtnMasculino.TabIndex = 0;
            radBtnMasculino.TabStop = true;
            radBtnMasculino.Text = "Masculino";
            radBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // grpCursos
            // 
            grpCursos.Controls.Add(checkBoxCurso3);
            grpCursos.Controls.Add(checkBoxCurso2);
            grpCursos.Controls.Add(checkBoxCurso1);
            grpCursos.Location = new Point(306, 187);
            grpCursos.Name = "grpCursos";
            grpCursos.Size = new Size(156, 122);
            grpCursos.TabIndex = 2;
            grpCursos.TabStop = false;
            grpCursos.Text = "Cursos";
            // 
            // checkBoxCurso3
            // 
            checkBoxCurso3.AutoSize = true;
            checkBoxCurso3.Location = new Point(41, 86);
            checkBoxCurso3.Name = "checkBoxCurso3";
            checkBoxCurso3.Size = new Size(97, 24);
            checkBoxCurso3.TabIndex = 2;
            checkBoxCurso3.Text = "JavaScript";
            checkBoxCurso3.UseVisualStyleBackColor = true;
            // 
            // checkBoxCurso2
            // 
            checkBoxCurso2.AutoSize = true;
            checkBoxCurso2.Location = new Point(41, 56);
            checkBoxCurso2.Name = "checkBoxCurso2";
            checkBoxCurso2.Size = new Size(60, 24);
            checkBoxCurso2.TabIndex = 1;
            checkBoxCurso2.Text = "C++";
            checkBoxCurso2.UseVisualStyleBackColor = true;
            // 
            // checkBoxCurso1
            // 
            checkBoxCurso1.AutoSize = true;
            checkBoxCurso1.Location = new Point(41, 26);
            checkBoxCurso1.Name = "checkBoxCurso1";
            checkBoxCurso1.Size = new Size(49, 24);
            checkBoxCurso1.TabIndex = 0;
            checkBoxCurso1.Text = "C#";
            checkBoxCurso1.UseVisualStyleBackColor = true;
            // 
            // listBoxPaises
            // 
            listBoxPaises.FormattingEnabled = true;
            listBoxPaises.ItemHeight = 20;
            listBoxPaises.Items.AddRange(new object[] { "Argentina", "Chile", "Uruguay" });
            listBoxPaises.Location = new Point(25, 236);
            listBoxPaises.Name = "listBoxPaises";
            listBoxPaises.Size = new Size(250, 124);
            listBoxPaises.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 213);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 4;
            label4.Text = "País";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(307, 326);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(155, 34);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 386);
            Controls.Add(btnIngresar);
            Controls.Add(label4);
            Controls.Add(listBoxPaises);
            Controls.Add(grpCursos);
            Controls.Add(grpGenero);
            Controls.Add(grpDetalles);
            Name = "Form1";
            Text = "Registro";
            grpDetalles.ResumeLayout(false);
            grpDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericEdad).EndInit();
            grpGenero.ResumeLayout(false);
            grpGenero.PerformLayout();
            grpCursos.ResumeLayout(false);
            grpCursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpDetalles;
        private NumericUpDown numericEdad;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grpGenero;
        private RadioButton radBtnNoBinario;
        private RadioButton radBtnFemenino;
        private RadioButton radBtnMasculino;
        private GroupBox grpCursos;
        private CheckBox checkBoxCurso3;
        private CheckBox checkBoxCurso2;
        private CheckBox checkBoxCurso1;
        private ListBox listBoxPaises;
        private Label label4;
        private Button btnIngresar;
    }
}