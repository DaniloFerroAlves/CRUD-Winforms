using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace projeto_lojinha
{
    class class_cargo
    {
        public class_cargo() //MÉTODO CONSTRUTOR
        {
            cod_cargo = 0;
            data_cadastro = DateTime.Now;
            nome = null;
            status = 0;


        }

        //PROPRIEDADES

        public int cod_cargo { get; set; }

        public DateTime data_cadastro { get; set; }

        public string nome { get; set; }

        public int status { get; set; }

        //MÉTODO INSERT
        public int cadastro_cargo()
        {
            string query = "INSERT INTO cargo VALUES(0, now(),'"+ nome +"', 1)";
            class_conexao cconexao = new class_conexao();
            return cconexao.ExecutaQuery(query);



        }
        
        //MÉTODO USADO PRA BUSCAR O CARGO E ALIMENTAR A COMBO BOX
        public DataTable buscar_cargo()
        {
            string query = "SELECT cod_cargo, nome FROM cargo where status = 1 ORDER BY nome";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);

        }

        //CONSULTA POR NOME INICIO DO CARGO
        public DataTable consulta_cargo_nomei(string nomei)
        {
            string query = "SELECT cod_cargo'Código', nome'Nome' FROM cargo WHERE nome LIKE '" + nomei + "%' AND status = 1";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        //CONSULTA POR NOME CONTEM DO CARGO
        public DataTable consulta_cargo_nomec(string nomec)
        {
            string query = "SELECT cod_cargo'Código', nome'Nome' FROM cargo WHERE nome LIKE '%" + nomec + "%' AND status = 1";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        //CONSULTA POR STATUS
        public DataTable consulta_cargo_status(int status)
        {
            string query = "SELECT cod_cargo'Código', nome'Nome' FROM cargo WHERE status = " + status + "";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        //FIM CONSULTA STATUS





        //SELECT ALL 
        public bool consultar_cargo(int cod)
        {
            string query = "SELECT * FROM cargo WHERE cod_cargo = " + cod + "";
            class_conexao cconexao = new class_conexao();
            DataTable dt = cconexao.RetornaDataTable(query);

            if(dt.Rows.Count > 0)
            {
                cod_cargo = Convert.ToInt32(dt.Rows[0]["cod_cargo"]);
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
        //FIM DO SELECT ALL DO CARGO

        //ATUALIZAR CARGO

        public bool atualizar_cargo()
        {
            string query = "UPDATE cargo SET nome ='"+ nome +"', status = "+ status +" WHERE cod_cargo = "+ cod_cargo +" ";

            class_conexao cconexao = new class_conexao();
            int resp = cconexao.ExecutaQuery(query);

            if(resp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //FIM DO ATUALIZAR

        //MÉTODO EXCLUIR
        public bool excluir_cargo()
        {
            string query = "DELETE FROM cargo WHERE cod_cargo = " + cod_cargo + "";
            class_conexao cconexao = new class_conexao();
            int resp = cconexao.ExecutaQuery(query);

            if(resp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //FIM DO EXCLUIR



        //COMEÇO MÉTODO RELATÓRIO
        public DataTable relatorio_cargo()
        {
            string query = "SELECT nome, data_cadastro, status FROM cargo WHERE status = 1 ORDER BY nome";
            class_conexao cconexao = new class_conexao();

            return cconexao.RetornaDataTable(query);
        }


    }
}
