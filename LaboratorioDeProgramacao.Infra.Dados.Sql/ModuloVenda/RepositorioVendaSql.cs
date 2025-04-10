using LaboratorioDeProgramacao.Dominio.ModuloVenda;

namespace LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloVenda
{
    public class RepositorioVendaSql : RepositorioBaseSql<Venda, MapeadorVenda>, IRepositorioVenda
    {
        protected override string sqlInserir => @"INSERT INTO [VENDA]
                                                 ([DATA], [CPF], [FORMA_PAGAMENTO], [TOTAL])
                                                 VALUES
                                                 (@DATA, @CPF, @FORMA_PAGAMENTO, @TOTAL);
                                                 SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar => @"UPDATE [VENDA]
                                                SET 
                                                    [DATA] = @DATA,
                                                    [CPF] = @CPF,
                                                    [FORMA_PAGAMENTO] = @FORMA_PAGAMENTO,
                                                    [TOTAL] = @TOTAL
                                                WHERE 
                                                    [ID] = @ID;";

        protected override string sqlExcluir => @"DELETE FROM [VENDA]
                                                  WHERE [ID] = @ID;";

        protected override string sqlSelecionarTodos => @"SELECT 
                                                            [ID] AS VENDA_ID,
                                                            [DATA] AS VENDA_DATA,
                                                            [CPF] AS VENDA_CPF,
                                                            [FORMA_PAGAMENTO] AS VENDA_FORMA_PAGAMENTO,
                                                            [TOTAL] AS VENDA_TOTAL
                                                          FROM [VENDA];";

        protected override string sqlSelecionarPorId => @"SELECT 
                                                            [ID] AS VENDA_ID,
                                                            [DATA] AS VENDA_DATA,
                                                            [CPF] AS VENDA_CPF,
                                                            [FORMA_PAGAMENTO] AS VENDA_FORMA_PAGAMENTO,
                                                            [TOTAL] AS VENDA_TOTAL
                                                          FROM [VENDA]
                                                          WHERE [ID] = @ID;";
    }
}