using LaboratorioDeProgramacao.Dominio.ModuloFornecedor;

namespace LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloFornecedor
{
    public class RepositorioFornecedorSql : RepositorioBaseSql<Fornecedor, MapeadorFornecedor>, IRepositorioItemVenda
    {
        protected override string sqlInserir => @"INSERT INTO [FORNECEDOR]
                                                 ([NOME], [ENDERECO])
                                                 VALUES
                                                 (@NOME, @ENDERECO);
                                                 SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar => @"UPDATE [FORNECEDOR]
                                                SET 
                                                    [NOME] = @NOME,
                                                    [ENDERECO] = @ENDERECO
                                                WHERE 
                                                    [ID] = @ID;";

        protected override string sqlExcluir => @"DELETE FROM [FORNECEDOR]
                                                  WHERE [ID] = @ID;";

        protected override string sqlSelecionarTodos => @"SELECT 
                                                            [ID] AS FORNECEDOR_ID,
                                                            [NOME] AS FORNECEDOR_NOME,
                                                            [ENDERECO] AS FORNECEDOR_ENDERECO
                                                          FROM [FORNECEDOR];";

        protected override string sqlSelecionarPorId => @"SELECT 
                                                            [ID] AS FORNECEDOR_ID,
                                                            [NOME] AS FORNECEDOR_NOME,
                                                            [ENDERECO] AS FORNECEDOR_ENDERECO
                                                          FROM [FORNECEDOR]
                                                          WHERE [ID] = @ID;";
    }
}