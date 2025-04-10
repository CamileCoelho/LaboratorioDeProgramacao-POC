using LaboratorioDeProgramacao.Dominio.ModuloProduto;
using LaboratorioDeProgramacao.Dominio.ModuloVenda;
using LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloItemVenda;

namespace LaboratorioDeProgramacao.WinApp.ModuloVenda
{
    public partial class TelaVendaForm : Form
    {
        private List<Produto> produtos;
        private List<ItemVenda> itensAdicionados = new();
        private int contadorIds = 1;
        private Venda venda;

        private readonly Dictionary<FormaPagamento, string> formasPagamentoExibicao;

        public TelaVendaForm(List<Produto> produtos)
        {
            InitializeComponent();

            this.produtos = produtos;

            formasPagamentoExibicao = new()
            {
                { FormaPagamento.Dinheiro, TelaPrincipalForm.servicoDeTraducao.ObterTexto("Money") },
                { FormaPagamento.CartaoCredito, TelaPrincipalForm.servicoDeTraducao.ObterTexto("CreditCard") },
                { FormaPagamento.CartaoDebito, TelaPrincipalForm.servicoDeTraducao.ObterTexto("DebitCard") },
                { FormaPagamento.Pix, TelaPrincipalForm.servicoDeTraducao.ObterTexto("Pix") },
                { FormaPagamento.Boleto, TelaPrincipalForm.servicoDeTraducao.ObterTexto("BankSlip") }
            };

            CarregarFormasPagamento();
            CarregarProdutos();
            InicializarTabela();
            ConfigurarTextos();
        }

        private void CarregarProdutos()
        {
            cmbItens.Items.Clear();

            foreach (var produto in produtos)
                cmbItens.Items.Add(produto);
        }

        private void InicializarTabela()
        {
            TabelaItensControl tabela = new();
            tabela.Dock = DockStyle.Fill;
            panelAlternativas.Controls.Add(tabela);
            panelAlternativas.Tag = tabela;
        }

        private TabelaItensControl ObterTabela()
        {
            return panelAlternativas.Controls.OfType<TabelaItensControl>().FirstOrDefault();
        }

        private void CarregarFormasPagamento()
        {
            cmbFormaPagamento.Items.Clear();

            foreach (var item in formasPagamentoExibicao)
                cmbFormaPagamento.Items.Add(item.Value);

            cmbFormaPagamento.SelectedIndex = 0;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cmbItens.SelectedItem is not Produto produtoSelecionado)
            {
                MessageBox.Show(TelaPrincipalForm.servicoDeTraducao.ObterTexto("SelectProductWarning"),
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantidade.Text, out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show(TelaPrincipalForm.servicoDeTraducao.ObterTexto("InvalidQuantityWarning"),
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantidade > produtoSelecionado.quantidade)
            {
                MessageBox.Show(TelaPrincipalForm.servicoDeTraducao.ObterTexto("InsufficientStockWarning"),
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = new ItemVenda(contadorIds++, produtoSelecionado, quantidade);
            itensAdicionados.Add(item);

            AtualizarTabela();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var tabela = ObterTabela();
            int idSelecionado = tabela.ObterNumeroItemSelecionado();

            var item = itensAdicionados.FirstOrDefault(i => i.id == idSelecionado);

            if (item != null)
            {
                itensAdicionados.Remove(item);
                AtualizarTabela();
            }
        }

        private void AtualizarTabela()
        {
            var tabela = ObterTabela();
            tabela.AtualizarRegistros(itensAdicionados);
        }

        private void ConfigurarTextos()
        {
            lblItem.Text = TelaPrincipalForm.servicoDeTraducao.ObterTexto("Product");
            lblQuantidade.Text = TelaPrincipalForm.servicoDeTraducao.ObterTexto("Quantity");
            lblFormaPgto.Text = TelaPrincipalForm.servicoDeTraducao.ObterTexto("PaymentMethod");
            lblCpf.Text = TelaPrincipalForm.servicoDeTraducao.ObterTexto("CPF");
            lblData.Text = TelaPrincipalForm.servicoDeTraducao.ObterTexto("Date");
            btnAdicionar.Text = TelaPrincipalForm.servicoDeTraducao.ObterTexto("Add");
            btnRemover.Text = TelaPrincipalForm.servicoDeTraducao.ObterTexto("Remove");
            btnGravar.Text = TelaPrincipalForm.servicoDeTraducao.ObterTexto("Save");
            btnCancelar.Text = TelaPrincipalForm.servicoDeTraducao.ObterTexto("Cancel");
        }

        internal Venda ObterVenda()
        {
            string cpf = txtCpf.Text;
            DateTime data = dateTimePicker.Value;
            string formaSelecionada = cmbFormaPagamento.SelectedItem?.ToString() ?? "";

            FormaPagamento formaPagamento = formasPagamentoExibicao
                .FirstOrDefault(x => x.Value == formaSelecionada).Key;

            return new Venda
            {
                cpf = cpf,
                formaPagamento = formaPagamento.ToString(),
                data = data,
                itens = itensAdicionados
            };
        }

        public void ConfigurarTelaEdicao(Venda venda)
        {
            txtCpf.Text = venda.cpf;
            dateTimePicker.Value = venda.data;

            this.venda = venda;

            if (Enum.TryParse<FormaPagamento>(venda.formaPagamento, out var forma))
            {
                string descricao = formasPagamentoExibicao[forma];
                cmbFormaPagamento.SelectedItem = descricao;
            }

            itensAdicionados = venda.itens ?? new List<ItemVenda>();
            AtualizarTabela();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (itensAdicionados.Count == 0)
            {
                MessageBox.Show(
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("AddAtLeastOneItemWarning"),
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("Warning"),
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }

            venda = ObterVenda();
            string validacao = venda.Validar();

            TelaPrincipalForm.Tela.AtualizarRodape(validacao);

            if (!string.IsNullOrEmpty(validacao))
                DialogResult = DialogResult.None;
        }
    }
}
