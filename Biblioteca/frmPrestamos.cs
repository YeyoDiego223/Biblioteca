using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;


namespace Biblioteca
{
    public partial class frmPrestamos : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        private string fechaEntrada, fechaSalida;
        int lector, libro, posicion;
        private int idPrestamo = 0;
        public frmPrestamos()
        {
            InitializeComponent();
            llenarDataGridView();
            // Ajustar automáticamente el tamaño de las columnas para que se ajusten al contenido
            dgvPrestamos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            // Ajustar automáticamente el tamaño de la última columna rellenando el espacio restante
            dgvPrestamos.Columns[dgvPrestamos.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        void consultarID()
        {
            fechaSalida = dtpFechaSalida.Value.ToString("yyyy-MM-dd");
            fechaEntrada = dtpFechaEntrada.Value.ToString("yyyy-MM-dd");
            lector = (int)cmbLector.SelectedValue;
            libro = (int)cmbLibro.SelectedValue;
            this.idPrestamo = 0;

            string queryconsultar = "SELECT id_prestamo FROM tbPrestamo WHERE fecha_salida = @fecha_salida AND fecha_entrada = @fecha_entrada AND id_lector = @idLector AND id_libro = @idLibro";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryconsultar, conn))
                {
                    cmd.Parameters.AddWithValue("@fecha_salida", fechaSalida);
                    cmd.Parameters.AddWithValue("@fecha_entrada", fechaEntrada);
                    cmd.Parameters.AddWithValue("@idLector", lector);
                    cmd.Parameters.AddWithValue("@idLibro", libro);

                    try
                    {
                        conn.Open();

                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null)
                        {
                            this.idPrestamo = Convert.ToInt32(resultado);
                            MessageBox.Show("El ID del Préstamo es: " + this.idPrestamo);
                        }
                        else
                        {
                            this.idPrestamo = 0;
                            MessageBox.Show("No se encontró un préstamo con estos datos.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al consultar la base de datos: " + ex.Message);
                    }
                }
            }
        }

        void eliminarprestamo()
        {
            posicion = dgvPrestamos.CurrentRow.Index;
            string queryeliminar = "DELETE FROM tbPrestamo WHERE id_prestamo = @id_prestamo";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(queryeliminar, conn))
                {
                    cmd.Parameters.AddWithValue("@id_prestamo", this.idPrestamo);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Préstamo eliminado correctamente");
                        dgvPrestamos.Rows.RemoveAt(posicion);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar el Préstamo: {ex.Message}");
                    }
                }
            }
        }

        private void agregarprestamos()
        {
            fechaEntrada = dtpFechaEntrada.Value.ToString("yyyy-MM-dd");
            fechaSalida = dtpFechaSalida.Value.ToString("yyyy-MM-dd");
            lector = (int)cmbLector.SelectedValue;
            string lectortxt = cmbLector.Text;
            libro = (int)cmbLibro.SelectedValue;
            string librotxt = cmbLibro.Text;
            if (string.IsNullOrEmpty(cmbLector.Text) || string.IsNullOrEmpty(cmbLibro.Text))
            {
                MessageBox.Show("No debe haber campos vacíos");
                return;
            }

            string queryAgregar = "INSERT INTO tbPrestamo (fecha_salida, fecha_entrada, id_lector, id_libro) " +
                "VALUES (@fecha_salida, @fecha_entrada, @id_lector, @id_libro)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(queryAgregar, conn))
            {
                cmd.Parameters.AddWithValue("@fecha_salida", fechaSalida);
                cmd.Parameters.AddWithValue("@fecha_entrada", fechaEntrada);
                cmd.Parameters.AddWithValue("@id_lector", lector);
                cmd.Parameters.AddWithValue("@id_libro", libro);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Préstamo guardado con éxito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenarDataGridView();

                    cmbLector.SelectedItem = null;
                    cmbLibro.SelectedItem = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el prestamo" + ex.Message, "Error de Base de Dato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void modificarprestamos()
        {
            posicion = dgvPrestamos.CurrentRow.Index;
            fechaSalida = dtpFechaSalida.Value.ToString("yyyy-MM-dd");
            fechaEntrada = dtpFechaEntrada.Value.ToString("yyyy-MM-dd");
            lector = (int)cmbLector.SelectedValue;
            string lectortxt = cmbLector.Text;
            libro = (int)cmbLibro.SelectedValue;
            string librotxt = cmbLibro.Text;
            if (string.IsNullOrEmpty(cmbLector.Text) || string.IsNullOrEmpty(cmbLibro.Text))
            {
                MessageBox.Show("No debe haber campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string querymodificar = @"
        UPDATE tbPrestamo
        SET fecha_salida = @fecha_salida,
            fecha_entrada = @fecha_entrada,
            id_lector = @idLector,
            id_libro = @idLibro
        WHERE id_prestamo = @idPrestamo";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(querymodificar, conn))
            {
                cmd.Parameters.AddWithValue("@idPrestamo", this.idPrestamo);
                cmd.Parameters.AddWithValue("@fecha_salida", fechaSalida);
                cmd.Parameters.AddWithValue("@fecha_entrada", fechaEntrada);
                cmd.Parameters.AddWithValue("@idLector", lector);
                cmd.Parameters.AddWithValue("@idLibro", libro);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Préstamo actualizado correctamente.");
                    dgvPrestamos[0, posicion].Value = fechaSalida;
                    dgvPrestamos[1, posicion].Value = fechaEntrada;
                    dgvPrestamos[2, posicion].Value = lectortxt;
                    dgvPrestamos[3, posicion].Value = librotxt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el Préstamo: {ex.Message}");
                }
            }
            limpiar();
            dtpFechaSalida.Focus();
        }


        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            CargarLibros();
            CargarLectores();
        }

        private void CargarLectores()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string queryLectores = "SELECT id_lector, nombre FROM tbLector ORDER BY nombre;";
                SqlDataAdapter da = new SqlDataAdapter(queryLectores, conn);
                da.Fill(dt);
            }

            cmbLector.DataSource = dt;
            cmbLector.DisplayMember = "nombre";
            cmbLector.ValueMember = "id_lector";
            cmbLector.SelectedItem = null;
        }

        private void CargarLibros()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string queryLibros = "SELECT id_libro, titulo FROM tbLibros ORDER BY titulo;";
                SqlDataAdapter d = new SqlDataAdapter(queryLibros, conn);
                d.Fill(dt);
            }

            cmbLibro.DataSource = dt;
            cmbLibro.DisplayMember = "titulo";
            cmbLibro.ValueMember = "id_libro";
            cmbLibro.SelectedItem = null;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            agregarprestamos();
        }

        private void llenarDataGridView()
        {
            string query = @"
            SELECT p.fecha_salida, p.fecha_entrada, le.nombre, li.titulo 
            FROM tbPrestamo p
            JOIN tbLector le ON p.id_lector = le.id_lector
            JOIN tbLibros li ON p.id_libro = li.id_libro";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int rowIndex = dgvPrestamos.Rows.Add();
                            dgvPrestamos.Rows[rowIndex].Cells["colFechaSalida"].Value = reader["fecha_salida"];
                            dgvPrestamos.Rows[rowIndex].Cells["colFechaEntrada"].Value = reader["fecha_entrada"];
                            dgvPrestamos.Rows[rowIndex].Cells["colLector"].Value = reader["nombre"];
                            dgvPrestamos.Rows[rowIndex].Cells["colLibro"].Value = reader["titulo"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al llenar el DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void limpiar()
        {
            btnCrear.Enabled = true;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            cmbLector.Text = "";
            cmbLibro.Text = "";
        }

        private void dgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvPrestamos.Rows[e.RowIndex];
                if (filaSeleccionada.Cells[0].Value != null && filaSeleccionada.Cells[1].Value != null)
                {
                    posicion = dgvPrestamos.CurrentRow.Index;
                    dtpFechaSalida.Text = dgvPrestamos[0, posicion].Value.ToString();
                    dtpFechaEntrada.Text = dgvPrestamos[1, posicion].Value.ToString();
                    cmbLector.Text = dgvPrestamos[2, posicion].Value.ToString();
                    cmbLibro.Text = dgvPrestamos[3, posicion].Value.ToString();
                    consultarID();
                    btnCrear.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    dtpFechaSalida.Focus();
                }
                else
                {
                    MessageBox.Show("La fila seleccionada contiene celdas vacías.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            btnCrear.Enabled = true;
            dtpFechaSalida.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estas seguro de modificar este Prestamo?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                modificarprestamos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estas seguro que deseas eliminar este Prestamo?",
                                                    "Confirmacion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                eliminarprestamo();
                limpiar();
                dtpFechaSalida.Focus();
            }
        }

        private void cmbLector_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbLibro.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cmbLibro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCrear.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}

