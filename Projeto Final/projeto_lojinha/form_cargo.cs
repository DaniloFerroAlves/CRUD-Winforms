using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_lojinha
{
    public partial class form_cargo : Form
    {
        public form_cargo()
        {
            InitializeComponent();
        }

        public string tipo;
        public DateTime datacad;

        //CADASTRAR
        private void bt_cadastrar_cargos_Click(object sender, EventArgs e)
        {
            if(txt_nome_cargo.Text != "")
            {
                class_cargo ccargo = new class_cargo();
                ccargo.nome = txt_nome_cargo.Text;

                int resp = ccargo.cadastro_cargo();

                if(resp == 1)
                {
                    MessageBox.Show("Cargo: " + ccargo.nome + " Cadastrado com Sucesso", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_nome_cargo.Clear();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            
            
            
            
            }
            else
            {
                MessageBox.Show("Preencher os campos obrigatórios *", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }








        }

        //BOTÃO ATUALIZAR CARGO
        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            if (txt_nome_cargo.Text != "")
            {
                class_cargo ccargo = new class_cargo();
                ccargo.nome = txt_nome_cargo.Text;
                //ATUALIZAR SOMENTE UM CARGO PELO CÓDIGO QUE É UNICO
                ccargo.cod_cargo = Convert.ToInt32(txt_codigo_cargo.Text); 
                
                if(cb_status.Checked == true)
                {
                    ccargo.status = 1; 
                }
                else
                {
                    ccargo.status = 0;
                }
                
                bool resp = ccargo.atualizar_cargo();



                if (resp)
                {
                    MessageBox.Show("Cargo: " + ccargo.nome + " Atualizado com Sucesso", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                

            }







        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você tem certeza?","Cat InfoGames", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                class_cargo ccargo = new class_cargo();
                // EXCLUIR POR CÓDIGO PRA NÃO ACABAR EXCLUINDO TUDO
                ccargo.cod_cargo = Convert.ToInt32(txt_codigo_cargo.Text);
                //CHAMAR O MÉTODO DE EXCLUIR
                bool resp = ccargo.excluir_cargo();

                if(resp)
                {
                    MessageBox.Show("Cargo: " + ccargo.nome + " Excluído com Sucesso", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Esse cargo não pode ser excluído", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                


            }

        }

        private void form_cargo_Load(object sender, EventArgs e)
        {
            if(tipo == "Atualização")
            {
                bt_cadastrar_cargos.Enabled = false;
                bt_atualizar.Enabled = true;
                bt_excluir.Enabled = true;
                lb_titulo.Text = "ATUALIZAR CARGO";
                panel_atuazalicão.Visible = true;
                lb_data_cad.Text = datacad.ToString();
            }
            else
            {
                bt_cadastrar_cargos.Enabled = true;

            }
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //FECHAR FORM

    }
}
