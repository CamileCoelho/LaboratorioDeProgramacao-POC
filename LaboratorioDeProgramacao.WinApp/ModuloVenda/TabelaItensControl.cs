using LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloItemVenda;

namespace LaboratorioDeProgramacao.WinApp.ModuloVenda
{
    public partial class TabelaItensControl : UserControl
    {
        public TabelaItensControl()
        {
            InitializeComponent();
            gridAlternativas.ConfigurarGridZebrado();
            gridAlternativas.ConfigurarGridSomenteLeitura();
            gridAlternativas.Columns.AddRange(ObterColunas());

            TelaPrincipalForm.Tela.AtualizarRodape("");
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Produto", HeaderText = "Produto"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Quantidade", HeaderText = "Quantidade"}
            };

            return colunas;
        }

        public int ObterNumeroItemSelecionado()
        {
            return gridAlternativas.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<ItemVenda> itens)
        {
            gridAlternativas.Rows.Clear();

            foreach (var item in itens)
            {
                gridAlternativas.Rows.Add(item.id, item.produto, item.quantidade);
            }
        }
    }
}
