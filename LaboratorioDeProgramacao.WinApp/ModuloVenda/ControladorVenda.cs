using LaboratorioDeProgramacao.Dominio.ModuloProduto;
using LaboratorioDeProgramacao.Dominio.ModuloVenda;

namespace LaboratorioDeProgramacao.WinApp.ModuloVenda
{
    public class ControladorVenda : ControladorCupom
    {
        private readonly IRepositorioVenda repositorioVenda;
        private readonly IRepositorioProduto repositorioProduto;
        private TabelaVendaControl tabelaVenda;

        public ControladorVenda(IRepositorioVenda repositorioVenda, IRepositorioProduto repositorioProduto)
        {
            this.repositorioVenda = repositorioVenda;
            this.repositorioProduto = repositorioProduto;
        }

        public override void Inserir()
        {
            var produtos = repositorioProduto.SelecionarTodos();

            TelaVendaForm tela = new(produtos);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                var venda = tela.ObterVenda();

                string validacao = ValidarVenda(venda);

                if (!string.IsNullOrEmpty(validacao))
                {
                    TelaPrincipalForm.Tela.AtualizarRodape(validacao);
                    return;
                }

                repositorioVenda.Inserir(venda);

                CarregarVendas();
            }
            else
                TelaPrincipalForm.Tela.AtualizarRodape("");
        }

        public override void GerarPdf()
        {
            var vendaSelecionada = ObterVendaSelecionada();

            if (vendaSelecionada == null)
            {
                MessageBox.Show(
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("SelectSaleWarning"),
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("GenerateReceipt"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
                return;
            }

            GerarPdfCupom(vendaSelecionada); 
        }

        public override void Editar()
        {
            var vendaSelecionada = ObterVendaSelecionada();

            if (vendaSelecionada == null)
            {
                MessageBox.Show(
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("SelectSaleWarning"),
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("EditSale"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
                return;
            }

            var produtos = repositorioProduto.SelecionarTodos();

            var tela = new TelaVendaForm(produtos);
            tela.ConfigurarTelaEdicao(vendaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                var novaVenda = tela.ObterVenda();

                string validacao = ValidarVenda(novaVenda);

                if (!string.IsNullOrEmpty(validacao))
                {
                    TelaPrincipalForm.Tela.AtualizarRodape(validacao);
                    return;
                }

                repositorioVenda.Editar(vendaSelecionada, novaVenda);

                CarregarVendas();
            }
            else
                TelaPrincipalForm.Tela.AtualizarRodape("");
        }

        public override void Excluir()
        {
            var vendaSelecionada = ObterVendaSelecionada();

            if (vendaSelecionada == null)
            {
                MessageBox.Show(
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("SelectSaleWarning"),
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("DeleteSale"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
                return;
            }

            var opcao = MessageBox.Show(
                string.Format(TelaPrincipalForm.servicoDeTraducao.ObterTexto("DeleteSaleConfirmation"), vendaSelecionada.id),
                TelaPrincipalForm.servicoDeTraducao.ObterTexto("DeleteSale"),
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (opcao == DialogResult.OK)
            {
                repositorioVenda.Excluir(vendaSelecionada);
                CarregarVendas();
            }
        }

        private void CarregarVendas()
        {
            var vendas = repositorioVenda.SelecionarTodos();
            tabelaVenda.AtualizarRegistros(vendas);
        }

        private Venda ObterVendaSelecionada()
        {
            int id = tabelaVenda.ObterNumeroVendaSelecionada();
            return repositorioVenda.SelecionarPorId(id);
        }

        private string ValidarVenda(Venda venda)
        {
            //if (!Regex.IsMatch(venda.cpf, @"^\d{3}\.\d{3}\.\d{3}\-\d{2}$"))
            //    return TelaPrincipalForm.servicoDeTraducao.ObterTexto("InvalidCpf");

            if (venda.data.Date > DateTime.Today)
                return TelaPrincipalForm.servicoDeTraducao.ObterTexto("FutureDateError");

            if (venda.itens.Count == 0)
                return TelaPrincipalForm.servicoDeTraducao.ObterTexto("EmptyItemsError");

            if (venda.itens.Any(i => i.quantidade <= 0))
                return TelaPrincipalForm.servicoDeTraducao.ObterTexto("InvalidItemQuantity");

            return "";
        }

        public override UserControl ObterListagem()
        {
            if (tabelaVenda == null)
                tabelaVenda = new TabelaVendaControl();

            CarregarVendas();

            return tabelaVenda;
        }
    }
}