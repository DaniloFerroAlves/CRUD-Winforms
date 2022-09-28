using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace projeto_lojinha
{
    class class_categoria
    {
        public class_categoria()
        {
            //MÉTODO CONSTRUTOR

            cod_categoria = 0;
            data_cadastro = DateTime.Now;
            nome = null;
            status = 0;


        }
        //PROPRIEDADES
        public int cod_categoria { get; set; }
        public DateTime data_cadastro { get; set; }
        public string nome { get; set; }
        public int status { get; set; }

        public int cadastro_categoria()
        {
            string query = "INSERT INTO categoria VALUES (0, NOW(),'"+ nome +"', 1)";

            class_conexao cconexao = new class_conexao();
            return cconexao.ExecutaQuery(query);
        }
        //CLASSE CATEGORIA 
        //MÉTODO PARA BSUCAR OS DADOS DO BANCO
        //PARA POPULAR AS COMBOS COM AS IFORMAÇÕES DO BANCO

        public DataTable buscar_categoria()
        {
            string query = "SELECT cod_categoria, nome FROM categoria WHERE status = 1 and Nome <> '' ORDER BY cod_categoria";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);


        }
        public bool update_categoria()
        {
            string query = "UPDATE categoria SET nome = '" + nome + "', status = " + status + " WHERE cod_categoria = " + cod_categoria + "";
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
        public bool delete_categoria()
        {
            string query = "DELETE FROM categoria WHERE cod_categoria = " + cod_categoria + "";
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

        public bool consulta_categoria(int cod)
        {
            string query = "SELECT * FROM categoria WHERE cod_categoria = '" + cod + "' ORDER BY nome;";
            class_conexao cconexao = new class_conexao();
            DataTable dt = cconexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                cod_categoria = Convert.ToInt32(dt.Rows[0]["cod_categoria"]);
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

        public DataTable consulta_categoria_nomei(string nome)
        {
            string query = "SELECT cod_categoria,nome FROM categoria WHERE status = 1 and Nome <> '' AND nome LIKE '" + nome + "%'ORDER BY nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable consulta_categoria_nomec(string nome)
        {
            string query = "SELECT cod_categoria,nome FROM categoria WHERE status = 1 and Nome <> '' AND nome LIKE '%" + nome + "%'ORDER BY nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable consulta_categoria_status(int status)
        {
            string query = "SELECT cod_categoria,nome FROM categoria WHERE Nome <> '' AND status = " + status + " ORDER BY nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }


        public DataTable buscar_jogo()
        {
            string query = "SELECT cod_categoria, nome FROM categoria WHERE status = 1 AND Nome = 'Jogo' AND categoria.nome <> '' ORDER BY nome;";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        // começo método relatório


        public DataTable realatorio_categoria()
        {
            string query = "SELECT categoria.nome, categoria.data_cadastro, categoria.status FROM categoria WHERE categoria.status = 1 AND categoria.nome <> '' ORDER BY categoria.nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);

        }


        // fim método relatório





    }
}
