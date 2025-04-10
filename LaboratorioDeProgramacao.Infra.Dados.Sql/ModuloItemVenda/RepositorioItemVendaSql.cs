using LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloItemVenda;

namespace LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloItemVenda
{
    public class RepositorioItemVendaSql : RepositorioBaseSql<ItemVenda, MapeadorItemVenda>, IRepositorioItemVenda
    {
        protected override string sqlInserir => @"INSERT INTO [VENDA_PRODUTO]
                                                ([ID_VENDA], [ID_PRODUTO], [QUANTIDADE])
                                                VALUES
                                                (@ID_VENDA, @ID_PRODUTO, @QUANTIDADE);
                                                SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar => @"UPDATE [VENDA_PRODUTO]
                                                SET 
                                                    [ID_VENDA] = @ID_VENDA,
                                                    [ID_PRODUTO] = @ID_PRODUTO,
                                                    [QUANTIDADE] = @QUANTIDADE
                                                WHERE [ID] = @ID;";

        protected override string sqlExcluir => @"DELETE FROM [VENDA_PRODUTO]
                                                  WHERE [ID] = @ID;";

        protected override string sqlSelecionarTodos => @"SELECT 
                                                            [ID] AS ITEMVENDA_ID,
                                                            [ID_VENDA] AS ITEMVENDA_ID_VENDA,
                                                            [ID_PRODUTO] AS ITEMVENDA_ID_PRODUTO,
                                                            [QUANTIDADE] AS ITEMVENDA_QUANTIDADE
                                                         FROM [VENDA_PRODUTO];";

        protected override string sqlSelecionarPorId => @"SELECT 
                                                            [ID] AS ITEMVENDA_ID,
                                                            [ID_VENDA] AS ITEMVENDA_ID_VENDA,
                                                            [ID_PRODUTO] AS ITEMVENDA_ID_PRODUTO,
                                                            [QUANTIDADE] AS ITEMVENDA_QUANTIDADE
                                                         FROM [VENDA_PRODUTO]
                                                         WHERE [ID] = @ID;";
    }
}