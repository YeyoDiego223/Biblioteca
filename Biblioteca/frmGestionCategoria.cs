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
    public partial class frmGestionCategoria : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        public string categoriaNueva { get; private set; }
        public frmGestionCategoria()
        {
            InitializeComponent();
        }

        private void CargarCategorias()
        {
            var dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT id_categoria, categoria FROM tbCategoria ORDER BY categoria;";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            lstCategoria.DataSource = dt;
            lstCategoria.DisplayMember = "categoria";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nuevaCategoria = txtNombreCategoria.Text.Trim();

            if (string.IsNullOrEmpty(nuevaCategoria))
            {
                MessageBox.Show("Por favor, ingrese una categoría");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tbCategoria (categoria) VALUES (@categoria);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@categoria", nuevaCategoria);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    this.categoriaNueva = nuevaCategoria;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el autor: " + ex.Message);
                }
            }
        }

        private void frmGestionCategoria_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }
    }
}
