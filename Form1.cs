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

            lbxContatos.Items.AddRange(ManipuladorArquivo.LerArquivo().ToArray());
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

            Contato contato = new Contato
            {
                Nome = txbNome.Text,
                Email = txbEmail.Text,
                NumeroTelefone = txbTelefone.Text,
            };

            List<Contato> contatosList = new List<Contato>();

            foreach (Contato contatoDaLista in lbxContatos.Items)
            {
                contatosList.Add(contatoDaLista);
            };

            contatosList.Add(contato);

            ManipuladorArquivo.EscreverArquivo(contatosList);

        }

        private void carregarListaDeContatos()
        {
            lbxContatos.Items.Clear();
            lbxContatos.Items.AddRange(ManipuladorArquivo.LerArquivo().ToArray());
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