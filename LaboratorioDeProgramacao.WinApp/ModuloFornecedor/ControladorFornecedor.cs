using LaboratorioDeProgramacao.Dominio.ModuloFornecedor;
using LaboratorioDeProgramacao.Dominio.ModuloProduto;
using LaboratorioDeProgramacao.Dominio.ModuloVenda;

namespace LaboratorioDeProgramacao.WinApp.ModuloFornecedor
{
    public class ControladorFornecedor : ControladorBase
    {
        private readonly IRepositorioFornecedor repositorioFornecedor;

        private TabelaFornecedorControl tabelaFornecedor = new();

        public ControladorFornecedor(IRepositorioFornecedor repositorioFornecedor)
        {
            this.repositorioFornecedor = repositorioFornecedor;
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
            TelaFornecedorForm tela = new();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                Fornecedor novoFornecedor = tela.ObterFornecedor();

                if (!ValidarFornecedor(novoFornecedor))
                    return;

                repositorioFornecedor.Inserir(novoFornecedor);

                CarregarFornecedores();
            }
        }

        public override void Editar()
        {
            Fornecedor fornecedorSelecionado = ObterFornecedorSelecionado();

            if (fornecedorSelecionado == null)
            {
                MessageBox.Show(
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("SelectSupplierFirst"),
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("SupplierEditTitle"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            TelaFornecedorForm tela = new();
            tela.ConfigurarTela(fornecedorSelecionado);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                Fornecedor fornecedorAtualizado = tela.ObterFornecedor();

                if (!ValidarFornecedor(fornecedorAtualizado))
                    return;

                repositorioFornecedor.Editar(fornecedorSelecionado, fornecedorAtualizado);

                CarregarFornecedores();
            }
        }

        public override void Excluir()
        {
            Fornecedor fornecedorSelecionado = ObterFornecedorSelecionado();

            if (fornecedorSelecionado == null)
            {
                MessageBox.Show(
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("SelectSupplierFirst"),
                    TelaPrincipalForm.servicoDeTraducao.ObterTexto("SupplierDeleteTitle"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show(
                string.Format(TelaPrincipalForm.servicoDeTraducao.ObterTexto("ConfirmSupplierDeletion"), fornecedorSelecionado.nome),
                TelaPrincipalForm.servicoDeTraducao.ObterTexto("SupplierDeleteTitle"),
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioFornecedor.Excluir(fornecedorSelecionado);

                CarregarFornecedores();
            }
        }

        public override UserControl ObterListagem()
        {
            if (tabelaFornecedor == null)
                tabelaFornecedor = new TabelaFornecedorControl();

            CarregarFornecedores();

            return tabelaFornecedor;
        }

        private void CarregarFornecedores()
        {
            List<Fornecedor> fornecedores = repositorioFornecedor.SelecionarTodos();
            tabelaFornecedor.AtualizarRegistros(fornecedores);
        }

        private Fornecedor ObterFornecedorSelecionado()
        {
            int id = tabelaFornecedor.ObterNumeroFornecedorSelecionado();
            return repositorioFornecedor.SelecionarPorId(id);
        }

        private bool ValidarFornecedor(Fornecedor fornecedor)
        {
            if (string.IsNullOrWhiteSpace(fornecedor.nome) || fornecedor.nome.Length != 3)
            {
                MessageBox.Show("O nome do fornecedor deve conter exatamente 3 letras.",
                    "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}