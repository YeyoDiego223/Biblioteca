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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionCategoria));
            lstCategoria = new ListBox();
            btnGuardar = new Button();
            txtNombreCategoria = new TextBox();
            label1 = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lstCategoria
            // 
            lstCategoria.FormattingEnabled = true;
            lstCategoria.Location = new Point(250, 145);
            lstCategoria.Name = "lstCategoria";
            lstCategoria.Size = new Size(253, 204);
            lstCategoria.TabIndex = 7;
            lstCategoria.SelectedIndexChanged += lstCategoria_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(543, 87);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 40);
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
            label1.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 91);
            label1.Name = "label1";
            label1.Size = new Size(152, 18);
            label1.TabIndex = 4;
            label1.Text = "Nombre Categoría";
            // 
            // btnEditar
            // 
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.Font = new Font("Unispace", 9F, FontStyle.Bold);
            btnEditar.Location = new Point(543, 179);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(102, 40);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.Font = new Font("Unispace", 9F, FontStyle.Bold);
            btnEliminar.Location = new Point(543, 133);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(102, 40);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmGestionCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(lstCategoria);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombreCategoria);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmGestionCategoria";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnEditar;
        private Button btnEliminar;
    }
}