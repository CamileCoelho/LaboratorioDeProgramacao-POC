using LaboratorioDeProgramacao.Dominio.ModuloFornecedor;
using LaboratorioDeProgramacao.Dominio.ModuloProduto;
using System.Data.SqlClient;

namespace LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloProduto
{
    public class MapeadorProduto : MapeadorBase<Produto>
    {
        public override void ConfigurarParametros(SqlCommand comando, Produto registro)
        {
            comando.Parameters.AddWithValue("@ID", registro.id);
            comando.Parameters.AddWithValue("@TITULO", registro.titulo);
            comando.Parameters.AddWithValue("@VALOR_UNITARIO", registro.valorUnitario);
            comando.Parameters.AddWithValue("@QUANTIDADE", registro.quantidade);
            comando.Parameters.AddWithValue("@ID_FORNECEDOR", registro.fornecedor.id);
        }

        public override Produto ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["PRODUTO_ID"]);
            string titulo = Convert.ToString(leitorRegistros["PRODUTO_TITULO"]);
            decimal valorUnitario = Convert.ToDecimal(leitorRegistros["PRODUTO_VALOR_UNITARIO"]);
            int quantidade = Convert.ToInt32(leitorRegistros["PRODUTO_QUANTIDADE"]);

            int idFornecedor = Convert.ToInt32(leitorRegistros["FORNECEDOR_ID"]);
            string nomeFornecedor = Convert.ToString(leitorRegistros["FORNECEDOR_NOME"]);
            string enderecoFornecedor = Convert.ToString(leitorRegistros["FORNECEDOR_ENDERECO"]);

            var fornecedor = new Fornecedor(idFornecedor, nomeFornecedor, enderecoFornecedor);

            return new Produto(id, titulo, valorUnitario, quantidade, fornecedor);
        }
    }
}
