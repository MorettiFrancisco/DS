namespace IntegracionForm
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntegracionForm.altaVenta abrirForm = new altaVenta();
            abrirForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IntegracionForm.altaCobranza abrirForm = new altaCobranza();
            abrirForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
