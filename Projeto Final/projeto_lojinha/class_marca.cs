using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace projeto_lojinha
{
    class class_marca
    {
        public class_marca()
        {
            //MÉTODO CONSTRUTOR

            cod_marca = 0;
            data_cadastro = DateTime.Now;
            nome = null;
            status = 0;

        }

        //PROPRIEDADES 
        public int cod_marca {get; set;}
        public DateTime data_cadastro { get; set; }
        public string nome { get; set; }
        public int status { get; set; }

        // começo método cadastro
        public int cadastro_marca()
        {
            string query = "INSERT INTO marca VALUES(0,NOW(), '"+ nome +"', 1)";

            class_conexao cconexao = new class_conexao();
            return cconexao.ExecutaQuery(query);
        }
        // fim método cadastro

        //começo método consulta
        public DataTable buscar_marca()
        {
            string query = "SELECT cod_marca, nome FROM marca WHERE status = 1 and Nome <> '' ORDER BY nome;";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        

        public bool consulta_marca(int cod)
        {
            string query = "SELECT * FROM marca WHERE cod_marca = '" + cod + "' ORDER BY nome;";
            class_conexao cconexao = new class_conexao();
            DataTable dt = cconexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                cod_marca = Convert.ToInt32(dt.Rows[0]["cod_marca"]);
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

        public bool update_marca()
        {
            string query = "UPDATE marca SET nome = '" + nome + "', status = " + status + " WHERE cod_marca = " + cod_marca + "";
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

        public bool delete_marca()
        {
            string query = "DELETE FROM marca WHERE cod_marca = " + cod_marca + "";
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
        public DataTable consulta_marca_nomei(string nome)
        {
            string query = "SELECT cod_marca,nome FROM marca WHERE status = 1 and Nome <> '' AND nome LIKE '" + nome + "%'ORDER BY nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable consulta_marca_nomec(string nome)
        {
            string query = "SELECT cod_marca,nome FROM marca WHERE status = 1 and Nome <> '' AND nome LIKE '%" + nome + "%'ORDER BY nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable consulta_marca_status(int status)
        {
            string query = "SELECT cod_marca,nome FROM marca WHERE Nome <> '' AND status = " + status + " ORDER BY nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        // fim método consulta


        // começo método relatório


        public DataTable realatorio_marca()
        {
            string query = "SELECT marca.nome, marca.data_cadastro, marca.status FROM marca WHERE marca.status = 1 AND marca.nome <> '' ORDER BY marca.nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);

        }
        // fim método relatório







    }
}
