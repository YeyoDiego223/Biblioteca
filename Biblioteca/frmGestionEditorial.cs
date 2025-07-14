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

    }
}
