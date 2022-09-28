using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace projeto_lojinha
{
    class class_conexao
    {
        //PRECISAMOS USAR UM OBJETO PARA A CONEXÃO COM O BANCO
        //OBJETO MySqlConnection TRATA A CONEXÃO COM O MySQL ou MariaDB
        private MySqlConnection c;

        //MySqlCommand TRATA OS TIPOS DE COMANDO E CADA AÇÃO QUE DEVERÁ SER TOMADA,
        //COMO POR EXEMPLO UM SELECT OU INSERT
        private MySqlCommand cmd;

        //PODEMOS CONECTAR COM O MySqlDataAdapter (RESULTADO DO ExecuteReader) APENAS PARA LEITURA OU PODEMOS USAR UM ADPTER
        //O MySqlDataAdapter SERÁ USADO PARA EXECUTAR COMANDOS USANDO UM DataSet OU DataTable
        //DataSet -> ARMAZENA DADOS EM EM MEMÓRIA, PODEMOS TER UM CONJUNTO DE TABELAS
        //DataTable -> É UMA TABELA APENAS QUE PODEMOS MONTAR NO AMBIENTE DE PROGRAMAÇÃO
        private MySqlDataAdapter mDAdap;

        //VARIÁVEL DECLARADA PARA EXIBIR OS ERROS DE BD DOS MÉTODOS CRIADOS
        private string erro;

        //CONSTRURTOR DA CLASSE
        public class_conexao()
        {
            this.c = new MySqlConnection();
            this.cmd = null;
            this.mDAdap = null;
            erro = null;
        }

        //PROPRIEDADES
        public string ComandoErro
        {
            get { return erro; }
        }

        #region Métodos para Gerenciar a Conexão

        // ABRIR A CONEXÃO COM O BANCO
        // CRIAMOS A STRING CONEXÃO, OU PRECISAMOS PEGAR ESTA STRING DE ALGUM LUGAR CADA SERVIDOR TEM SUA STRING DE CONEXÃO
        public MySqlConnection Conectar()
        {
            //WEB
            //string conex = @"Persist Security Info = False; Server = 000.000.000.000; Database = NomeBanco; uid = Usuario; pwd= Senha ";

            //LOCAL
            string conex = @"Persist Security Info=False; Server = localhost; Database = lojinha; uid=root; pwd= ''";

            //c.State -> STATE É UMA PROPRIEDADE QUE PODEMOS VERIFICAR O ESTADO DA CONEXÃO, COMO NO PROJETO VAMOS SEMPRE FECHAR A CONEXÃO 
            //PODEREMOS MANTER O ESTADO SEMPRE FECHADO DEPENDO DA SITUAÇÃO PODEREMOS REALIZAR E MANTER O ESTADO ABERTO  
            if (this.c.State == ConnectionState.Closed || this.c.State == ConnectionState.Broken)
            {
                //INFORMA QUAL É A CONEXÃO QUE VAMOS USAR
                this.c.ConnectionString = conex;
                //ABRIR A CONEXÃO 
                this.c.Open();
            }
            return c;
        }

        //TODA A CONEXÃO DEVE SER FECHADA E LIBERADA
        //c.Dispose() LIBERA A CONEXÃO
        //c.Close() FECHA A CONEXÃO
        //PODEMOS LIBERAR E FECHAR EM QUALQUER MOMENTO CHAMANDO ESTE MÉTODO
        private void Desconectar()
        {
            if (this.c.State == ConnectionState.Open)
            {
                this.c.Dispose();
                this.c.Close();
            }
        }
        #endregion

        #region Métodos que trata o tipo de acesso

        //MÉTODO UTILIZADO PARA EXECUTAR OS COMANDOS DO BD (INSERT / UPDATE / DELETE)
        //EXECUTA A QUERY E DEPENDE DO RETORNO DO BANCO SQL (0 OU 1)
        //0 -> QUANDO GERA ALGUM ERRO
        //1 -> QUANDO OCORRE TUDO CERTO 
        public int ExecutaQuery(string query)
        {
            try
            {
                //CONECTA AO BANCO
                Conectar();

                //PREPARA A COMUNICAÇÃO E EXECUTA A QUERY
                this.cmd = new MySqlCommand();
                this.cmd.Connection = this.c;
                this.cmd.CommandText = query;
                this.cmd.CommandType = CommandType.Text;

                //ExecuteNonQuery PARA REALIZAR A EXECUÇÃO DE UM COMANDO
                int resp = this.cmd.ExecuteNonQuery();

                Desconectar();
                return resp;
            }
            catch (MySqlException sqlex)
            {
                erro = sqlex.Message;
                Desconectar();
                return 0;
            }
        }

        //DataTable REPRESENTA UMA TABELA DE DADOS NA MEMÓRIA
        //USADO SEMPRE QUE UMA CONSULTA NO BD TEM QUE SER FEITA (SELECT)
        public DataTable RetornaDataTable(string query)
        {
            try
            {
                DataTable dt = new DataTable();

                this.cmd = new MySqlCommand(query, this.c);
                this.cmd.CommandType = CommandType.Text;
                this.mDAdap = new MySqlDataAdapter(this.cmd);

                Conectar();

                this.mDAdap.Fill(dt);
                this.mDAdap.Dispose();


                Desconectar();
                return dt;
            }
            catch (MySqlException sqlex)
            {
                erro = sqlex.Message;
                Desconectar();
                return null;
            }
        }

        //USADO PARA CADASTRAR, QUANDO ESPERAMOS O CÓDIGO DE RETORNO, CHAVE PRIMÁRIA(PK)
        //SERÁ USADO NOS CADASTROS NxN
        public int ExecutaQueryID(string query)
        {
            try
            {
                int resp = 0;
                Conectar();

                this.cmd = new MySqlCommand(query, this.c);
                //ExecuteScalar: RECUPERAR UM VALOR ÚNICO DE UM BANCO DE DADOS (PK)
                resp = Convert.ToInt32(cmd.ExecuteScalar());

                Desconectar();
                return resp;
            }
            catch (MySqlException sqlex)
            {
                erro = sqlex.Message;
                Desconectar();
                return 0;
            }
        }
        #endregion
    }






}
