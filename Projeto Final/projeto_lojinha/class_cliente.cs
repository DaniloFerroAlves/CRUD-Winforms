using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace projeto_lojinha
{
    class class_cliente
    {

        ////MÉTODO CONSTRUTOR
        public class_cliente()
        {
            cod_cliente = 0;
            nome = null;
            nome_social = null;
            cpf = null;
            data_nascimento = DateTime.Now;
            celular = null;
            telefone = null;
            data_cadastro = DateTime.Now;
            status = 0;
            email = null;
            cep = null;
            cidade = null;
            rua = null;
            numero = 0;
            complemento = null;
            estado = null;
            bairro = null;

        }
        
        //ATRIBUIR AS PROPRIDADES
        public int cod_cliente { get; set;}

        public string nome { get; set; }

        public string nome_social { get; set; }

        public string cpf { get; set; }

        public DateTime data_nascimento { get; set; }

        public string celular { get; set; }

        public string telefone { get; set; }

        public DateTime data_cadastro { get; set; }

        public int status { get; set; }

        public string email { get; set; }

        public string cep { get; set; }

        public string cidade { get; set; }

        public string rua { get; set; }

        public int numero { get; set; }

        public string complemento { get; set; }

        public string estado { get; set; }

        public string bairro { get; set; }

  

        //INSERT CLENTES
        public int cadastro_cliente()
        {
            string query = "INSERT INTO cliente VALUES(0, '" + nome + "', '" + nome_social + "','" + cpf + "','" + data_nascimento.ToString("yyyy/MM/dd") + "', '" + celular + "', '" + telefone + "', now(), 1, '" + email + "', '" + cep + "', '" + cidade + "', '" + rua + "', "+ numero +", '" + complemento + "', '" + estado + "', '" + bairro + "')";

            class_conexao cconexao = new class_conexao();
            return cconexao.ExecutaQuery(query);
        
        
        
        }

        //CONSULTAR NOME ÍNICIO
        public DataTable consultar_cliente_nomei(string nomei)
        {
            string query = "SELECT cod_cliente'Código', nome'Nome', nome_social'Nome Social', cpf'CPF', telefone'Telefone', celular'Celular' FROM cliente WHERE nome LIKE '"+ nomei+ "%'AND status = 1 ";
            class_conexao cconexao = new class_conexao();

            return cconexao.RetornaDataTable(query);
        }
        //NOME CONTEM
        public  DataTable consultar_cliente_nomec(string nomec)
        {
            string query = "SELECT cod_cliente'Código', nome'Nome', nome_social'Nome Social', cpf'CPF', telefone'Telefone', celular'Celular' FROM cliente WHERE nome LIKE '%" + nomec+ "%' AND status = 1 ";
              
            class_conexao cconexao = new class_conexao();

            return cconexao.RetornaDataTable(query);
        }

        //CONSULTA POR STATUS
        public DataTable consultar_cliente_status(int status)
        {
            string query = "SELECT cod_cliente'Código', nome'Nome', nome_social'Nome Social', cpf'CPF', telefone'Telefone', celular'Celular' FROM cliente WHERE status = " + status+" ";

            class_conexao cconexao = new class_conexao();

            return cconexao.RetornaDataTable(query);
        }

        //CONSULTA POR CIDADE CONTEM
        public DataTable consultar_cliente_cidadec(string cidadec)
        {
            string query = "SELECT cod_cliente'Código', nome'Nome', nome_social'Nome Social', cpf'CPF', telefone'Telefone', celular'Celular' FROM cliente WHERE cidade LIKE '%" + cidadec + "%' AND status = 1 ";

            class_conexao cconexao = new class_conexao();

            return cconexao.RetornaDataTable(query);
        }

        //CONSULTA POR CIDADE INICIO
        public DataTable consultar_cliente_cidadei(string cidadei)
        {
            string query = "SELECT cod_cliente'Código', nome'Nome', nome_social'Nome Social', cpf'CPF', telefone'Telefone', celular'Celular' FROM cliente WHERE cidade LIKE '" + cidadei + "%' AND status = 1 ";

            class_conexao cconexao = new class_conexao();

            return cconexao.RetornaDataTable(query);
        }

        //CONSULTA POR CPF
        public DataTable consultar_cliente_cpf(string cpf)
        {
            string query = "SELECT cod_cliente'Código', nome'Nome', nome_social'Nome Social', cpf'CPF', telefone'Telefone', celular'Celular' FROM cliente WHERE cpf = '" + cpf + "' AND status = 1  ";

            class_conexao cconexao = new class_conexao();

            return cconexao.RetornaDataTable(query);
        }




        //MÉTODO PARA CHAMAR AS INFORMAÇÕES TODAS NO BANCO(SELECT ALL)
        public bool consultar_cliente(int cod)
        {
            string query = "SELECT * FROM cliente WHERE cod_cliente = " + cod + "";
            class_conexao cconexao = new class_conexao();
            DataTable dt = cconexao.RetornaDataTable(query);

            if(dt.Rows.Count > 0)
            {
                cod_cliente = Convert.ToInt32(dt.Rows[0]["cod_cliente"]);
                nome = dt.Rows[0]["nome"].ToString();
                nome_social = dt.Rows[0]["nome_social"].ToString();
                cpf = dt.Rows[0]["cpf"].ToString();
                data_nascimento = Convert.ToDateTime(dt.Rows[0]["data_nascimento"]);
                celular = dt.Rows[0]["celular"].ToString();
                telefone = dt.Rows[0]["telefone"].ToString();
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);
                email = dt.Rows[0]["email"].ToString();
                cep = dt.Rows[0]["cep"].ToString();
                cidade = dt.Rows[0]["cidade"].ToString();
                rua = dt.Rows[0]["rua"].ToString();
                numero = Convert.ToInt32(dt.Rows[0]["numero"]);
                complemento = dt.Rows[0]["complemento"].ToString();
                estado = dt.Rows[0]["estado"].ToString();
                bairro = dt.Rows[0]["bairro"].ToString();

                return true;

            }
            else
            {
                return false;
            }
        }

        //MÉTODO ATUALIZAR
        public bool atualizar_cliente()
        {
            string query = "UPDATE cliente SET nome = '" + nome + "', nome_social ='" + nome_social + "', cpf ='" + cpf + "', data_nascimento ='" + data_nascimento.ToString("yyyy/MM/dd") + "', celular = '" + celular + "', telefone ='" + telefone + "', status = " + status + ", email ='" + email + "', cep = '" + cep + "', cidade = '" + cidade + "', rua = '" + rua + "', numero = " + numero + ", complemento ='" + complemento + "', estado ='" + estado + "', bairro ='" + bairro + "' WHERE cod_cliente = "+cod_cliente+" ";
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

        //MÉTODO EXCLUIR
        public bool excluir_cliente()
        {
            string query = "DELETE FROM cliente WHERE cod_cliente = " + cod_cliente + "";
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

        //BUSCAR BAIRRO

        public DataTable buscar_bairro()
        {
            string query = "SELECT DISTINCT bairro FROM cliente WHERE status = 1 ORDER BY bairro";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        //BUSCAR CIDADE

        public DataTable buscar_cidade()
        {
            string query = "SELECT DISTINCT cidade FROM cliente WHERE status = 1 ORDER BY cidade";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        //RELATÓRIO IDADE MAIOR QUE

        public DataTable relatorio_cliente_idade_maior(int idade)
        {
            string query = "SELECT nome, data_nascimento, status, cidade, bairro FROM cliente WHERE status = 1 AND timestampdiff(year, data_nascimento, now()) > "+ idade +" ORDER BY nome";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        //RELATÓRIO ANIVERSARIANTES INTERVALO UM E OUTRO

        public DataTable relatorio_cliente_idade_ìntervalo(int idadei, int idadef)
        {
            string query = "SELECT nome, data_nascimento, status, cidade, bairro FROM cliente WHERE status = 1 AND timestampdiff(year, data_nascimento, now()) BETWEEN " + idadei + " AND " + idadef + " ORDER BY nome";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        //RELATÓRIO STATUS

        public DataTable relatorio_cliente_status(int status)
        {
            string query = "SELECT nome, data_nascimento, status, cidade, bairro FROM cliente WHERE status = " + status + "";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        //RELATÓRIO CIDADE

        public DataTable relatorio_cliente_cidade(string cidade)
        {
            string query = "SELECT nome, data_nascimento, status, cidade, bairro FROM cliente WHERE status = 1 AND cidade = '" + cidade + "' ORDER BY nome";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        //RELATÓRIO BAIRRO

        public DataTable relatorio_cliente_bairro(string bairro)
        {
            string query = "SELECT nome, data_nascimento, status, cidade, bairro FROM cliente WHERE status = 1 AND bairro = '" + bairro + "' ORDER BY nome";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        //ANIVERSARIANTES DO MÊS

        public DataTable relatorio_cliente_aniversariantes_mes(int mes)
        {
            string query = "SELECT nome, data_nascimento, status, cidade, bairro FROM cliente WHERE status = 1 AND month(data_nascimento) = " + mes +" ORDER BY nome";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }






        // métodos NxN -- nico


        public DataTable buscar_cliente_venda(string nome)
        {
            string query = "SELECT cod_cliente'Código', cpf'CPF', nome'Nome' FROM cliente WHERE status = 1 AND nome LIKE '%" + nome + "%'";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }








    }
            










    
}
