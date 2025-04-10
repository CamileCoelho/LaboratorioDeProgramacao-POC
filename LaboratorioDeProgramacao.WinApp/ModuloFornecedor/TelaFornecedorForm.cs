using LaboratorioDeProgramacao.Dominio.ModuloFornecedor;

namespace LaboratorioDeProgramacao.WinApp.ModuloFornecedor
{
    public partial class TelaFornecedorForm : Form
    {
        private Fornecedor fornecedorSelecionado;

        public TelaFornecedorForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
            ConfigurarTextos();
        }

        internal Fornecedor ObterFornecedor()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtTitulo.Text;
            string endereco = txtValor.Text;

            return new Fornecedor(id, nome, endereco);
        }

        public void ConfigurarTela(Fornecedor fornecedor)
        {
            txtId.Text = fornecedor.id.ToString();
            txtTitulo.Text = fornecedor.nome;
            txtValor.Text = fornecedor.endereco;

            this.fornecedorSelecionado = fornecedor;
        }

        private void ConfigurarTextos()
        {
            lblNome.Text = TelaPrincipalForm.servicoDeTraducao.ObterTexto("Name") + ":";
            lblEndereco.Text = TelaPrincipalForm.servicoDeTraducao.ObterTexto("Address") + ":";
            btnGravar.Text = TelaPrincipalForm.servicoDeTraducao.ObterTexto("Save");
            btnCancelar.Text = TelaPrincipalForm.servicoDeTraducao.ObterTexto("Cancel");
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string status = "";

            var fornecedor = ObterFornecedor();

            if (fornecedor.nome.Length != 3)
                status = "O nome do fornecedor deve conter exatamente 3 letras.";
            else
                status = fornecedor.Validar();

            TelaPrincipalForm.Tela.AtualizarRodape(status);

            if (status != "")
                DialogResult = DialogResult.None;
        }
    }
}