using System.Data.SqlClient;
using LaboratorioDeProgramacao.Dominio.ModuloDisciplina;
using LaboratorioDeProgramacao.Dominio.ModuloMateria;

namespace LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloMateria
{
    public class MapeadorMateria : MapeadorBase<Materia>
    {
        public override void ConfigurarParametros(SqlCommand comando, Materia registro)
        {
            comando.Parameters.AddWithValue("@ID", registro.id);
            comando.Parameters.AddWithValue("@NOME", registro.titulo);
            comando.Parameters.AddWithValue("@DISCIPLINA_ID", registro.disciplina.id);
            comando.Parameters.AddWithValue("@SERIE", registro.serie);
        }

        public override Materia ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["MATERIA_ID"]);
            string nome = Convert.ToString(leitorRegistros["MATERIA_NOME"]);
            int disciplinaId = Convert.ToInt32(leitorRegistros["DISCIPLINA_ID"]);
            string serie = Convert.ToString(leitorRegistros["MATERIA_SERIE"]);

            Disciplina disciplina = new Disciplina(disciplinaId, Convert.ToString(leitorRegistros["DISCIPLINA_NOME"]));

            return new Materia(id, nome, disciplina, serie);
        }
    }
}