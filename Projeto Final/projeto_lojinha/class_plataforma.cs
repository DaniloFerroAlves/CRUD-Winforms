using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace projeto_lojinha
{
    class class_plataforma
    {
        public class_plataforma()
        {
            //MÉTODO CONSTRUTOR

            cod_plataforma = 0;
            data_cadastro = DateTime.Now;
            nome = null;
            status = 0;

        }
        //PROPRIEDADES

        public int cod_plataforma { get; set; }
        public DateTime data_cadastro { get; set; }
        public string nome { get; set; }
        public int status { get; set; }

        public int cadastro_plataforma()
        {
            string query = "INSERT INTO plataforma VALUES(0,now(),'" + nome + "' , 1)";

            class_conexao cconexao = new class_conexao();
            return cconexao.ExecutaQuery(query);

        }
        public DataTable buscar_plataforma()
        {
            string query = "SELECT cod_plataforma, nome FROM plataforma WHERE status = 1 AND Nome <> '' ORDER BY nome;";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);           
        }

        public bool update_plataforma()
        {
            string query = "UPDATE plataforma SET nome = '" + nome + "', status = " + status + " WHERE cod_plataforma = " + cod_plataforma + "";
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
        public bool delete_plataforma()
        {
            string query = "DELETE FROM plataforma WHERE cod_plataforma = " + cod_plataforma + "";
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

        public bool consulta_plataforma(int cod)
        {
            string query = "SELECT * FROM plataforma WHERE cod_plataforma = '" + cod + "' ORDER BY nome;";
            class_conexao cconexao = new class_conexao();
            DataTable dt = cconexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                cod_plataforma = Convert.ToInt32(dt.Rows[0]["cod_plataforma"]);
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

        public DataTable consulta_plataforma_nomei(string nome)
        {
            string query = "SELECT cod_plataforma,nome FROM plataforma WHERE status = 1 and Nome <> '' AND nome LIKE '" + nome + "%'ORDER BY nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable consulta_plataforma_nomec(string nome)
        {
            string query = "SELECT cod_plataforma,nome FROM plataforma WHERE status = 1 and Nome <> '' AND nome LIKE '%" + nome + "%'ORDER BY nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable consulta_plataforma_status(int status)
        {
            string query = "SELECT cod_plataforma,nome FROM plataforma WHERE Nome <> '' AND status = " + status + " ORDER BY nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }


        // começo método relatório


        public DataTable realatorio_plataforma()
        {
            string query = "SELECT plataforma.nome, plataforma.data_cadastro, plataforma.status FROM plataforma WHERE plataforma.status = 1 AND plataforma.nome <> '' ORDER BY plataforma.nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);

        }
        // fim método relatório
    }
}
