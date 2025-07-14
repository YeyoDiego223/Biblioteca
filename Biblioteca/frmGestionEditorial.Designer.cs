namespace Biblioteca
{
    partial class frmGestionEditorial
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
            lstEditorial = new ListBox();
            btnGuardar = new Button();
            txtNombreEditorial = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstEditorial
            // 
            lstEditorial.FormattingEnabled = true;
            lstEditorial.Location = new Point(284, 148);
            lstEditorial.Name = "lstEditorial";
            lstEditorial.Size = new Size(253, 204);
            lstEditorial.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(574, 94);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombreEditorial
            // 
            txtNombreEditorial.Location = new Point(284, 94);
            txtNombreEditorial.Name = "txtNombreEditorial";
            txtNombreEditorial.Size = new Size(253, 27);
            txtNombreEditorial.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 94);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 8;
            label1.Text = "Nombre Editorial";
            // 
            // frmGestionEditorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstEditorial);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombreEditorial);
            Controls.Add(label1);
            Name = "frmGestionEditorial";
            Text = "frmGestionEditorial";
            Load += frmGestionEditorial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEditorial;
        private Button btnGuardar;
        private TextBox txtNombreEditorial;
        private Label label1;
    }
}