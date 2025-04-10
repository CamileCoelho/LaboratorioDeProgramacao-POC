using LaboratorioDeProgramacao.Dominio.ModuloDisciplina;

namespace LaboratorioDeProgramacao.WinApp.ModuloDiciplina
{
    public partial class TabelaDisciplinaControl : UserControl
    {
        public TabelaDisciplinaControl()
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

                new DataGridViewTextBoxColumn { 
                    DataPropertyName = "Disciplina", 
                    HeaderText = TelaPrincipalForm.translationService.ObterTexto("Discipline")
                },

                new DataGridViewTextBoxColumn { 
                    DataPropertyName = "Quantidade de Matérias", 
                    HeaderText = TelaPrincipalForm.translationService.ObterTexto("SubjectsCount")
                }

            };

            return colunas;
        }
        public int ObterNumeroDisciplinaSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Disciplina> disciplinas)
        {
            grid.Rows.Clear();

            foreach (var disciplina in disciplinas)
            {
                grid.Rows.Add(disciplina.id, disciplina.nome, disciplina.qtdMaterias);
            }
        }

      
    }
}