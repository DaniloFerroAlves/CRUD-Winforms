using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace projeto_lojinha
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }



        private void bt_entrar_Click(object sender, EventArgs e)
        {
            class_controle controle = new class_controle();

            controle.acessar(txt_usuario.Text, txt_senha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com Sucesso", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form_principal fprincipal = new form_principal();
                    fprincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Incorretos!", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }


        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
