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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionEditorial));
            lstEditorial = new ListBox();
            txtNombreEditorial = new TextBox();
            label1 = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lstEditorial
            // 
            lstEditorial.FormattingEnabled = true;
            lstEditorial.Location = new Point(284, 148);
            lstEditorial.Name = "lstEditorial";
            lstEditorial.Size = new Size(253, 204);
            lstEditorial.TabIndex = 11;
            lstEditorial.SelectedIndexChanged += lstEditorial_SelectedIndexChanged;
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
            label1.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 94);
            label1.Name = "label1";
            label1.Size = new Size(152, 18);
            label1.TabIndex = 8;
            label1.Text = "Nombre Editorial";
            // 
            // btnEditar
            // 
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.Font = new Font("Unispace", 9F, FontStyle.Bold);
            btnEditar.Location = new Point(582, 183);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(102, 40);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.Font = new Font("Unispace", 9F, FontStyle.Bold);
            btnEliminar.Location = new Point(582, 137);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(102, 40);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.Font = new Font("Unispace", 9F, FontStyle.Bold);
            btnGuardar.Location = new Point(582, 91);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 40);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // frmGestionEditorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(lstEditorial);
            Controls.Add(txtNombreEditorial);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmGestionEditorial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGestionEditorial";
            Load += frmGestionEditorial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEditorial;
        private TextBox txtNombreEditorial;
        private Label label1;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnGuardar;
    }
}