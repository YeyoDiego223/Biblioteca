namespace Biblioteca
{
    partial class frmGestionLectores
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
            txtNombre = new TextBox();
            btnCrear = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            txtApellidoPaterno = new TextBox();
            label2 = new Label();
            txtApellidoMaterno = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            dgvLectores = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colApellidoPaterno = new DataGridViewTextBoxColumn();
            colApellidoMaterno = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            btnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLectores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 35);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(197, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(262, 27);
            txtNombre.TabIndex = 1;
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.KeyDown += txtNombre_KeyDown;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(532, 60);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(532, 95);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(532, 130);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(197, 61);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(262, 27);
            txtApellidoPaterno.TabIndex = 6;
            txtApellidoPaterno.KeyDown += txtApellidoPaterno_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 64);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 5;
            label2.Text = "Apellido Paterno";
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(197, 94);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(262, 27);
            txtApellidoMaterno.TabIndex = 8;
            txtApellidoMaterno.KeyDown += txtApellidoMaterno_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 97);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 7;
            label3.Text = "Apellido Materno";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(197, 127);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(262, 27);
            txtTelefono.TabIndex = 10;
            txtTelefono.KeyDown += txtTelefono_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 130);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 9;
            label4.Text = "Teléfono";
            // 
            // dgvLectores
            // 
            dgvLectores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLectores.Columns.AddRange(new DataGridViewColumn[] { colNombre, colApellidoPaterno, colApellidoMaterno, colTelefono });
            dgvLectores.Location = new Point(118, 197);
            dgvLectores.Name = "dgvLectores";
            dgvLectores.RowHeadersWidth = 51;
            dgvLectores.Size = new Size(553, 219);
            dgvLectores.TabIndex = 11;
            dgvLectores.CellClick += dgvLectores_CellClick;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.Width = 125;
            // 
            // colApellidoPaterno
            // 
            colApellidoPaterno.HeaderText = "Apellido Paterno";
            colApellidoPaterno.MinimumWidth = 6;
            colApellidoPaterno.Name = "colApellidoPaterno";
            colApellidoPaterno.Width = 125;
            // 
            // colApellidoMaterno
            // 
            colApellidoMaterno.HeaderText = "Apellido Materno";
            colApellidoMaterno.MinimumWidth = 6;
            colApellidoMaterno.Name = "colApellidoMaterno";
            colApellidoMaterno.Width = 125;
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Teléfono";
            colTelefono.MinimumWidth = 6;
            colTelefono.Name = "colTelefono";
            colTelefono.Width = 125;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(532, 25);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 12;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // frmGestionLectores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNuevo);
            Controls.Add(dgvLectores);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(txtApellidoMaterno);
            Controls.Add(label3);
            Controls.Add(txtApellidoPaterno);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnCrear);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "frmGestionLectores";
            Text = "frmGestionLectores";
            Load += frmGestionLectores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLectores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Button btnCrear;
        private Button btnEditar;
        private Button btnEliminar;
        private TextBox txtApellidoPaterno;
        private Label label2;
        private TextBox txtApellidoMaterno;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private DataGridView dgvLectores;
        private Button btnNuevo;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellidoPaterno;
        private DataGridViewTextBoxColumn colApellidoMaterno;
        private DataGridViewTextBoxColumn colTelefono;
    }
}