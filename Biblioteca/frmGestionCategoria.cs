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
        private string nombreCategoria;
        private int idCategoria = 0;
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

        private void lstCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategoria.SelectedItems != null)
            {
                DataRowView drv = (DataRowView)lstCategoria.SelectedItem;

                this.nombreCategoria = drv["categoria"].ToString();

                this.idCategoria = Convert.ToInt32(drv["id_categoria"]);

                txtNombreCategoria.Text = nombreCategoria;
            }
            else
            {
                this.idCategoria = 0;
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.idCategoria == 0)
            {
                MessageBox.Show("Por favor, seleccione una categoría de la lista para eliminar.");
                return;
            }

            // Pide confirmación al usuario
            var confirmacion = MessageBox.Show(
                "Estas seguro de que quieres eliminar a esta categoría ?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (confirmacion == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE from tbCategoria WHERE id_categoria = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Usa la variable de la clase que guardo el ID
                        cmd.Parameters.AddWithValue("@id", this.idCategoria);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Categoría eliminada con éxito.");
                    }
                }

                CargarCategorias();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.idCategoria == 0)
            {
                MessageBox.Show("Por favor, seleccione una categoría de la lista para editar.");
                return;
            }

            string txtCategoriaSeleccionada = txtNombreCategoria.Text;

            var confirmacion = MessageBox.Show(
                "¿Estas seguro que quieres editar esta categoría?",
                "Confirmar Edición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (confirmacion == DialogResult.Yes)
            {
                string query = "UPDATE tbCategoria SET categoria = @categoria WHERE id_categoria = @id";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", this.idCategoria);
                    cmd.Parameters.AddWithValue("@categoria", txtCategoriaSeleccionada);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Categoría editada con éxito.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al editar Categoría: {ex.Message}");
                    }
                }

                CargarCategorias();
            }
        }
    }
}
