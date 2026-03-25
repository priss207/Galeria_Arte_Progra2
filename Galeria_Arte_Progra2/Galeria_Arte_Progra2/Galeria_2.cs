namespace Galeria_Arte_Progra2
{
    public partial class Galeria_2 : Form
    {
        public Galeria_2()
        {
            InitializeComponent();

            // Configuración de pantalla completa
            this.WindowState = FormWindowState.Maximized;  // Inicia maximizado
            this.FormBorderStyle = FormBorderStyle.None;   // Sin bordes ni botones
            this.TopMost = true;                           // Siempre al frente
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Para salir con la tecla ESC
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Application.Exit();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            // Crear y mostrar la nueva ventana (Galeria_2)
            Galeria_3 nuevaGaleria = new Galeria_3();
            nuevaGaleria.Show();

            // Cerrar la ventana actual
            this.Close();
        }

        private void btn_Anterior_Click(object sender, EventArgs e)
        {
            
            // Crear la nueva galería
            Galeria_1 nuevaGaleria = new Galeria_1();

            // Mostrar la nueva galería
            nuevaGaleria.Show();

            // Cerrar SOLO este formulario
            this.Hide();
        }
    }
}