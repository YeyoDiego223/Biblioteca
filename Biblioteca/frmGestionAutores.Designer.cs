namespace Biblioteca
{
    partial class frmGestionAutores
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
            label1 = new Label();
            txtNombreAutor = new TextBox();
            btnGuardar = new Button();
            lstAutores = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 98);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Autor";
            // 
            // txtNombreAutor
            // 
            txtNombreAutor.Location = new Point(265, 98);
            txtNombreAutor.Name = "txtNombreAutor";
            txtNombreAutor.Size = new Size(253, 27);
            txtNombreAutor.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(555, 98);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lstAutores
            // 
            lstAutores.FormattingEnabled = true;
            lstAutores.Location = new Point(265, 152);
            lstAutores.Name = "lstAutores";
            lstAutores.Size = new Size(253, 204);
            lstAutores.TabIndex = 3;
            // 
            // frmGestionAutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstAutores);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombreAutor);
            Controls.Add(label1);
            Name = "frmGestionAutores";
            Text = "frmGestionAutores";
            Load += frmGestionAutores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreAutor;
        private Button btnGuardar;
        private ListBox lstAutores;
    }
}