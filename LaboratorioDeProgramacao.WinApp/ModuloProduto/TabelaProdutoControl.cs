using LaboratorioDeProgramacao.Dominio.ModuloProduto;

namespace LaboratorioDeProgramacao.WinApp.ModuloDiciplina
{
    public partial class TabelaProdutoControl : UserControl
    {
        public TabelaProdutoControl()
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
                    DataPropertyName = "Titulo",
                    HeaderText = TelaPrincipalForm.servicoDeTraducao.ObterTexto("Title")
                },
                new DataGridViewTextBoxColumn {
                    DataPropertyName = "Valor",
                    HeaderText = TelaPrincipalForm.servicoDeTraducao.ObterTexto("UnitValue")
                },
                new DataGridViewTextBoxColumn {
                    DataPropertyName = "Quantidade",
                    HeaderText = TelaPrincipalForm.servicoDeTraducao.ObterTexto("StockAmount")
                },
                new DataGridViewTextBoxColumn {
                    DataPropertyName = "Fornecedor",
                    HeaderText = TelaPrincipalForm.servicoDeTraducao.ObterTexto("Supplier")
                }
            };
        }

        public int ObterNumeroProdutoSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Produto> produtos)
        {
            grid.Rows.Clear();

            foreach (var produto in produtos)
            {
                grid.Rows.Add(produto.id, produto.titulo, produto.valorUnitario.ToString("F2"), produto.quantidade, produto.fornecedor?.nome);
            }
        }
    }
}