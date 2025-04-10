using LaboratorioDeProgramacao.Dominio.ModuloVenda;

namespace LaboratorioDeProgramacao.WinApp.ModuloVenda
{
    public partial class TabelaVendaControl : UserControl
    {
        public TabelaVendaControl()
        {
            InitializeComponent(); 
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());

            TelaPrincipalForm.Tela.AtualizarRodape("");
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Cpf", HeaderText = "Cpf"},

                new DataGridViewTextBoxColumn { DataPropertyName = "FormaDePagamento", HeaderText = "Forma de pagamento"}
            };

            return colunas;
        }

        public int ObterNumeroClienteSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Venda> vendas)
        {
            grid.Rows.Clear();

            foreach (var venda in vendas)
            {
                grid.Rows.Add(venda.id, venda.cpf, venda.formaPagamento);
            }
        }
    }
}
