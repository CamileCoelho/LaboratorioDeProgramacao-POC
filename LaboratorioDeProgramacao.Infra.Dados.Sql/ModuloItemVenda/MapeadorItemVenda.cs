using LaboratorioDeProgramacao.Dominio.ModuloProduto;
using System.Data.SqlClient;

namespace LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloItemVenda
{
    public class MapeadorItemVenda : MapeadorBase<ItemVenda>
    {
        public override void ConfigurarParametros(SqlCommand comando, ItemVenda registro)
        {
            comando.Parameters.AddWithValue("@ID", registro.id);
            comando.Parameters.AddWithValue("@ID_VENDA", registro.id_venda);
            comando.Parameters.AddWithValue("@ID_PRODUTO", registro.produto.id);
            comando.Parameters.AddWithValue("@QUANTIDADE", registro.quantidade);
        }

        public override ItemVenda ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["ITEMVENDA_ID"]);
            int id_venda = Convert.ToInt32(leitorRegistros["ITEMVENDA_ID_VENDA"]);
            int id_produto = Convert.ToInt32(leitorRegistros["ITEMVENDA_ID_PRODUTO"]);
            int quantidade = Convert.ToInt32(leitorRegistros["ITEMVENDA_QUANTIDADE"]);

            // Atenção: aqui estamos criando um produto apenas com o ID. 
            // Se quiser o produto completo, terá que buscar por ID depois.
            Produto produto = new Produto { id = id_produto };

            return new ItemVenda(id, produto, quantidade)
            {
                id_venda = id_venda
            };
        }
    }
}