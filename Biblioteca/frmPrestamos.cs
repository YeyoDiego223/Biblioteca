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
        int lector, libro;
        public frmPrestamos()
        {
            InitializeComponent();
            llenarDataGridView();
            
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
                    dgvPrestamos.Rows.Add(fechaSalida, fechaEntrada, lectortxt, librotxt);

                    cmbLector.SelectedItem = null;
                    cmbLibro.SelectedItem = null;
                    llenarDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el prestamo" + ex.Message, "Error de Base de Dato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void dgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

