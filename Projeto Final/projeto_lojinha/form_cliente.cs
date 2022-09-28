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
    public partial class form_cliente : Form
    {
        public form_cliente()
        {
            InitializeComponent();
        }

        public string tipo, estado;  // VARIAVEIS GLOBAIS PARA TRAZER O TIPO DE EDIÇÃO E TRAZER O ESTADO CERTO NA COMBOBOX
        public DateTime datacad; //TRAZER A DATA CERTA DE CADASTRO
        
        private void limpar()
        {
            txt_nome.Clear();
            txt_nome_social.Clear();
            msk_cpf.Clear();
            msk_data_nascimento.Clear();
            txt_email.Clear();
            msk_cep.Clear();
            txt_cidade.Clear();
            txt_rua.Clear();
            txt_numero.Clear();
            txt_complemento.Clear();
            cb_estado.SelectedItem = "SP";
            txt_bairro.Clear();
            msk_telefone.Clear();
            msk_celular.Clear();

        }

        
        
        private void bt_cadastrar_cliente_Click(object sender, EventArgs e)
        {
            
            
            if(txt_nome.Text != "" && msk_cpf.Text != "   .   .   -" && msk_cep.Text != "     -" && msk_data_nascimento.Text != "  /  /" && (msk_telefone.Text != "(  )     -" || msk_celular.Text != "(  )      -"))
            {
                class_cliente ccliente = new class_cliente();
                ccliente.nome = txt_nome.Text;
                ccliente.nome_social = txt_nome_social.Text;
                ccliente.cpf = msk_cpf.Text;
                ccliente.data_nascimento = Convert.ToDateTime (msk_data_nascimento.Text);
                ccliente.email = txt_email.Text;
                ccliente.cep = msk_cep.Text;
                ccliente.cidade = txt_cidade.Text;
                ccliente.rua = txt_rua.Text;                
                ccliente.complemento = txt_complemento.Text;
                ccliente.estado = cb_estado.SelectedItem.ToString();
                ccliente.bairro = txt_bairro.Text;
                
                if(txt_numero.Text != "") //MANDAR VAZIO, PQ TEM CASAS Q NÃO TEM NUMERO
                {
                    ccliente.numero = Convert.ToInt32(txt_numero.Text);
                }
                else
                {
                    ccliente.numero = 0;
                }

                if(msk_celular.Text != "(  )      -") //PRA MANDAR VAZIO PRO BANCO 
                {
                    ccliente.celular = msk_celular.Text;
                }
                else
                {
                    ccliente.celular = "";
                }
                
                if(msk_telefone.Text != "(  )     -")
                {
                    ccliente.telefone = msk_telefone.Text;
                }
                else
                {
                    ccliente.telefone = "";
                }

                int resp = ccliente.cadastro_cliente(); //MÉTODO DA CLASSE CLIENTE PARA REALIZAR O CADASTRO

                if(resp == 1)
                {
                    MessageBox.Show("Cliente: " + ccliente.nome + " Cadastrado com Sucesso", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    limpar();

                    txt_nome.Focus();

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
        //COMBO DE ESTADO
        private void form_cliente_Load(object sender, EventArgs e)
        {
            lb_data_cad.Text = DateTime.Now.ToShortDateString();
            cb_estado.Items.Add("AC");
            cb_estado.Items.Add("AL");
            cb_estado.Items.Add("AM");
            cb_estado.Items.Add("AP");
            cb_estado.Items.Add("BA");
            cb_estado.Items.Add("CE");
            cb_estado.Items.Add("DF");
            cb_estado.Items.Add("ES");
            cb_estado.Items.Add("GO");
            cb_estado.Items.Add("MA");
            cb_estado.Items.Add("MT");
            cb_estado.Items.Add("MS");
            cb_estado.Items.Add("MG");
            cb_estado.Items.Add("PA");
            cb_estado.Items.Add("PB");
            cb_estado.Items.Add("PR");
            cb_estado.Items.Add("PE");
            cb_estado.Items.Add("PI");
            cb_estado.Items.Add("RJ");
            cb_estado.Items.Add("RN");
            cb_estado.Items.Add("RS");
            cb_estado.Items.Add("RO");
            cb_estado.Items.Add("RR");
            cb_estado.Items.Add("SC");
            cb_estado.Items.Add("SP");
            cb_estado.Items.Add("SE");
            cb_estado.Items.Add("TO");

            

            cb_estado.SelectedIndex = -1;

            if(tipo == "Atualização")
            {
                lb_cadastro.Text = "ATUALIZAÇÃO CLIENTE";
                bt_atualizar.Enabled = true; //ATIVAR BOTÃO ATUALIZAR
                bt_excluir.Enabled = true; //ATIVAR O EXCLUIR
                bt_cadastrar_cliente.Enabled = false; 
                //DESATIVAR O BOTÃO CADASTRAR, PQ VOCÊ ESTA EDITANDO UM JÁ CADASTRADO
                cb_estado.SelectedItem = estado; 
                //VARIAVEL ESTADO CRIADA PARA BUSCAR A INFORMAÇÃO NO BANCO, É NECESSARIA PQ UMA COMBO CARREGA NO LOAD
                panel_incrementos.Visible = true; //EXIBIR O PAINEL COM(DATA CADASTRO,STATUS,CODIGO)
                lb_data_cad.Text = datacad.ToString(); //VARIAVEL DATETIME PARA TRAZER A DATA CADASTRO CERTA NO BANCO
                
            }
            else
            {
                bt_excluir.Enabled = false; //DESATIVAR BOTÃO CASO NÃO SEJA DO TIPO "ATUALIZAÇÃO"
                bt_atualizar.Enabled = false; 
            }


            panel_nome.BackColor = Color.LawnGreen;

            

        }

        //VALIDAÇÃO DE DATA VALIDA
        private void msk_data_nascimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if(!e.IsValidInput)
            {
                MessageBox.Show("Preencha com uma data válida", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_data_nascimento.Clear();
            }
        }


        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text != "" && msk_cpf.Text != "   .   .   -" && msk_cep.Text != "     -" && msk_data_nascimento.Text != "  /  /" && (msk_telefone.Text != "(  )     -" || msk_celular.Text != "(  )      -"))
            {
                class_cliente ccliente = new class_cliente();
                ccliente.nome = txt_nome.Text;
                ccliente.nome_social = txt_nome_social.Text;
                ccliente.cpf = msk_cpf.Text;
                ccliente.data_nascimento = Convert.ToDateTime(msk_data_nascimento.Text);
                ccliente.email = txt_email.Text;
                ccliente.cep = msk_cep.Text;
                ccliente.cidade = txt_cidade.Text;
                ccliente.rua = txt_rua.Text;
                ccliente.numero = Convert.ToInt32(txt_numero.Text);
                ccliente.complemento = txt_complemento.Text;
                ccliente.estado = cb_estado.SelectedItem.ToString();
                ccliente.bairro = txt_bairro.Text;


                if (msk_celular.Text != "(  )      -") //PRA MANDAR VAZIO PRO BANCO 
                {
                    ccliente.celular = msk_celular.Text;
                }
                else
                {
                    ccliente.celular = "";
                }

                if (msk_telefone.Text != "(  )     -")
                {
                    ccliente.telefone = msk_telefone.Text;
                }
                else
                {
                    ccliente.telefone = "";
                }
                if(cb_status.Checked == true)
                {
                    ccliente.status = 1;
                }
                else
                {
                    ccliente.status = 0;
                }

                //CHAMAR O  CÓDIGO DO CLIENTE
                ccliente.cod_cliente = Convert.ToInt32(txt_codigo.Text);
                
                bool resp = ccliente.atualizar_cliente(); //MÉTODO DA CLASSE CLIENTE PARA REALIZAR O CADASTRO

                if (resp)
                {
                    MessageBox.Show("Cliente: " + ccliente.nome + " Atualizado com Sucesso", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Preencher os campos obrigatórios *", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //BOTÃO EXCLUIR
        private void bt_excluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você tem certeza que deseja excluir?","Cat InfoGames", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                class_cliente ccliente = new class_cliente();
                ccliente.cod_cliente = Convert.ToInt32(txt_codigo.Text);

                bool resp = ccliente.excluir_cliente();

                if(resp)
                {
                    MessageBox.Show("Cliente: " + ccliente.nome + " Excluído com Sucesso", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este cliente não pode ser excluído, há registros em outras tabelas ", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //FECHAR FORM
        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void msk_data_nascimento_MouseUp(object sender, MouseEventArgs e)
        {
            if(msk_data_nascimento.Text == "  /  /")
            {
                SendKeys.Send("{HOME}");
            }
            


        }

        private void msk_telefone_MouseClick(object sender, MouseEventArgs e)
        {
            if(msk_telefone.Text == "(  )     -")
            {
                SendKeys.Send("{HOME}");
            }


        }

        private void msk_celular_MouseUp(object sender, MouseEventArgs e)
        {
            if(msk_celular.Text == "(  )      -")
            
            SendKeys.Send("{HOME}");
        }

        private void msk_cpf_MouseUp(object sender, MouseEventArgs e)
        {
            if(msk_cpf.Text == "   .   .   -")
            
            SendKeys.Send("{HOME}");
        }

        private void msk_cep_MouseUp(object sender, MouseEventArgs e)
        {
            if(msk_cep.Text == "     -")
            
            SendKeys.Send("{HOME}");
        }

        //EVENTO DO TICK PRA PISCAR
        private void timer_cep_piscar_Tick(object sender, EventArgs e)
        {
            msk_cep.BackColor = msk_cep.BackColor == Color.White? Color.White : Color.LightGray;
        }

        private void timer_nome_piscar_Tick(object sender, EventArgs e)
        {
            txt_nome.BackColor = txt_nome.BackColor == Color.LightGray ? Color.White : Color.LightGray;
        }

        private void timer_cpf_piscar_Tick(object sender, EventArgs e)
        {
            msk_cpf.BackColor = msk_cpf.BackColor == Color.LightGray ? Color.White : Color.LightGray;
        }

        private void timer_data_piscar_Tick(object sender, EventArgs e)
        {
            msk_data_nascimento.BackColor = msk_data_nascimento.BackColor == Color.LightGray ? Color.White : Color.LightGray;
        }

        private void timer_teloucel_piscar_Tick(object sender, EventArgs e)
        {
            msk_celular.BackColor = msk_celular.BackColor == Color.LightGray ? Color.White : Color.LightGray;
            msk_telefone.BackColor = msk_telefone.BackColor == Color.LightGray ? Color.White : Color.LightGray;
        }



        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Você só pode digitar numeros", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txt_nome_MouseDown(object sender, MouseEventArgs e)
        {
            panel_nome.BackColor = Color.LawnGreen;
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

        private void txt_complemento_Leave(object sender, EventArgs e)
        {
            panel_complemento.BackColor = Color.DimGray;
        }

        //FIM DO EVENTO



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
                cb_estado.SelectedItem = retorno.uf;

            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao consultar o CEP: " + erro.Message, "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            

        }






    }
}
