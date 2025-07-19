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
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Biblioteca
{
    public partial class frmGestionAutores : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        public string AutorNuevo { get; private set; }
        private int idAutorSeleccionado = 0;
        private string nombreDelAutor = "";

        public frmGestionAutores()
        {
            InitializeComponent();
        }

        private void frmGestionAutores_Load(object sender, EventArgs e)
        {
            CargarAutores();
        }

        private void CargarAutores()
        {
            // Este método ahora lee desde la base de datos
            var dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT id_autor, nombre FROM tbAutor ORDER BY nombre;";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            // Asignamos la tabla de datos como fuente del ListBox
            lstAutores.DataSource = dt;
            lstAutores.DisplayMember = "nombre"; // La columna que se mostrara
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nuevoAutor = txtNombreAutor.Text.Trim();

            if (string.IsNullOrEmpty(nuevoAutor))
            {
                MessageBox.Show("Por favor, ingrese un nombre.");
                return;
            }

            // Usamos 'using' para asegurar que la conexión se cierre correctamente
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // !Importante! usar parámetros para prevenir inyeccion SQL
                string query = "INSERT INTO tbAutor (nombre) VALUES (@nombre);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", nuevoAutor);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery(); // Ejecuta la insercion

                    this.AutorNuevo = nuevoAutor;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el autor: " + ex.Message);
                }
            }
        }

        private void lstAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Verifica que haya un elemento seleccionado.
            if (lstAutores.SelectedItems != null)
            {
                // 2. Convierte el elemento seleccionado a un DataRowView
                DataRowView drv = (DataRowView)lstAutores.SelectedItem;

                // 3. Accede al valor de la columna especifica por su nombre.
                // Usa el nombre de la columna que contiene el nombre del autor.
                this.nombreDelAutor = drv["nombre"].ToString();

                // -- Obtener y guardar el ID
                this.idAutorSeleccionado = Convert.ToInt32(drv["id_autor"]);

                // 4. Asigna ese valor al TextBox.
                txtNombreAutor.Text = nombreDelAutor;
            }
            else
            {
                // Si no hay nada seleccionado, reinicia el ID
                this.idAutorSeleccionado = 0;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.idAutorSeleccionado == 0)
            {
                MessageBox.Show("Por favor, seleccione un autor de la lista para eliminar.");
                return;
            }

            // Pide confirmación al usuario
            var confirmacion = MessageBox.Show(
                "Estas seguro de que quieres eliminar a este autor?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (confirmacion == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE from tbAutor WHERE id_autor = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Usa la variable de la clase que guardo el ID
                        cmd.Parameters.AddWithValue("@id", this.idAutorSeleccionado);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Autor eliminado con éxito.");
                    }
                }

                CargarAutores();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.idAutorSeleccionado == 0)
            {
                MessageBox.Show("Por favor, seleccione un autor de la lista para editar.");
                return;
            }

            string txtAutorseleccionado = txtNombreAutor.Text;

            // Pide confirmación al usuario
            var confirmacion = MessageBox.Show(
                "¿Estas seguro de que quieres editar a este autor?",
                "Confirmar Edición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (confirmacion == DialogResult.Yes)
            {
                string query = "UPDATE tbAutor SET nombre = @nombre WHERE id_autor = @id";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Usa la variable de la clase que guardo el ID
                    cmd.Parameters.AddWithValue("@id", this.idAutorSeleccionado);
                    cmd.Parameters.AddWithValue("@nombre", txtAutorseleccionado);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Autor editado con éxito.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al actualizar Autor: {ex.Message}");
                    }
                                       
                }

                CargarAutores();
            }
        }
    }
}
