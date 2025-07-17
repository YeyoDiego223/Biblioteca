namespace Biblioteca
{
    partial class frmPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestamos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnCrear = new Button();
            dtpFechaSalida = new DateTimePicker();
            dtpFechaEntrada = new DateTimePicker();
            cmbLector = new ComboBox();
            dgvPrestamos = new DataGridView();
            colFechaSalida = new DataGridViewTextBoxColumn();
            colFechaEntrada = new DataGridViewTextBoxColumn();
            colLector = new DataGridViewTextBoxColumn();
            colLibro = new DataGridViewTextBoxColumn();
            cmbLibro = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Unispace", 9F, FontStyle.Bold);
            label4.Location = new Point(110, 198);
            label4.Name = "label4";
            label4.Size = new Size(53, 18);
            label4.TabIndex = 13;
            label4.Text = "Libro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Unispace", 9F, FontStyle.Bold);
            label3.Location = new Point(101, 163);
            label3.Name = "label3";
            label3.Size = new Size(62, 18);
            label3.TabIndex = 12;
            label3.Text = "Lector";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Unispace", 9F, FontStyle.Bold);
            label2.Location = new Point(38, 131);
            label2.Name = "label2";
            label2.Size = new Size(125, 18);
            label2.TabIndex = 11;
            label2.Text = "Fecha Entrada";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Unispace", 9F, FontStyle.Bold);
            label1.Location = new Point(47, 98);
            label1.Name = "label1";
            label1.Size = new Size(116, 18);
            label1.TabIndex = 10;
            label1.Text = "Fecha Salida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Script MT Bold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(280, 20);
            label5.Name = "label5";
            label5.Size = new Size(160, 41);
            label5.TabIndex = 18;
            label5.Text = "Prestamos";
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.Font = new Font("Unispace", 9F, FontStyle.Bold);
            btnNuevo.Location = new Point(729, 83);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(130, 63);
            btnNuevo.TabIndex = 22;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.Font = new Font("Unispace", 9F, FontStyle.Bold);
            btnEliminar.Location = new Point(729, 152);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 63);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.Font = new Font("Unispace", 9F, FontStyle.Bold);
            btnEditar.Location = new Point(593, 152);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(130, 63);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            btnCrear.BackgroundImage = (Image)resources.GetObject("btnCrear.BackgroundImage");
            btnCrear.Font = new Font("Unispace", 9F, FontStyle.Bold);
            btnCrear.Location = new Point(593, 86);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(130, 63);
            btnCrear.TabIndex = 19;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // dtpFechaSalida
            // 
            dtpFechaSalida.Location = new Point(194, 91);
            dtpFechaSalida.Name = "dtpFechaSalida";
            dtpFechaSalida.Size = new Size(329, 27);
            dtpFechaSalida.TabIndex = 24;
            // 
            // dtpFechaEntrada
            // 
            dtpFechaEntrada.Location = new Point(194, 124);
            dtpFechaEntrada.Name = "dtpFechaEntrada";
            dtpFechaEntrada.Size = new Size(329, 27);
            dtpFechaEntrada.TabIndex = 25;
            // 
            // cmbLector
            // 
            cmbLector.FormattingEnabled = true;
            cmbLector.Location = new Point(194, 157);
            cmbLector.Name = "cmbLector";
            cmbLector.Size = new Size(327, 28);
            cmbLector.TabIndex = 26;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.BackgroundColor = Color.SaddleBrown;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Columns.AddRange(new DataGridViewColumn[] { colFechaSalida, colFechaEntrada, colLector, colLibro });
            dgvPrestamos.GridColor = Color.Black;
            dgvPrestamos.Location = new Point(47, 273);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.RowHeadersWidth = 51;
            dgvPrestamos.Size = new Size(812, 219);
            dgvPrestamos.TabIndex = 27;
            dgvPrestamos.CellClick += dgvPrestamos_CellClick;
            // 
            // colFechaSalida
            // 
            colFechaSalida.HeaderText = "Fecha Salida";
            colFechaSalida.MinimumWidth = 6;
            colFechaSalida.Name = "colFechaSalida";
            colFechaSalida.Width = 125;
            // 
            // colFechaEntrada
            // 
            colFechaEntrada.HeaderText = "Fecha Entrada";
            colFechaEntrada.MinimumWidth = 6;
            colFechaEntrada.Name = "colFechaEntrada";
            colFechaEntrada.Width = 125;
            // 
            // colLector
            // 
            colLector.HeaderText = "Lector";
            colLector.MinimumWidth = 6;
            colLector.Name = "colLector";
            colLector.Width = 125;
            // 
            // colLibro
            // 
            colLibro.HeaderText = "Libro";
            colLibro.MinimumWidth = 6;
            colLibro.Name = "colLibro";
            colLibro.Width = 125;
            // 
            // cmbLibro
            // 
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(194, 191);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(327, 28);
            cmbLibro.TabIndex = 28;
            // 
            // frmPrestamos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(920, 550);
            Controls.Add(cmbLibro);
            Controls.Add(dgvPrestamos);
            Controls.Add(cmbLector);
            Controls.Add(dtpFechaEntrada);
            Controls.Add(dtpFechaSalida);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnCrear);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPrestamos";
            Text = "frmPrestamos";
            Load += frmPrestamos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnCrear;
        private DataGridView dgvPrestamos;
        private DateTimePicker dtpFechaSalida;
        private DateTimePicker dtpFechaEntrada;
        private ComboBox cmbLector;
        private ComboBox cmbLibro;
        private DataGridViewTextBoxColumn colFechaSalida;
        private DataGridViewTextBoxColumn colFechaEntrada;
        private DataGridViewTextBoxColumn colLector;
        private DataGridViewTextBoxColumn colLibro;
    }
}