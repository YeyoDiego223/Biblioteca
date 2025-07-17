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
    }
}
