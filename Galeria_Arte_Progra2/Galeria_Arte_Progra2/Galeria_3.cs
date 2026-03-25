namespace Galeria_Arte_Progra2
{
    public partial class Galeria_3 : Form
    {
        public Galeria_3()
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
    }
}