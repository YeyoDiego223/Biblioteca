using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Biblioteca
{
    public partial class frmGestionLectores : Form
    {
        int posicion;
        private int idLector = 0;
        string nombre, app, apm, telefono, telefonopattern = @"^-?\d*\.?\d+$";
        private string connectionString = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;

        public frmGestionLectores()
        {
            InitializeComponent();
            llenarDataGridView();
            limpiar();
        }

        private void frmGestionLectores_Load(object sender, EventArgs e)
        {

        }

        void eliminarbase()
        {
            posicion = dgvLectores.CurrentRow.Index;
            string queryeliminar = "DELETE FROM tbLector WHERE id_lector = @id_lector";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(queryeliminar, conn))
                {
                    cmd.Parameters.AddWithValue("@id_lector", this.idLector);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Lector eliminado correctamente");
                        dgvLectores.Rows.RemoveAt(posicion);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar Lector: {ex.Message}");
                    }
                }
            }
        }

        void consultarID()
        {
            nombre = txtNombre.Text;
            app = txtApellidoPaterno.Text;
            apm = txtApellidoMaterno.Text;
            telefono = txtTelefono.Text;
            this.idLector = 0; // Inicializamos en 0 para saber si se encontró o no.

            // 1. Consulta SQL corregida con AND
            string queryconsultar = "SELECT id_lector FROM tbLector WHERE nombre = @nombre AND app = @app AND apm = @apm AND telefono = @telefono";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryconsultar, conn))
                {
                    // 2. Agregar solo los parámetros que si usa la consulta.
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@app", app);
                    cmd.Parameters.AddWithValue("@apm", apm);
                    cmd.Parameters.AddWithValue("@telefono", telefono);

                    try
                    {
                        conn.Open();
                        // 3. Ejecutar la consulta y obtener el resultado
                        // ExecuteScalar() es perfecto para obtener un solo valor (como un ID).
                        object resultado = cmd.ExecuteScalar();

                        // 4. Verificar si se encontró un resultado antes de usarlo 
                        if (resultado != null)
                        {
                            this.idLector = Convert.ToInt32(resultado);
                            MessageBox.Show("El ID del lector es: " + this.idLector);
                        }
                        else
                        {
                            this.idLector = 0;
                            MessageBox.Show("No se encontró un lector con esos datos.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al consultar la base de datos: " + ex.Message);
                    }
                }
            }
        }

        void agregarbase()
        {
            nombre = txtNombre.Text;
            app = txtApellidoPaterno.Text;
            apm = txtApellidoMaterno.Text;
            telefono = txtTelefono.Text;
            if (nombre == "" || app == "" || apm == "" || telefono == "")
            {
                MessageBox.Show("No debe hacer campos vacíos");
                return;
            }
            if (!Regex.IsMatch(txtTelefono.Text, telefonopattern))
            {
                MessageBox.Show("El teléfono debe ser un número valido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                txtTelefono.Text = "";
                return;
            }
            string query = "INSERT INTO tbLector (nombre, app, apm, telefono) " +
                "VALUES (@nombre, @app, @apm, @telefono)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@app", app);
                cmd.Parameters.AddWithValue("@apm", apm);
                cmd.Parameters.AddWithValue("@telefono", telefono);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lector agregado.");
                    dgvLectores.Rows.Add(nombre, app, apm, telefono);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar cliente {ex.Message}");
                }
            }
            limpiar();
            txtNombre.Focus();
        }

        void modificarbase()
        {
            posicion = dgvLectores.CurrentRow.Index;
            nombre = txtNombre.Text;
            app = txtApellidoPaterno.Text;
            apm = txtApellidoMaterno.Text;
            telefono = txtTelefono.Text;

            if (nombre == "" || app == "" || apm == "" || telefono == "")
            {
                MessageBox.Show("No debe haber campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(txtTelefono.Text, telefonopattern))
            {
                MessageBox.Show("El teléfono debe ser un número valido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                txtTelefono.Text = "";
                return;
            }

            if (this.idLector == 0)
            {
                MessageBox.Show("Por favor, selecciona un lector de la lista para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string querymodificar = @"
        UPDATE tbLector
        SET nombre = @nombre,
            app = @app,
            apm = @apm,
            telefono = @telefono
        WHERE id_lector = @id_lector";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(querymodificar, conn))
            {
                cmd.Parameters.AddWithValue("@id_lector", this.idLector);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@app", app);
                cmd.Parameters.AddWithValue("@apm", apm);
                cmd.Parameters.AddWithValue("@telefono", telefono);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lector actualizado correctamente.");
                    dgvLectores[0, posicion].Value = txtNombre.Text;
                    dgvLectores[1, posicion].Value = txtApellidoPaterno.Text;
                    dgvLectores[2, posicion].Value = txtApellidoMaterno.Text;
                    dgvLectores[3, posicion].Value = txtTelefono.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar Cliente: {ex.Message}");
                }
            }
            limpiar();
            txtNombre.Focus();
        }

        private void llenarDataGridView()
        {
            string query = "SELECT id_lector, nombre, app, apm, telefono FROM tbLector";

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
                            int rowIndex = dgvLectores.Rows.Add();
                            dgvLectores.Rows[rowIndex].Cells["colNombre"].Value = reader["nombre"];
                            dgvLectores.Rows[rowIndex].Cells["colApellidoPaterno"].Value = reader["app"];
                            dgvLectores.Rows[rowIndex].Cells["colApellidoMaterno"].Value = reader["apm"];
                            dgvLectores.Rows[rowIndex].Cells["colTelefono"].Value = reader["telefono"];
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
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtTelefono.Text = "";
            txtApellidoMaterno.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            btnCrear.Enabled = true;
            txtNombre.Focus();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            agregarbase();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estas seguro de modificar este cliente?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                modificarbase();
            }
        }

        private void dgvLectores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvLectores.Rows[e.RowIndex];
                if (filaSeleccionada.Cells[0].Value != null && filaSeleccionada.Cells[1].Value != null)
                {
                    posicion = dgvLectores.CurrentRow.Index;
                    txtNombre.Text = dgvLectores[0, posicion].Value.ToString();
                    txtApellidoPaterno.Text = dgvLectores[1, posicion].Value.ToString();
                    txtApellidoMaterno.Text = dgvLectores[2, posicion].Value.ToString();
                    txtTelefono.Text = dgvLectores[3, posicion].Value.ToString();
                    consultarID();
                    btnCrear.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    txtNombre.Focus();
                }
                else
                {
                    MessageBox.Show("La fila seleccionada contiene celdas vacías.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estas seguro que deseas eliminar este cliente?",
                                                    "Confirmacion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                eliminarbase();
                limpiar();
                txtNombre.Focus();
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtApellidoPaterno.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtApellidoPaterno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtApellidoMaterno.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtApellidoMaterno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTelefono.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
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
