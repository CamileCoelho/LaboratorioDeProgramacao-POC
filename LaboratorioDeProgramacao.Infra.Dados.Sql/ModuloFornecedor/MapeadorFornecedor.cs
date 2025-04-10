using LaboratorioDeProgramacao.Dominio.ModuloFornecedor;
using System.Data.SqlClient;

namespace LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloFornecedor
{
    public class MapeadorFornecedor : MapeadorBase<Fornecedor>
    {
        public override void ConfigurarParametros(SqlCommand comando, Fornecedor registro)
        {
            comando.Parameters.AddWithValue("@ID", registro.id);
            comando.Parameters.AddWithValue("@NOME", registro.nome);
            comando.Parameters.AddWithValue("@ENDERECO", registro.endereco);
        }

        public override Fornecedor ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["FORNECEDOR_ID"]);
            string nome = Convert.ToString(leitorRegistros["FORNECEDOR_NOME"]);
            string endereco = Convert.ToString(leitorRegistros["FORNECEDOR_ENDERECO"]);

            return new Fornecedor(id, nome, endereco);
        }
    }
}