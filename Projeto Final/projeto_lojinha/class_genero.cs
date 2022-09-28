using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace projeto_lojinha
{
    class class_genero
    {
        public class_genero()
        {
            //MÉTODO CONSTRUTOR
            cod_genero = 0;
            data_cadastro = DateTime.Now;
            nome = null;
            status = 0;
        }
        //PROPRIEDADES
        public int cod_genero { get; set; }
        public DateTime data_cadastro { get; set; }
        public string nome { get; set; }
        public int status { get; set; }

        //MÉTODO
        public int cadastro_genero()
        {
            string query = "INSERT INTO genero VALUES(0,now(),'" + nome + "' , 1)";
            class_conexao cconexao = new class_conexao();
            return cconexao.ExecutaQuery(query);
        }

        public DataTable buscar_genero()
        {
            string query = "SELECT cod_genero, nome FROM genero WHERE status = 1 AND Nome <> '' ORDER BY nome;";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public bool update_genero()
        {
            string query = "UPDATE genero SET nome = '" + nome + "', status = " + status + " WHERE cod_genero = " + cod_genero + "";
            class_conexao cconexao = new class_conexao();
            int resp = cconexao.ExecutaQuery(query);
            if (resp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool delete_genero()
        {
            string query = "DELETE FROM genero WHERE cod_genero = " + cod_genero + "";
            class_conexao cconexao = new class_conexao();
            int resp = cconexao.ExecutaQuery(query);

            if (resp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool consulta_genero(int cod)
        {
            string query = "SELECT * FROM genero WHERE cod_genero = '" + cod + "' ORDER BY nome;";
            class_conexao cconexao = new class_conexao();
            DataTable dt = cconexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                cod_genero = Convert.ToInt32(dt.Rows[0]["cod_genero"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                nome = dt.Rows[0]["nome"].ToString();
                status = Convert.ToInt32(dt.Rows[0]["status"]);

                return true;
            }
            else
            {
                return false;
            }

        }

        public DataTable consulta_genero_nomei(string nome)
        {
            string query = "SELECT cod_genero,nome FROM genero WHERE status = 1 and nome <> '' AND nome LIKE '" + nome + "%'ORDER BY nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable consulta_genero_nomec(string nome)
        {
            string query = "SELECT cod_genero,nome FROM genero WHERE status = 1 and nome <> '' AND nome LIKE '%" + nome + "%'ORDER BY nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable consulta_genero_status(int status)
        {
            string query = "SELECT cod_genero,nome FROM genero WHERE nome <> '' AND status = " + status + " ORDER BY nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }


        // começo método relatório


        public DataTable realatorio_genero()
        {
            string query = "SELECT genero.nome, genero.data_cadastro, genero.status FROM genero WHERE genero.status = 1 AND genero.nome <> '' ORDER BY genero.nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);

        }
        // fim método relatório




    }
}
