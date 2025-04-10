using LaboratorioDeProgramacao.Dominio.ModuloQuestao;

namespace LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloQuestao
{
    public class RepositorioQuestaoJson : RepositorioBaseArquivo<Questao>, IRepositorioQuestao
    {
        public RepositorioQuestaoJson(ContextoDeDados contexto) : base(contexto)
        {
            
        }

        protected override List<Questao> ObterRegistros()
        {
            return contextoDeDados.questoes;
        }
    }
}
