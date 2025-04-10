using LaboratorioDeProgramacao.Dominio.ModuloProduto;

namespace LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloProduto
{
    public class RepositorioProdutoSql : RepositorioBaseSql<Produto, MapeadorProduto>, IRepositorioProduto
    {
        protected override string sqlInserir => @"INSERT INTO [PRODUTO] 
                                                (
                                                    [TITULO],
                                                    [VALOR_UNITARIO],
                                                    [QUANTIDADE],
                                                    [ID_FORNECEDOR]
                                                ) 
                                                VALUES 
                                                (
                                                    @TITULO,
                                                    @VALOR_UNITARIO,
                                                    @QUANTIDADE,
                                                    @ID_FORNECEDOR
                                                );

                                                SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar => @"UPDATE [PRODUTO]
                                                SET 
                                                    [TITULO] = @TITULO,
                                                    [VALOR_UNITARIO] = @VALOR_UNITARIO,
                                                    [QUANTIDADE] = @QUANTIDADE,
                                                    [ID_FORNECEDOR] = @ID_FORNECEDOR
                                                WHERE 
                                                    [ID] = @ID;";

        protected override string sqlExcluir => @"DELETE FROM [PRODUTO]
                                                  WHERE [ID] = @ID;";

        protected override string sqlSelecionarTodos => @"SELECT 
                                                            P.[ID] AS PRODUTO_ID,
                                                            P.[TITULO] AS PRODUTO_TITULO,
                                                            P.[VALOR_UNITARIO] AS PRODUTO_VALOR_UNITARIO,
                                                            P.[QUANTIDADE] AS PRODUTO_QUANTIDADE,
                                                            F.[ID] AS FORNECEDOR_ID,
                                                            F.[NOME] AS FORNECEDOR_NOME,
                                                            F.[ENDERECO] AS FORNECEDOR_ENDERECO
                                                        FROM 
                                                            [PRODUTO] P
                                                        INNER JOIN 
                                                            [FORNECEDOR] F ON P.ID_FORNECEDOR = F.ID;";

        protected override string sqlSelecionarPorId => @"SELECT 
                                                            P.[ID] AS PRODUTO_ID,
                                                            P.[TITULO] AS PRODUTO_TITULO,
                                                            P.[VALOR_UNITARIO] AS PRODUTO_VALOR_UNITARIO,
                                                            P.[QUANTIDADE] AS PRODUTO_QUANTIDADE,
                                                            F.[ID] AS FORNECEDOR_ID,
                                                            F.[NOME] AS FORNECEDOR_NOME,
                                                            F.[ENDERECO] AS FORNECEDOR_ENDERECO
                                                        FROM 
                                                            [PRODUTO] P
                                                        INNER JOIN 
                                                            [FORNECEDOR] F ON P.ID_FORNECEDOR = F.ID
                                                        WHERE 
                                                            P.[ID] = @ID;";
    }
}
