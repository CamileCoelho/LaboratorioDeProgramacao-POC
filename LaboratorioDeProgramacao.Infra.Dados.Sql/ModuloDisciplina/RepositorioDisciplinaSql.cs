﻿using Microsoft.Win32;
using System.Data.SqlClient;
using LaboratorioDeProgramacao.Dominio.ModuloDisciplina;
using LaboratorioDeProgramacao.Dominio.ModuloMateria;
using LaboratorioDeProgramacao.Dominio.ModuloTeste;
using LaboratorioDeProgramacao.Infra.Dados.Sql.Compartilhado;

namespace LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloDisciplina
{
    public class RepositorioDisciplinaSql : RepositorioBaseSql<Disciplina, MapeadorDisciplina>, IRepositorioDisciplina
    {
        private const string enderecoBanco = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = TesteBanco2; Integrated Security = True; Pooling=False";

        protected override string sqlInserir => @"INSERT INTO [TBDISCIPLINA] 
	                                            (
		                                            [NOME]
	                                            )
	                                            VALUES 
	                                            (
		                                            @NOME
	                                            );                 

                                            SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar => @"UPDATE [TBDISCIPLINA] 
                                                SET
                                                    [NOME] = @NOME
                                                WHERE
                                                    [ID] = @ID";

        protected override string sqlExcluir => @"DELETE FROM [TBDISCIPLINA]
	                                                WHERE 
		                                                [ID] = @ID";

        protected override string sqlSelecionarTodos => @"SELECT 
	                                                    [ID]        DISCIPLINA_ID 
	                                                   ,[NOME]      DISCIPLINA_NOME
                                                    FROM 
	                                                    [TBDISCIPLINA]";

        protected override string sqlSelecionarPorId => @"SELECT 
	                                                    [ID]        DISCIPLINA_ID 
	                                                   ,[NOME]      DISCIPLINA_NOME
                                                    FROM 
	                                                    [TBDISCIPLINA] 
                                                    WHERE 
                                                        [ID] = @ID";

        public void Editar(Disciplina registroSelecionado, Disciplina registroAtualizado)
        {
            //FALTA COISA AQUI

            ////obter a conexão com o banco e abrir ela
            //SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            //conexaoComBanco.Open();

            ////cria um comando e relaciona com a conexão aberta
            //SqlCommand comandoEditar = conexaoComBanco.CreateCommand();
            //comandoEditar.CommandText = sqlEditar;

            ////adiciona os parâmetros no comando
            //ConfigurarParametros(comandoEditar, registro);

            ////executa o comando
            //comandoEditar.ExecuteNonQuery();

            ////encerra a conexão
            //conexaoComBanco.Close();
        }

        public Disciplina SelecionarPorId(int id)
        {
            Disciplina disciplina = base.SelecionarPorId(id);

            return disciplina;
        }

        public List<Disciplina> SelecionarTodos()
        {
            List<Disciplina> disciplinas = base.SelecionarTodos();

            return disciplinas;
        }
    }
}