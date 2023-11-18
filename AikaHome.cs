namespace AikaHelp_ByGrifinory
{
    public partial class AikaHome : Form
    {
        public AikaHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimuladorDeSkills simuladorForm = new();
            simuladorForm.Show(); // Abre o formulário SimuladorDeSkills.cs
        }

        private void AikaHome_Load(object sender, EventArgs e)
        {

        }
        private void AikaHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Isso irá encerrar o aplicativo completamente.
        }
    }
}