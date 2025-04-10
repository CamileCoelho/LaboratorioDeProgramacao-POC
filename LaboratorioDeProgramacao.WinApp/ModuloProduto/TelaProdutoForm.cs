using LaboratorioDeProgramacao.Dominio.ModuloFornecedor;
using LaboratorioDeProgramacao.Dominio.ModuloProduto;

namespace LaboratorioDeProgramacao.WinApp.ModuloDisciplina
{
    public partial class TelaProdutoForm : Form
    {
        private Produto produto { get; set; }
        private Produto produtoSelecionado { get; set; }
        private List<Produto> produtos { get; set; }

        public TelaProdutoForm(List<Produto> produtos, List<Fornecedor> fornecedores)
        {
            InitializeComponent();
            this.ConfigurarDialog();

            this.produtos = produtos;

            CarregarFornecedores(fornecedores);
            ConfigurarTextos();
        }

        internal Produto ObterProduto()
        {
            int id = Convert.ToInt32(txtId.Text);
            string titulo = txtTitulo.Text;
            float valor = float.Parse(txtValor.Text);
            int quantidade = int.Parse(txtQuantidade.Text);
            Fornecedor fornecedor = cmbFornecedores.SelectedItem as Fornecedor;

            return new Produto(id, titulo, valor, quantidade, fornecedor);
        }

        public void ConfigurarTela(Produto produtoSelecionado)
        {
            txtId.Text = produtoSelecionado.id.ToString();
            txtTitulo.Text = produtoSelecionado.titulo;
            txtValor.Text = produtoSelecionado.valorUnitario.ToString("F2");
            txtQuantidade.Text = produtoSelecionado.quantidade.ToString();
            cmbFornecedores.SelectedItem = produtoSelecionado.fornecedor;

            this.produtoSelecionado = produtoSelecionado;
        }

        private void ConfigurarTextos()
        {
            lblTitulo.Text = TelaPrincipalForm.servicoDeTraducao.ObterTexto("Title") + ":";
            labelFornecedor.Text = TelaPrincipalForm.servicoDeTraducao.ObterTexto("Supplier") + ":";
            lblValorUnitario.Text = TelaPrincipalForm.servicoDeTraducao.ObterTexto("UnitValue") + ":";
            lblQuantidadeEstoque.Text = TelaPrincipalForm.servicoDeTraducao.ObterTexto("StockAmount") + ":";
            btnGravar.Text = TelaPrincipalForm.servicoDeTraducao.ObterTexto("Save");
            btnCancelar.Text = TelaPrincipalForm.servicoDeTraducao.ObterTexto("Cancel");
        }

        private void CarregarFornecedores(List<Fornecedor> fornecedores)
        {
            cmbFornecedores.Items.Clear();
            foreach (var fornecedor in fornecedores)
                cmbFornecedores.Items.Add(fornecedor);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string status = "";

            produto = ObterProduto();

            if (produtos.Where(i => produto.id != produtoSelecionado?.id).Any(x => x.titulo == produto.titulo))
                status = $"Já existe um produto cadastrado com esse título!";
            else
                status = produto.Validar();

            TelaPrincipalForm.Tela.AtualizarRodape(status);

            if (status != "")
                DialogResult = DialogResult.None;
        }
    }
}