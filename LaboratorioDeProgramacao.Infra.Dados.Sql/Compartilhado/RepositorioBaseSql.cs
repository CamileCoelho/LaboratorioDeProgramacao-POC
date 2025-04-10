using System.Data.SqlClient;
using LaboratorioDeProgramacao.Dominio.Compartilhado;

namespace LaboratorioDeProgramacao.Infra.Dados.Sql.Compartilhado
{
    public abstract class RepositorioBaseSql<T, TMapeador> : IRepositorio<T>
        where T : EntidadeBase<T>
        where TMapeador : MapeadorBase<T>, new()
    {
        private const string enderecoBanco = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LanchoneteDB;Integrated Security=True;Pooling=False";

        protected abstract string sqlInserir { get; }
        protected abstract string sqlEditar { get; }
        protected abstract string sqlExcluir { get; }
        protected abstract string sqlSelecionarTodos { get; }
        protected abstract string sqlSelecionarPorId { get; }

        protected TMapeador mapeador = new();

        public void Inserir(T novoRegistro)
        {
            using (SqlConnection conexao = new(enderecoBanco))
            {
                SqlCommand comando = new(sqlInserir, conexao);

                mapeador.ConfigurarParametros(comando, novoRegistro);

                conexao.Open();
                object id = comando.ExecuteScalar();
                novoRegistro.id = Convert.ToInt32(id);
            }
        }

        public void Editar(T registroSelecionado, T registroAtualizado)
        {
            registroSelecionado.AtualizarInformacoes(registroAtualizado);
            Editar(registroSelecionado.id, registroSelecionado);
        }

        public void Editar(int id, T registro)
        {
            using (SqlConnection conexao = new(enderecoBanco))
            {
                SqlCommand comando = new(sqlEditar, conexao);

                registro.id = id;

                mapeador.ConfigurarParametros(comando, registro);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir(T registro)
        {
            using (SqlConnection conexao = new(enderecoBanco))
            {
                SqlCommand comando = new(sqlExcluir, conexao);

                comando.Parameters.AddWithValue("@ID", registro.id);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public List<T> SelecionarTodos()
        {
            using (SqlConnection conexao = new(enderecoBanco))
            {
                SqlCommand comando = new(sqlSelecionarTodos, conexao);

                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();

                List<T> registros = new();

                while (leitor.Read())
                {
                    T registro = mapeador.ConverterRegistro(leitor);
                    registros.Add(registro);
                }

                return registros;
            }
        }

        public T SelecionarPorId(int id)
        {
            using (SqlConnection conexao = new(enderecoBanco))
            {
                SqlCommand comando = new(sqlSelecionarPorId, conexao);

                comando.Parameters.AddWithValue("@ID", id);

                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();

                if (leitor.Read())
                    return mapeador.ConverterRegistro(leitor);

                return null;
            }
        }
    }
}