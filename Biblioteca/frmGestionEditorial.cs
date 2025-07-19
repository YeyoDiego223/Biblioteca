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
    public partial class frmGestionEditorial : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        private string nombreeditorial;
        private int ideditorial = 0;
        public string EditorialNuevo { get; private set; }
        public frmGestionEditorial()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nuevoEditorial = txtNombreEditorial.Text.Trim();

            if (string.IsNullOrEmpty(nuevoEditorial))
            {
                MessageBox.Show("Por favor, ingrese un nombre.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tbEditorial (editorial) VALUES (@editorial);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@editorial", nuevoEditorial);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    this.EditorialNuevo = nuevoEditorial;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el autor: " + ex.Message);
                }

            }
        }

        private void CargarEditorial()
        {
            var dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT id_editorial, editorial FROM tbEditorial ORDER BY editorial;";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            lstEditorial.DataSource = dt;
            lstEditorial.DisplayMember = "editorial";
        }

        private void frmGestionEditorial_Load(object sender, EventArgs e)
        {
            CargarEditorial();
        }

        private void lstEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Verifica que haya un elemento seleccionado.
            if (lstEditorial.SelectedItems != null)
            {
                // 2. Convierte el elemento seleccionado a un DataRowView
                DataRowView drv = (DataRowView)lstEditorial.SelectedItem;

                // 3. Accede al valor de la columna especifica por su nombre.
                // Usa el nombre de la columna que contiene el nombre del autor.
                this.nombreeditorial = drv["editorial"].ToString();

                // -- Obtener y guardar el ID
                this.ideditorial = Convert.ToInt32(drv["id_editorial"]);

                // 4. Asigna ese valor al TextBox.
                txtNombreEditorial.Text = nombreeditorial;
            }
            else
            {
                // Si no hay nada seleccionado, reinicia el ID
                this.ideditorial = 0;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.ideditorial == 0)
            {
                MessageBox.Show("Por favor, seleccione una editorial de la lista para eliminar.");
                return;
            }

            // Pide confirmación al usuario
            var confirmacion = MessageBox.Show(
                "Estas seguro de que quieres eliminar a esta editorial?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (confirmacion == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE from tbEditorial WHERE id_editorial = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Usa la variable de la clase que guardo el ID
                        cmd.Parameters.AddWithValue("@id", this.ideditorial);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Autor eliminado con éxito.");
                    }
                }

                CargarEditorial();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.ideditorial == 0)
            {
                MessageBox.Show("Por favor, seleccione una editorial de la lista para editar.");
                return;
            }

            string txtEditorialSeleccionada = txtNombreEditorial.Text;

            // Pide confirmación al usuario
            var confirmacion = MessageBox.Show(
                "¿Estas seguro de que quieres editar a esta editorial?",
                "Confirmar Edición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (confirmacion == DialogResult.Yes)
            {
                string query = "UPDATE tbEditorial SET editorial = @editorial WHERE id_editorial = @id";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Usa la variable de la clase que guardo el ID
                    cmd.Parameters.AddWithValue("@id", this.ideditorial);
                    cmd.Parameters.AddWithValue("@editorial", txtEditorialSeleccionada);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Editorial editada con éxito.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al actualizar editorial: {ex.Message}");
                    }

                }

                CargarEditorial();
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string nuevaEditorial = txtNombreEditorial.Text.Trim();

            if (string.IsNullOrEmpty(nuevaEditorial))
            {
                MessageBox.Show("Por favor, ingrese una editorial.");
                return;
            }

            // Usamos 'using' para asegurar que la conexión se cierre correctamente
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // !Importante! usar parámetros para prevenir inyeccion SQL
                string query = "INSERT INTO tbEditorial (editorial) VALUES (@editorial);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@editorial", nuevaEditorial);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery(); // Ejecuta la insercion

                    this.EditorialNuevo = nuevaEditorial;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la editorial: " + ex.Message);
                }
            }
        }
    }
}
