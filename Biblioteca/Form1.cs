namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            frmLibros frmLibros = new frmLibros();
            frmLibros.Show();
        }

        private void btnLectores_Click(object sender, EventArgs e)
        {
            frmGestionLectores frmLectores = new frmGestionLectores();
            frmLectores.Show();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            frmPrestamos frmPrestamos = new frmPrestamos();
            frmPrestamos.Show();
        }
    }
}
