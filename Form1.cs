namespace AgendaContatosTreinaweb
{
    public partial class frmAgendaContatos : Form
    {
        public frmAgendaContatos()
        {
            InitializeComponent();
        }

        private void frmAgendaContatos_Shown(object sender, EventArgs e)
        {
            alterarBotoesSalvarECancelar(false);
            alterarBotaoAdicionarAlterarExcluir(true);
        }

        private void alterarBotoesSalvarECancelar(bool estado) 
        {
            btnSalvar.Enabled = estado;
            btnCancelar.Enabled = estado;

        }

        private void alterarBotaoAdicionarAlterarExcluir(bool estado)
        {
            btnAdicionar.Enabled = estado;
            btnAlterar.Enabled = estado;
            btnExcluir.Enabled = estado;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            alterarBotoesSalvarECancelar(true);
            alterarBotaoAdicionarAlterarExcluir(false);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarBotoesSalvarECancelar(true);
            alterarBotaoAdicionarAlterarExcluir(false);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            alterarBotoesSalvarECancelar(true);
            alterarBotaoAdicionarAlterarExcluir(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            alterarBotoesSalvarECancelar(false);
            alterarBotaoAdicionarAlterarExcluir(true);
        }
    }
}