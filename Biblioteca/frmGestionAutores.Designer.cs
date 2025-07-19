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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionAutores));
            label1 = new Label();
            txtNombreAutor = new TextBox();
            btnGuardar = new Button();
            lstAutores = new ListBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 98);
            label1.Name = "label1";
            label1.Size = new Size(152, 18);
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
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.Font = new Font("Unispace", 9F, FontStyle.Bold);
            btnGuardar.Location = new Point(555, 85);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 40);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lstAutores
            // 
            lstAutores.BackColor = SystemColors.Window;
            lstAutores.FormattingEnabled = true;
            lstAutores.Location = new Point(265, 152);
            lstAutores.Name = "lstAutores";
            lstAutores.Size = new Size(253, 204);
            lstAutores.TabIndex = 3;
            lstAutores.SelectedIndexChanged += lstAutores_SelectedIndexChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.Font = new Font("Unispace", 9F, FontStyle.Bold);
            btnEliminar.Location = new Point(555, 131);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(102, 40);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.Font = new Font("Unispace", 9F, FontStyle.Bold);
            btnEditar.Location = new Point(555, 177);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(102, 40);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // frmGestionAutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(lstAutores);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombreAutor);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmGestionAutores";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnEliminar;
        private Button btnEditar;
    }
}