using LaboratorioDeProgramacao.Dominio.ModuloFornecedor;
using LaboratorioDeProgramacao.Dominio.ModuloProduto;
using LaboratorioDeProgramacao.Dominio.ModuloVenda;
using LaboratorioDeProgramacao.WinApp.ModuloDiciplina;
using LaboratorioDeProgramacao.WinApp.ModuloDisciplina;

namespace LaboratorioDeProgramacao.WinApp.ModuloProduto
{
    public class ControladorProduto : ControladorBase
    {
        private readonly IRepositorioProduto repositorioProduto;
        private readonly IRepositorioFornecedor repositorioFornecedor;
        private readonly IRepositorioVenda repositorioVenda;

        private TabelaProdutoControl tabelaProduto = new();

        public ControladorProduto(IRepositorioProduto repositorioProduto,
                                  IRepositorioFornecedor repositorioFornecedor,
                                  IRepositorioVenda repositorioVenda)
        {
            this.repositorioProduto = repositorioProduto;
            this.repositorioFornecedor = repositorioFornecedor;
            this.repositorioVenda = repositorioVenda;
        }

        public override bool HomeHabilitado => true;
        public override bool InserirHabilitado => true;
        public override bool EditarHabilitado => true;
        public override bool EditarVisivel => true;
        public override bool ExcluirHabilitado => true;

        public override string ToolTipInserir => TelaPrincipalForm.servicoDeTraducao.ObterTexto("InsertTooltip");
        public override string ToolTipExcluir => TelaPrincipalForm.servicoDeTraducao.ObterTexto("DeleteTooltip");
        public override string ToolTipHome => TelaPrincipalForm.servicoDeTraducao.ObterTexto("HomeTooltip");

        public override void Inserir()
        {
            var fornecedores = repositorioFornecedor.SelecionarTodos();
            var produtos = repositorioProduto.SelecionarTodos();

            if (fornecedores.Count == 0)
            {
                MessageBox.Show(
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("NoSuppliersWarning"),
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("ProductInsertTitle"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            TelaProdutoForm tela = new(produtos, fornecedores);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                Produto produto = tela.ObterProduto();

                repositorioProduto.Inserir(produto);

                CarregarProdutos();
            }
            else
            {
                TelaPrincipalForm.Tela.AtualizarRodape("");
            }
        }

        public override void Editar()
        {
            Produto produtoSelecionado = ObterProdutoSelecionado();

            if (produtoSelecionado == null)
            {
                MessageBox.Show(
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("SelectProductFirst"),
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("ProductEditTitle"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            var fornecedores = repositorioFornecedor.SelecionarTodos();
            var produtos = repositorioProduto.SelecionarTodos();

            if (fornecedores.Count == 0)
            {
                MessageBox.Show(
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("NoSuppliersWarning"),
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("ProductEditTitle"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            TelaProdutoForm tela = new(produtos, fornecedores);
            tela.ConfigurarTela(produtoSelecionado);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                Produto produto = tela.ObterProduto();

                repositorioProduto.Editar(produtoSelecionado, produto);

                CarregarProdutos();
            }
            else
            {
                TelaPrincipalForm.Tela.AtualizarRodape("");
            }
        }

        public override void Excluir()
        {
            Produto produto = ObterProdutoSelecionado();

            if (produto == null)
            {
                MessageBox.Show(
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("SelectProductFirst"),
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("ProductDeleteTitle"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            var vendas = repositorioVenda.SelecionarTodos();
            bool produtoVinculadoAVenda = vendas.Any(v => v.itens.Any(i => i.produto == produto));

            if (produtoVinculadoAVenda)
            {
                MessageBox.Show(
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("ProductDeleteLinkedWarning"),
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("ProductDeleteTitle"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show(
                string.Format(TelaPrincipalForm.servicoDeTraducao.ObterTexto("ConfirmProductDeletion"), produto.titulo),
                TelaPrincipalForm.servicoDeTraducao.ObterTexto("ProductDeleteTitle"),
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioProduto.Excluir(produto);

                CarregarProdutos();
            }
        }

        public override UserControl ObterListagem()
        {
            if (tabelaProduto == null)
                tabelaProduto = new TabelaProdutoControl();

            CarregarProdutos();

            return tabelaProduto;
        }

        private void CarregarProdutos()
        {
            List<Produto> produtos = repositorioProduto.SelecionarTodos();

            tabelaProduto.AtualizarRegistros(produtos);
        }

        private Produto ObterProdutoSelecionado()
        {
            int id = tabelaProduto.ObterNumeroProdutoSelecionado();

            return repositorioProduto.SelecionarPorId(id);
        }
    }
}