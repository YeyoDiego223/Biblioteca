namespace Biblioteca
{
    partial class frmLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibros));
            label1 = new Label();
            txtTituloLibro = new TextBox();
            label2 = new Label();
            cmbAutores = new ComboBox();
            btnNuevoAutor = new Button();
            btnGuardarLibro = new Button();
            txtISBN = new TextBox();
            label3 = new Label();
            btnNuevaCategoria = new Button();
            cmbCategoria = new ComboBox();
            label4 = new Label();
            btnNuevoEditorial = new Button();
            cmbEditorial = new ComboBox();
            label5 = new Label();
            txtIdioma = new TextBox();
            label6 = new Label();
            txtPaginas = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Unispace", 9F, FontStyle.Bold);
            label1.Location = new Point(26, 80);
            label1.Name = "label1";
            label1.Size = new Size(152, 18);
            label1.TabIndex = 0;
            label1.Text = "Título del Libro";
            // 
            // txtTituloLibro
            // 
            txtTituloLibro.Location = new Point(184, 75);
            txtTituloLibro.Name = "txtTituloLibro";
            txtTituloLibro.Size = new Size(275, 27);
            txtTituloLibro.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Unispace", 9F, FontStyle.Bold);
            label2.Location = new Point(112, 200);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 2;
            label2.Text = "Autor";
            // 
            // cmbAutores
            // 
            cmbAutores.FormattingEnabled = true;
            cmbAutores.Location = new Point(184, 195);
            cmbAutores.Name = "cmbAutores";
            cmbAutores.Size = new Size(275, 28);
            cmbAutores.TabIndex = 3;
            // 
            // btnNuevoAutor
            // 
            btnNuevoAutor.BackColor = Color.Black;
            btnNuevoAutor.BackgroundImage = (Image)resources.GetObject("btnNuevoAutor.BackgroundImage");
            btnNuevoAutor.Location = new Point(485, 195);
            btnNuevoAutor.Name = "btnNuevoAutor";
            btnNuevoAutor.Size = new Size(29, 29);
            btnNuevoAutor.TabIndex = 4;
            btnNuevoAutor.Text = "+";
            btnNuevoAutor.UseVisualStyleBackColor = false;
            btnNuevoAutor.Click += btnNuevoAutor_Click;
            // 
            // btnGuardarLibro
            // 
            btnGuardarLibro.BackColor = Color.Black;
            btnGuardarLibro.BackgroundImage = (Image)resources.GetObject("btnGuardarLibro.BackgroundImage");
            btnGuardarLibro.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarLibro.Location = new Point(255, 470);
            btnGuardarLibro.Name = "btnGuardarLibro";
            btnGuardarLibro.Size = new Size(123, 46);
            btnGuardarLibro.TabIndex = 5;
            btnGuardarLibro.Text = "Guardar Libro";
            btnGuardarLibro.UseVisualStyleBackColor = false;
            btnGuardarLibro.Click += btnGuardarLibro_Click;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(184, 127);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(275, 27);
            txtISBN.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Unispace", 9F, FontStyle.Bold);
            label3.Location = new Point(121, 136);
            label3.Name = "label3";
            label3.Size = new Size(44, 18);
            label3.TabIndex = 6;
            label3.Text = "ISBN";
            // 
            // btnNuevaCategoria
            // 
            btnNuevaCategoria.BackColor = Color.Black;
            btnNuevaCategoria.BackgroundImage = (Image)resources.GetObject("btnNuevaCategoria.BackgroundImage");
            btnNuevaCategoria.Location = new Point(485, 251);
            btnNuevaCategoria.Name = "btnNuevaCategoria";
            btnNuevaCategoria.Size = new Size(29, 29);
            btnNuevaCategoria.TabIndex = 10;
            btnNuevaCategoria.Text = "+";
            btnNuevaCategoria.UseVisualStyleBackColor = false;
            btnNuevaCategoria.Click += btnNuevaCategoria_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(184, 251);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(275, 28);
            cmbCategoria.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Unispace", 9F, FontStyle.Bold);
            label4.Location = new Point(89, 256);
            label4.Name = "label4";
            label4.Size = new Size(89, 18);
            label4.TabIndex = 8;
            label4.Text = "Categoría";
            // 
            // btnNuevoEditorial
            // 
            btnNuevoEditorial.BackColor = Color.Black;
            btnNuevoEditorial.BackgroundImage = (Image)resources.GetObject("btnNuevoEditorial.BackgroundImage");
            btnNuevoEditorial.Location = new Point(485, 305);
            btnNuevoEditorial.Name = "btnNuevoEditorial";
            btnNuevoEditorial.Size = new Size(29, 29);
            btnNuevoEditorial.TabIndex = 13;
            btnNuevoEditorial.Text = "+";
            btnNuevoEditorial.UseVisualStyleBackColor = false;
            btnNuevoEditorial.Click += btnNuevoEditorial_Click;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(184, 305);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(275, 28);
            cmbEditorial.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Unispace", 9F, FontStyle.Bold);
            label5.Location = new Point(89, 311);
            label5.Name = "label5";
            label5.Size = new Size(89, 18);
            label5.TabIndex = 11;
            label5.Text = "Editorial";
            // 
            // txtIdioma
            // 
            txtIdioma.Location = new Point(184, 361);
            txtIdioma.Name = "txtIdioma";
            txtIdioma.Size = new Size(275, 27);
            txtIdioma.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Unispace", 9F, FontStyle.Bold);
            label6.Location = new Point(116, 366);
            label6.Name = "label6";
            label6.Size = new Size(62, 18);
            label6.TabIndex = 14;
            label6.Text = "Idioma";
            // 
            // txtPaginas
            // 
            txtPaginas.Location = new Point(184, 411);
            txtPaginas.Name = "txtPaginas";
            txtPaginas.Size = new Size(275, 27);
            txtPaginas.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Unispace", 9F, FontStyle.Bold);
            label7.Location = new Point(107, 420);
            label7.Name = "label7";
            label7.Size = new Size(71, 18);
            label7.TabIndex = 16;
            label7.Text = "Páginas";
            // 
            // frmLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(538, 528);
            Controls.Add(txtPaginas);
            Controls.Add(label7);
            Controls.Add(txtIdioma);
            Controls.Add(label6);
            Controls.Add(btnNuevoEditorial);
            Controls.Add(cmbEditorial);
            Controls.Add(label5);
            Controls.Add(btnNuevaCategoria);
            Controls.Add(cmbCategoria);
            Controls.Add(label4);
            Controls.Add(txtISBN);
            Controls.Add(label3);
            Controls.Add(btnGuardarLibro);
            Controls.Add(btnNuevoAutor);
            Controls.Add(cmbAutores);
            Controls.Add(label2);
            Controls.Add(txtTituloLibro);
            Controls.Add(label1);
            Name = "frmLibros";
            Text = "frmLibros";
            Load += frmLibros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTituloLibro;
        private Label label2;
        private ComboBox cmbAutores;
        private Button btnNuevoAutor;
        private Button btnGuardarLibro;
        private TextBox txtISBN;
        private Label label3;
        private Button btnNuevaCategoria;
        private ComboBox cmbCategoria;
        private Label label4;
        private Button btnNuevoEditorial;
        private ComboBox cmbEditorial;
        private Label label5;
        private TextBox txtIdioma;
        private Label label6;
        private TextBox txtPaginas;
        private Label label7;
    }
}