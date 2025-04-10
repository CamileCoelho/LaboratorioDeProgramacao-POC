using LaboratorioDeProgramacao.Dominio.ModuloVenda;
using System.Data.SqlClient;

namespace LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloVenda
{
    public class MapeadorVenda : MapeadorBase<Venda>
    {
        public override void ConfigurarParametros(SqlCommand comando, Venda registro)
        {
            comando.Parameters.AddWithValue("@ID", registro.id);
            comando.Parameters.AddWithValue("@DATA", registro.data);
            comando.Parameters.AddWithValue("@CPF", registro.cpf);
            comando.Parameters.AddWithValue("@FORMA_PAGAMENTO", registro.formaPagamento);
            comando.Parameters.AddWithValue("@TOTAL", registro.total);
        }

        public override Venda ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["VENDA_ID"]);
            DateTime data = Convert.ToDateTime(leitorRegistros["VENDA_DATA"]);
            string cpf = Convert.ToString(leitorRegistros["VENDA_CPF"]);
            string formaPagamento = Convert.ToString(leitorRegistros["VENDA_FORMA_PAGAMENTO"]);
            float total = Convert.ToSingle(leitorRegistros["VENDA_TOTAL"]);

            return new Venda(id, data, cpf, formaPagamento, total);
        }
    }
}