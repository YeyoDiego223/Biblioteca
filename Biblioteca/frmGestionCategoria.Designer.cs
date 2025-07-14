namespace Biblioteca
{
    partial class frmGestionCategoria
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
            lstCategoria = new ListBox();
            btnGuardar = new Button();
            txtNombreCategoria = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstCategoria
            // 
            lstCategoria.FormattingEnabled = true;
            lstCategoria.Location = new Point(250, 145);
            lstCategoria.Name = "lstCategoria";
            lstCategoria.Size = new Size(253, 204);
            lstCategoria.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(540, 91);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(250, 91);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(253, 27);
            txtNombreCategoria.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 91);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre Categoría";
            // 
            // frmGestionCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstCategoria);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombreCategoria);
            Controls.Add(label1);
            Name = "frmGestionCategoria";
            Text = "frmGestionCategoria";
            Load += frmGestionCategoria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCategoria;
        private Button btnGuardar;
        private TextBox txtNombreCategoria;
        private Label label1;
    }
}