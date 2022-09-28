using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace projeto_lojinha
{
    internal class class_funcionario
    {

        //MÉTODO CONSTRUTOR, ZERAR
        public class_funcionario()
        {
            cod_funcionario = 0;
            nome = null;
            nome_social = null;
            cpf = null;
            data_nascimento = DateTime.Now;
            celular = null;
            telefone = null;
            data_cadastro = DateTime.Now;
            status = 0;
            email = null;
            login = null;
            senha = null;
            tipo_acesso = null;
            cep = null;
            cidade = null;
            rua = null;
            numero = 0;
            complemento = null;
            estado = null;
            bairro = null;
            cod_cargo = 0;
        
        }

        //ATRIBUI AS PROPRIEDADES
        public int cod_funcionario { get; set; }
        public string nome { get; set; }

        public string nome_social { get; set; }

        public string cpf { get; set; }

        public DateTime data_nascimento { get; set; }

        public string celular { get; set; }

        public string telefone { get; set; }

        public DateTime data_cadastro { get; set; }

        public int status { get; set; }

        public string email { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string tipo_acesso { get; set; }

        public string cep { get; set; }

        public string cidade { get; set; }

        public string rua { get; set; }

        public int numero { get; set; }

        public string complemento { get; set; }

        public string estado { get; set; }

        public string bairro { get; set; }

        public int cod_cargo { get; set; }

        //INSERT FUN
        public int cadastrar_funcionario()
        {
            string query = "INSERT INTO funcionario VALUES(0, '" + nome + "', '" + nome_social + "', '" + cpf + "', '" + data_nascimento.ToString("yyyy/MM/dd") + "', '" + celular + "', '" + telefone + "', now(), 1, '" + email + "','"+login+"','"+senha+"','"+tipo_acesso+"', '" + cep + "', '" + cidade + "', '" + rua + "', "+ numero +", '" + complemento + "', '" + estado + "', '" + bairro + "', '" + cod_cargo + "')";

            class_conexao cconexao = new class_conexao();
            return cconexao.ExecutaQuery(query);
        }

        //NOME ÍNICIO
        public DataTable consultar_funcionario_nomei(string nomei)
        {
            string query = "SELECT funcionario.cod_funcionario'Código', cargo.nome'Cargo', funcionario.nome'Nome', funcionario.nome_social'Nome Social', funcionario.cpf'CPF', funcionario.data_nascimento'Nascimento', funcionario.celular'Celular', funcionario.telefone'Telefone' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.nome LIKE '" + nomei+ "%' AND funcionario.status = 1 ";
            class_conexao cconexao = new class_conexao();

            return cconexao.RetornaDataTable(query);
        }
        //CONSULTAR POR NOME CONTEM
        public DataTable consultar_funcionario_nomec(string nomec)
        {
            string query = "SELECT funcionario.cod_funcionario'Código', cargo.nome'Cargo', funcionario.nome'Nome', funcionario.nome_social'Nome Social', funcionario.cpf'CPF', funcionario.data_nascimento'Nascimento', funcionario.celular'Celular', funcionario.telefone'Telefone' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.nome LIKE '%" + nomec+ "%' AND funcionario.status = 1 ";
            class_conexao cconexao = new class_conexao();

            return cconexao.RetornaDataTable(query);
        }

        //CONSULTAR POR CARGO
        public DataTable consultar_funcionario_cargo(int cargo)
        {
            string query = "SELECT funcionario.cod_funcionario'Código', cargo.nome'Cargo', funcionario.nome'Nome', funcionario.nome_social'Nome Social', funcionario.cpf'CPF', funcionario.data_nascimento'Nascimento', funcionario.celular'Celular', funcionario.telefone'Telefone' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.cod_cargo = '" + cargo + "' AND funcionario.status = 1 ";
            class_conexao cconexao = new class_conexao();

            return cconexao.RetornaDataTable(query);
        }

        //CONSULTA POR STATUS
        public DataTable consultar_funcionario_status(int status)
        {
            string query = "SELECT funcionario.cod_funcionario'Código', cargo.nome'Cargo', funcionario.nome'Nome', funcionario.nome_social'Nome Social', funcionario.cpf'CPF', funcionario.data_nascimento'Nascimento', funcionario.celular'Celular', funcionario.telefone'Telefone' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = " + status + "  ";
            class_conexao cconexao = new class_conexao();

            return cconexao.RetornaDataTable(query);
        }

        //CONSULTAR POR CIDADE ÍNICIO
        public DataTable consultar_funcionario_cidadei(string cidadei)
        {
            string query = "SELECT funcionario.cod_funcionario'Código', cargo.nome'Cargo', funcionario.nome'Nome', funcionario.nome_social'Nome Social', funcionario.cpf'CPF', funcionario.data_nascimento'Nascimento', funcionario.celular'Celular', funcionario.telefone'Telefone' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.cidade LIKE '" + cidadei + "%' AND funcionario.status = 1 ";
            class_conexao cconexao = new class_conexao();

            return cconexao.RetornaDataTable(query);
        }

        //CONSULTAR POR CIDADE CONTÉM
        public DataTable consultar_funcionario_cidadec(string cidadec)
        {
            string query = "SELECT funcionario.cod_funcionario'Código', cargo.nome'Cargo', funcionario.nome'Nome', funcionario.nome_social'Nome Social', funcionario.cpf'CPF', funcionario.data_nascimento'Nascimento', funcionario.celular'Celular', funcionario.telefone'Telefone' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.cidade LIKE '" + cidadec + "%' AND funcionario.status = 1 ";
            class_conexao cconexao = new class_conexao();

            return cconexao.RetornaDataTable(query);
        }

        //CONSULTAR POR CPF
        public DataTable consultar_funcionario_cpf(string cpf)
        {
            string query = "SELECT funcionario.cod_funcionario'Código', cargo.nome'Cargo', funcionario.nome'Nome', funcionario.nome_social'Nome Social', funcionario.cpf'CPF', funcionario.data_nascimento'Nascimento', funcionario.celular'Celular', funcionario.telefone'Telefone' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.cpf = '" + cpf + "' AND funcionario.status = 1 ";
            class_conexao cconexao = new class_conexao();

            return cconexao.RetornaDataTable(query);
        }

        //METÓDO PARA TRAZER AS INFORMAÇÕES NO BANCO(SELECT ALL)
        public bool consultar_funcionario(int cod)
        {
            string query = "SELECT * FROM funcionario WHERE cod_funcionario = " + cod + " ";
            class_conexao cconexao = new class_conexao();
            DataTable dt = cconexao.RetornaDataTable(query);
           
            if(dt.Rows.Count > 0)
            {
                cod_funcionario = Convert.ToInt32(dt.Rows[0]["cod_funcionario"]);
                nome = dt.Rows[0]["nome"].ToString();
                nome_social = dt.Rows[0]["nome_social"].ToString();
                cpf = dt.Rows[0]["cpf"].ToString();
                data_nascimento = Convert.ToDateTime(dt.Rows[0]["data_nascimento"]);
                celular = dt.Rows[0]["celular"].ToString();
                telefone = dt.Rows[0]["telefone"].ToString();
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);
                email = dt.Rows[0]["email"].ToString();
                login = dt.Rows[0]["login"].ToString();
                senha = dt.Rows[0]["senha"].ToString();
                tipo_acesso = dt.Rows[0]["tipo_acesso"].ToString();
                cep = dt.Rows[0]["cep"].ToString();
                cidade = dt.Rows[0]["cidade"].ToString();
                rua = dt.Rows[0]["rua"].ToString();
                numero = Convert.ToInt32(dt.Rows[0]["numero"]);
                complemento = dt.Rows[0]["complemento"].ToString();
                estado = dt.Rows[0]["estado"].ToString();
                bairro = dt.Rows[0]["bairro"].ToString();
                cod_cargo = Convert.ToInt32(dt.Rows[0]["cod_cargo"]);

                return true;
            }
            else
            {
                return false;
            }

        }

        //MÉTODO ATUALIZAR

        public bool atualizar_funcionario()
        {
            string query = "UPDATE funcionario SET nome = '" + nome + "', nome_social = '" + nome_social + "', cpf = '" + cpf + "', data_nascimento = '" + data_nascimento.ToString("yyyy/MM/dd") + "', celular = '" + celular + "', telefone = '" + telefone + "', status = "+ status +", email = '" + email + "',login = '"+ login +"',senha = '" + senha + "',tipo_acesso = '"+ tipo_acesso +"', cep ='" + cep + "', cidade ='" + cidade + "', rua ='" + rua + "', numero = " + numero + ", complemento = '" + complemento + "', estado = '" + estado + "', bairro = '" + bairro + "', cod_cargo = " + cod_cargo + " WHERE cod_funcionario = " + cod_funcionario + " ";
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

        public bool excluir_funcionario()
        {
            string query = "DELETE FROM funcionario WHERE cod_funcionario = " + cod_funcionario + "";
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

        //CARREGAR COMBO CARGOS EM RELATÓRIO

        public DataTable buscar_cidade()
        {
            string query = "SELECT DISTINCT cidade from funcionario WHERE status = 1 ORDER BY cidade";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        //CARREGAR COMBO BAIRRO

        public DataTable buscar_bairro()
        {
            string query = "SELECT DISTINCT bairro from funcionario WHERE status = 1 ORDER BY bairro";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        //GERAR RELATÓRIO POR IDADE FUNCIONARIO MAIOR QUE

        public DataTable relatorio_funcionario_idade_maior(int idade)
        {
            string query = "SELECT funcionario.status, funcionario.data_nascimento, funcionario.nome, funcionario.cidade, cargo.nome'cod_cargo' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = 1 AND timestampdiff(year, data_nascimento, now()) > " + idade + " ORDER BY funcionario.nome";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
       
        //ANIVERSARIANTES INTERVALO ENTRE UM E OUTRO
        public DataTable relatorio_funcionario_idade_intervalo(int idadei, int idadef)
        {
            string query = "SELECT funcionario.status, funcionario.data_nascimento, funcionario.nome, funcionario.cidade, cargo.nome'cod_cargo' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = 1 AND timestampdiff(year, data_nascimento, now()) BETWEEN " + idadei + " AND "+ idadef + " ORDER BY funcionario.nome";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        //RELATÓRIO STATUS

        public DataTable relatorio_funcionario_status(int status)
        { 
            string query = "SELECT funcionario.status, funcionario.data_nascimento, funcionario.nome, funcionario.cidade, cargo.nome'cod_cargo' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = " + status +" ORDER BY funcionario.nome";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        //RELATÓRIO CIDADE
        public DataTable relatorio_funcionario_cidade(string cidade)
        {
            string query = "SELECT funcionario.status, funcionario.data_nascimento, funcionario.nome, funcionario.cidade, cargo.nome'cod_cargo' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = 1 AND funcionario.cidade = '" + cidade + "'ORDER BY funcionario.nome";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        //RELATÓRIO POR BAIRRO

        public DataTable relatorio_funcionario_bairro(string bairro)
        {
            string query = "SELECT funcionario.status, funcionario.data_nascimento, funcionario.nome, funcionario.cidade, cargo.nome'cod_cargo' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = 1 AND funcionario.bairro = '" + bairro + "'ORDER BY funcionario.nome";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        //RELATÓRIO POR CARGO

        public DataTable relatorio_funcionario_cargo(int cargo)
        {
            string query = "SELECT funcionario.status, funcionario.data_nascimento, funcionario.nome, funcionario.cidade, cargo.nome'cod_cargo' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = 1 AND funcionario.cod_cargo = " + cargo + " ORDER BY funcionario.nome";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        //RELATÓRIO ANIVERSARIANTES DO MÊS
        public DataTable relatorio_funcionario_aniversariantes_mes(int mes)
        {
            string query = "SELECT funcionario.status, funcionario.data_nascimento, funcionario.nome, funcionario.cidade, cargo.nome'cod_cargo'  FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = 1 AND MONTH(funcionario.data_nascimento) = "+ mes +" ORDER BY funcionario.nome";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }


        // Métodos de NxN -- Nico


        public DataTable combo_funcionario()
        {
            string query = "SELECT funcionario.cod_funcionario,funcionario.nome FROM funcionario JOIN cargo ON cargo.cod_cargo = funcionario.cod_cargo WHERE funcionario.status = 1 AND cargo.nome = 'Vendedor'";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);


        }














    }
}
        


        
       

    






    

