using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios;

namespace projeto_lojinha
{
    public partial class form_funcionario : Form
    {
        public form_funcionario()
        {
            InitializeComponent();

        }

        public string tipo, estado, cargo, tipo_acesso;

        public DateTime datacad;
        public void limpar() //MÉTODO PRA LIMPAR APÓS UM CADASTRO(INSERT)
        {
            txt_nome.Clear();
            txt_nome_social.Clear();
            msk_cpf.Clear();
            msk_data_nascimento.Clear();
            msk_celular.Clear();
            msk_telefone.Clear();
            txt_email.Clear();
            txt_login.Clear();
            txt_senha.Clear();
            cmb_tipo_acesso.SelectedIndex = -1;
            msk_cep.Clear();
            txt_cidade.Clear();
            txt_rua.Clear();
            txt_numero.Clear();
            txt_complemento.Clear();
            cmb_estado.SelectedItem = "SP"; //DEIXAR UM ESTADO COMO PADRÃO
            txt_bairro.Clear();
            cmb_cargo.SelectedIndex = -1; //DEIXAR UM CARGO COMO PADRÃO
            


        }



        private void bt_cadastrar_funcionario_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text != "" && msk_cpf.Text != "   .   .   -" && msk_cep.Text != "     -" && msk_data_nascimento.Text != "  /  /" && txt_login.Text != "" && txt_senha.Text != "" && cmb_tipo_acesso.SelectedIndex != -1 && (msk_telefone.Text != "(  )     -" || msk_celular.Text != "(  )      -")) //VALIDAR CAMPOS OBRIGATÓRIOS
            {
                class_funcionario ffuncionario = new class_funcionario();
                ffuncionario.nome = txt_nome.Text;
                ffuncionario.nome_social = txt_nome_social.Text;
                ffuncionario.cpf = msk_cpf.Text;
                ffuncionario.data_nascimento = Convert.ToDateTime(msk_data_nascimento.Text);
                ffuncionario.celular = msk_celular.Text;
                ffuncionario.telefone = msk_telefone.Text;
                ffuncionario.email = txt_email.Text;
                ffuncionario.login = txt_login.Text;
                ffuncionario.senha = txt_senha.Text;
                ffuncionario.tipo_acesso = cmb_tipo_acesso.SelectedItem.ToString();
                ffuncionario.cep = msk_cep.Text;
                ffuncionario.cidade = txt_cidade.Text;
                ffuncionario.rua = txt_rua.Text;
                
                if(txt_numero.Text == "") //EXISTEM CASAS QUE NÃO TEM NUMERO
                {
                    ffuncionario.numero = 0;

                }
                else
                {
                    ffuncionario.numero = Convert.ToInt32(txt_numero.Text);

                }
                
                ffuncionario.complemento = txt_complemento.Text;
                ffuncionario.estado = cmb_estado.SelectedItem.ToString();
                ffuncionario.bairro = txt_bairro.Text;
                ffuncionario.cod_cargo = Convert.ToInt32(cmb_cargo.SelectedValue); 


                if (msk_celular.Text != "(  )      -") //PRA MANDAR VAZIO PRO BANCO 
                {
                    ffuncionario.celular = msk_celular.Text;
                }
                else
                {
                    ffuncionario.celular = "";
                }

                if (msk_telefone.Text != "(  )     -")
                {
                    ffuncionario.telefone = msk_telefone.Text;
                }
                else
                {
                    ffuncionario.telefone = "";
                }

                int resp = ffuncionario.cadastrar_funcionario();

                if (resp == 1)
                {
                    MessageBox.Show("Funcionário: " + ffuncionario.nome + " Cadastrado com Sucesso", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    limpar();

                    txt_nome.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar funcionário", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencher os campos obrigatórios *", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
 

            }














        }

        private void form_funcionario_Load(object sender, EventArgs e)
        {
            //INSTANCIAR A CLASSE CARGO PARA USAR O MÉTODO DE SELECT
            class_cargo ccargo = new class_cargo();
            cmb_cargo.DataSource = ccargo.buscar_cargo(); //COMBO CARGO(DATASOURCE) BUSCAR USANDO O MÉTODO
            cmb_cargo.DisplayMember = "nome"; //MOSTRAR O NOME DO CARGO APENAS
            cmb_cargo.ValueMember = "cod_cargo"; //BUSCA PELO VALOR(CÓDIGO É INT)
            cmb_cargo.SelectedIndex = -1; // LIMPAR A COMBO, PRA NÃO FICAR ALGO COMO PADRÃO

            cmb_estado.Items.Add("AC");
            cmb_estado.Items.Add("AL");
            cmb_estado.Items.Add("AM");
            cmb_estado.Items.Add("AP");
            cmb_estado.Items.Add("BA");
            cmb_estado.Items.Add("CE");
            cmb_estado.Items.Add("DF");
            cmb_estado.Items.Add("ES");
            cmb_estado.Items.Add("GO");
            cmb_estado.Items.Add("MA");
            cmb_estado.Items.Add("MT");
            cmb_estado.Items.Add("MS");
            cmb_estado.Items.Add("MG");
            cmb_estado.Items.Add("PA");
            cmb_estado.Items.Add("PB");
            cmb_estado.Items.Add("PR");
            cmb_estado.Items.Add("PE");
            cmb_estado.Items.Add("PI");
            cmb_estado.Items.Add("RJ");
            cmb_estado.Items.Add("RN");
            cmb_estado.Items.Add("RS");
            cmb_estado.Items.Add("RO");
            cmb_estado.Items.Add("RR");
            cmb_estado.Items.Add("SC");
            cmb_estado.Items.Add("SP");
            cmb_estado.Items.Add("SE");
            cmb_estado.Items.Add("TO");


            //COMBO TIPO ACESSO

            cmb_tipo_acesso.Items.Add("Administrativo");
            cmb_tipo_acesso.Items.Add("Usuário Comum");
            
            cmb_estado.SelectedIndex = -1;

            if (tipo == "Atualização")
            {
                lb_titulo.Text = "ATUALIZAÇÃO FUNCIONÁRIO";
                bt_atualizar.Enabled = true;
                bt_excluir.Enabled = true;
                bt_cadastrar_funcionario.Enabled = false;
                cmb_estado.SelectedItem = estado;
                cmb_cargo.SelectedValue = cargo;
                cmb_tipo_acesso.SelectedItem = tipo_acesso;
                panel_incrementos.Visible = true;
                lb_data_cad.Text = datacad.ToString();

            }
            else
            {
                bt_excluir.Enabled = false;
                bt_atualizar.Enabled = false;
            }

            panel_nome.BackColor = Color.LawnGreen;


        }



        //MÉTODO PARA CONSULTAR CEP POR MEIO DA API DO CORREIO
        private void bt_buscar_cep_Click(object sender, EventArgs e)
        {
            try
            {
                CorreiosApi correios = new CorreiosApi();
                var retorno = correios.consultaCEP(msk_cep.Text);



                txt_bairro.Text = retorno.bairro;
                txt_rua.Text = retorno.end;
                txt_cidade.Text = retorno.cidade;
                cmb_estado.SelectedItem = retorno.uf;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar o CEP: " + erro.Message, "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //VALIDAÇÃO DE DATA
        private void msk_data_nascimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Preencha com uma data válida", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_data_nascimento.Clear();
            }
        }

        //FECHAR FORM


        private void msk_data_nascimento_MouseUp(object sender, MouseEventArgs e)
        {
            if (msk_data_nascimento.Text == "  /  /")
            {
                SendKeys.Send("{HOME}");
            }
        }

        private void msk_telefone_MouseUp(object sender, MouseEventArgs e)
        {
            if (msk_telefone.Text == "(  )     -")
            {
                SendKeys.Send("{HOME}");
            }
        }

        private void msk_celular_MouseUp(object sender, MouseEventArgs e)
        {
            if (msk_celular.Text == "(  )      -")

                SendKeys.Send("{HOME}");
        }

        private void msk_cpf_MouseUp(object sender, MouseEventArgs e)
        {
            if (msk_cpf.Text == "   .   .   -")

                SendKeys.Send("{HOME}");
        }

        private void msk_cep_MouseUp(object sender, MouseEventArgs e)
        {
            if (msk_cep.Text == "     -")

                SendKeys.Send("{HOME}");
        }

  

 

        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Você só pode digitar numeros", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        private void bt_fechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nome_Leave(object sender, EventArgs e)
        {
            panel_nome.BackColor = Color.DimGray;
        }

        private void txt_nome_social_MouseDown(object sender, MouseEventArgs e)
        {
            panel_social.BackColor = Color.LawnGreen;
        }

        private void txt_nome_social_Leave(object sender, EventArgs e)
        {
            panel_social.BackColor = Color.DimGray;
        }

        private void txt_email_MouseDown(object sender, MouseEventArgs e)
        {
            panel_email.BackColor = Color.LawnGreen;
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            panel_email.BackColor = Color.DimGray;
        }

        private void txt_nome_MouseDown(object sender, MouseEventArgs e)
        {
            panel_nome.BackColor = Color.LawnGreen;
        }

        private void txt_numero_MouseDown(object sender, MouseEventArgs e)
        {
            panel_numero.BackColor = Color.LawnGreen;
        }

        private void txt_numero_Leave(object sender, EventArgs e)
        {
            panel_numero.BackColor = Color.DimGray;
        }

        private void txt_complemento_MouseDown(object sender, MouseEventArgs e)
        {
            panel_complemento.BackColor = Color.LawnGreen;
        }

        private void txt_login_MouseDown(object sender, MouseEventArgs e)
        {
            panel_usuario.BackColor = Color.LawnGreen;
        }

        private void txt_login_Leave(object sender, EventArgs e)
        {
            panel_usuario.BackColor = Color.DimGray;
        }

        private void txt_senha_MouseDown(object sender, MouseEventArgs e)
        {
            panel_senha.BackColor = Color.LawnGreen;
        }

        private void txt_senha_Leave(object sender, EventArgs e)
        {
            panel_senha.BackColor = Color.DimGray;
        }

        private void txt_complemento_Leave(object sender, EventArgs e)
        {
            panel_complemento.BackColor = Color.DimGray;
        }










        //BOTÃO ATUALIZAR
        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text != "" && msk_cpf.Text != "   .   .   -" && msk_cep.Text != "     -" && msk_data_nascimento.Text != "  /  /" && txt_login.Text != "" && txt_senha.Text != "" && cmb_tipo_acesso.SelectedIndex != -1 && (msk_telefone.Text != "(  )     -" || msk_celular.Text != "(  )      -")) //VALIDAR CAMPOS OBRIGATÓRIOS
            {
                class_funcionario ffuncionario = new class_funcionario();
                ffuncionario.nome = txt_nome.Text;
                ffuncionario.nome_social = txt_nome_social.Text;
                ffuncionario.cpf = msk_cpf.Text;
                ffuncionario.data_nascimento = Convert.ToDateTime(msk_data_nascimento.Text);
                ffuncionario.celular = msk_celular.Text;
                ffuncionario.telefone = msk_telefone.Text;
                ffuncionario.email = txt_email.Text;
                ffuncionario.login = txt_login.Text;
                ffuncionario.senha = txt_senha.Text;
                ffuncionario.tipo_acesso = tipo_acesso;
                ffuncionario.cep = msk_cep.Text;
                ffuncionario.cidade = txt_cidade.Text;
                ffuncionario.rua = txt_rua.Text;

                if (txt_numero.Text != "")
                {
                    
                    ffuncionario.numero = Convert.ToInt32(txt_numero.Text);
                }
                else
                {
                    ffuncionario.numero = 0;

                }

                ffuncionario.complemento = txt_complemento.Text;
                ffuncionario.estado = cmb_estado.SelectedItem.ToString();
                ffuncionario.bairro = txt_bairro.Text;
                ffuncionario.cod_cargo = Convert.ToInt32(cmb_cargo.SelectedValue);


                if (msk_celular.Text != "(  )      -") //PRA MANDAR VAZIO PRO BANCO 
                {
                    ffuncionario.celular = msk_celular.Text;
                }
                else
                {
                    ffuncionario.celular = "";
                }

                if (msk_telefone.Text != "(  )     -")
                {
                    ffuncionario.telefone = msk_telefone.Text;
                }
                else
                {
                    ffuncionario.telefone = "";
                }
                if(cb_status.Checked == true) //TRAZER O STATUS
                {
                    ffuncionario.status = 1;
                }
                else
                {
                    ffuncionario.status = 0;
                }
                
                //TRAZER O CÓDIGO PARA NÃO ATUALIZAR TODOS FUNCIONÁRIOS
                ffuncionario.cod_funcionario = Convert.ToInt32(txt_codigo.Text);

                bool resp = ffuncionario.atualizar_funcionario();

                if (resp)
                {
                    MessageBox.Show("Funcionário: " + ffuncionario.nome + " Atualizado com Sucesso", "Lojinha Cat Informatica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar funcionário", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencher os campos obrigatórios *", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //BOTÃO EXCLUIR :d
        private void bt_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja excluir ? ", "Cat InfoGames", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                class_funcionario ffuncionario = new class_funcionario();
                ffuncionario.cod_cargo = Convert.ToInt32(txt_codigo.Text); //EXCLUIR POR CÓDIGO(WHERE)

                bool resp = ffuncionario.excluir_funcionario();

                if(resp)
                {
                    MessageBox.Show("Funcionário: " + ffuncionario.nome + " Excluído com Sucesso", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Esse funcionário não pode ser excluído, há registros em outras tabelas", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

       




    }
}
