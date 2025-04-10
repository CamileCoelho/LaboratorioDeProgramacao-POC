using LaboratorioDeProgramacao.Dominio.ModuloFornecedor;
using LaboratorioDeProgramacao.Dominio.ModuloProduto;
using LaboratorioDeProgramacao.Dominio.ModuloVenda;

namespace LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloDisciplina
{
    public class RepositorioDisciplinaJson : RepositorioBaseArquivo<Produto>, IRepositorioProduto
    {
        public RepositorioDisciplinaJson(ContextoDeDados contexto) : base(contexto)
        {
            
        }

        protected override List<Produto> ObterRegistros()
        {
            return contextoDeDados.disciplinas;
        }
    }
}