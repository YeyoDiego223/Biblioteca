namespace Biblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnPrestamos = new Button();
            btnLectores = new Button();
            btnLibros = new Button();
            SuspendLayout();
            // 
            // btnPrestamos
            // 
            btnPrestamos.BackColor = Color.RosyBrown;
            btnPrestamos.BackgroundImage = (Image)resources.GetObject("btnPrestamos.BackgroundImage");
            btnPrestamos.Font = new Font("Unispace", 19.8000011F, FontStyle.Bold);
            btnPrestamos.Location = new Point(744, 112);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(300, 105);
            btnPrestamos.TabIndex = 14;
            btnPrestamos.Text = "PRESTAMOS";
            btnPrestamos.UseVisualStyleBackColor = false;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // btnLectores
            // 
            btnLectores.BackColor = Color.RosyBrown;
            btnLectores.BackgroundImage = (Image)resources.GetObject("btnLectores.BackgroundImage");
            btnLectores.Font = new Font("Unispace", 19.8000011F, FontStyle.Bold);
            btnLectores.Location = new Point(369, 112);
            btnLectores.Name = "btnLectores";
            btnLectores.Size = new Size(300, 105);
            btnLectores.TabIndex = 13;
            btnLectores.Text = "LECTORES";
            btnLectores.UseVisualStyleBackColor = false;
            btnLectores.Click += btnLectores_Click;
            // 
            // btnLibros
            // 
            btnLibros.BackColor = Color.RosyBrown;
            btnLibros.BackgroundImage = (Image)resources.GetObject("btnLibros.BackgroundImage");
            btnLibros.Font = new Font("Unispace", 19.8000011F, FontStyle.Bold);
            btnLibros.Location = new Point(31, 112);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(271, 105);
            btnLibros.TabIndex = 12;
            btnLibros.Text = "LIBROS";
            btnLibros.UseVisualStyleBackColor = false;
            btnLibros.Click += btnLibros_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1075, 833);
            Controls.Add(btnPrestamos);
            Controls.Add(btnLectores);
            Controls.Add(btnLibros);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPrestamos;
        private Button btnLectores;
        private Button btnLibros;
    }
}
