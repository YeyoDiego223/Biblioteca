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
    public partial class frmLibros : Form
    {
        // La lógica del constructor y del botón 'btnGuardarLibro' no cambia

        private string connectionString = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;

        public frmLibros()
        {
            InitializeComponent();
        }

        private void frmLibros_Load(object sender, EventArgs e)
        {
            CargarAutores();
            CargarCategorias();
            CargarEditoriales();
        }

        private void CargarAutores()
        {
            // Este método es casi identico al de la otra forma.
            // En una app más grande, esto estaría en una clase separada (Capa de Datos).
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT id_autor, nombre FROM tbAutor ORDER BY nombre;";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }

            // Configuramos el ComboBox para que funcione con los datos
            cmbAutores.DataSource = dt;
            cmbAutores.DisplayMember = "nombre"; // El texto que ve el usuario
            cmbAutores.ValueMember = "id_autor"; // El valor oculto (el ID)
            cmbAutores.SelectedItem = null;
        }

        private void CargarCategorias()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT id_categoria, categoria FROM tbCategoria ORDER BY categoria;";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            cmbCategoria.DataSource = dt;
            cmbCategoria.DisplayMember = "categoria";
            cmbCategoria.ValueMember = "id_categoria";
            cmbCategoria.SelectedItem = null;
        }

        private void CargarEditoriales()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT id_editorial, editorial FROM tbEditorial ORDER BY editorial;";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            cmbEditorial.DataSource = dt;
            cmbEditorial.DisplayMember = "editorial";
            cmbEditorial.ValueMember = "id_editorial";
            cmbEditorial.SelectedItem = null;
        }

        private void btnNuevoAutor_Click(object sender, EventArgs e)
        {
            using (frmGestionAutores formAutores = new frmGestionAutores())
            {
                // 2. Lo abrimos como un diálogo modal
                DialogResult resultado = formAutores.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    MessageBox.Show("!Regresamos al formulario de Libros! Actualizando autores...");

                    CargarAutores();

                    cmbAutores.SelectedItem = formAutores.AutorNuevo;
                }
            }
        }


        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            using (frmGestionCategoria formCategoria = new frmGestionCategoria())
            {
                DialogResult resultadoCategoria = formCategoria.ShowDialog();

                if (resultadoCategoria == DialogResult.OK)
                {
                    MessageBox.Show("!Regresamos al formulario de Libros! Actualizando categorías...");
                    CargarCategorias();

                    cmbCategoria.SelectedItem = formCategoria.categoriaNueva;
                }
            }
        }



        private void btnNuevoEditorial_Click(object sender, EventArgs e)
        {
            using (frmGestionEditorial formEditorial = new frmGestionEditorial())
            {
                DialogResult resultEditorial = formEditorial.ShowDialog();

                if (resultEditorial == DialogResult.OK)
                {
                    MessageBox.Show("!Regresamos al formulario de Libros! Actualizando editorial...");
                    CargarEditoriales();

                    cmbEditorial.SelectedItem = formEditorial.EditorialNuevo;
                }
            }
        }

        private void btnGuardarLibro_Click(object sender, EventArgs e)
        {
            // 1. Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtTituloLibro.Text) ||
                  cmbAutores.SelectedValue == null ||
                  cmbCategoria.SelectedValue == null ||
                  cmbEditorial.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios (Título, Autor, Categoría, Editorial).", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Obtener los valores de los controles
            string titulo = txtTituloLibro.Text;
            string ISBN = txtISBN.Text;
            int idAutor = (int)cmbAutores.SelectedValue;
            int idCategoria = (int)cmbCategoria.SelectedValue;
            int idEditorial = (int)cmbEditorial.SelectedValue;
            string idioma = txtIdioma.Text;
            string paginas = txtPaginas.Text;

            // 3. Crear y ejecutar el comando SQL
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Usamos parámetros para seguridad
                string query = "INSERT INTO tbLibros (ISBN, titulo, id_categoria, id_editorial, idioma, paginas, id_autor) VALUES (@ISBN, @titulo, @id_categoria, @id_editorial, @idioma, @paginas, @id_autor);";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ISBN", ISBN);
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.Parameters.AddWithValue("@id_categoria", idCategoria);
                    cmd.Parameters.AddWithValue("@id_editorial", idEditorial);
                    cmd.Parameters.AddWithValue("@idioma", idioma);
                    cmd.Parameters.AddWithValue("@paginas", paginas);
                    cmd.Parameters.AddWithValue("@id_autor", idAutor);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Libro guardado con éxito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Opcional: Limpiar los campos después de gaurdar
                        txtTituloLibro.Clear();
                        txtISBN.Clear();
                        txtIdioma.Clear();
                        txtPaginas.Clear();
                        cmbAutores.SelectedItem = null;
                        cmbCategoria.SelectedItem = null;
                        cmbEditorial.SelectedItem = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el libro: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtTituloLibro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtISBN.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtISBN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbAutores.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cmbAutores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbCategoria.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cmbCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbEditorial.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cmbEditorial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtIdioma.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtIdioma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPaginas.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtPaginas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGuardarLibro.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
