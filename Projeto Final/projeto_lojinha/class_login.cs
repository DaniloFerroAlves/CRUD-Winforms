using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projeto_lojinha
{
    class class_login
    {
        public bool tem = false;
        public string mensagem = "";
        MySqlCommand cmd = new MySqlCommand();
        class_conexao c = new class_conexao();
        MySqlDataReader dr;

        public bool verificar_login(string login, string senha)
        {
            // controle sql para verificar se tem no banco de dados
            cmd.CommandText = "SELECT login,senha FROM funcionario WHERE login = @login AND senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = c.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (MySqlException)
            {

                this.mensagem = "Erro com banco de dados";
            }

            return tem;
        }


    }
}
