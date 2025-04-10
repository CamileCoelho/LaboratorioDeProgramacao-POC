using LaboratorioDeProgramacao.Dominio.ModuloFornecedor;

namespace LaboratorioDeProgramacao.WinApp.ModuloFornecedor
{
    public partial class TabelaFornecedorControl : UserControl
    {
        public TabelaFornecedorControl()
        {
            InitializeComponent();

            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());

            TelaPrincipalForm.Tela.AtualizarRodape("");
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn {
                    DataPropertyName = "Id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn {
                    DataPropertyName = "Nome",
                    HeaderText = TelaPrincipalForm.servicoDeTraducao.ObterTexto("Name")
                },
                new DataGridViewTextBoxColumn {
                    DataPropertyName = "Endereco",
                    HeaderText = TelaPrincipalForm.servicoDeTraducao.ObterTexto("Adress")
                }
            };
        }

        public int ObterNumeroFornecedorSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Fornecedor> fornecedores)
        {
            grid.Rows.Clear();

            foreach (var produto in fornecedores)
            {
                grid.Rows.Add(produto.id, produto.nome, produto.endereco);
            }
        }
    }
}