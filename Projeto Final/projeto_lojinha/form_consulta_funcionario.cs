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
    public partial class form_consulta_funcionario : Form
    {
        public form_consulta_funcionario()
        {
            InitializeComponent();
        }

        private void cmb_pesquisar_por_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_pesquisar_por.SelectedIndex == 0)
            {
                gp_cpf.Enabled = false;
                gp_status.Enabled = false;
                gp_cargo.Enabled = false;
                gp_nome.Enabled = true;
                rb_inicio.Checked = true;
                cmb_cargo.SelectedIndex = -1;
                txt_buscar_nome.Location = new Point(117, 19);
                txt_buscar_nome.Size = new Size(230, 23);
                lb_nome.Text = "Insira o nome:";

            }
            if (cmb_pesquisar_por.SelectedIndex == 1)
            {
                gp_nome.Enabled = false;
                gp_status.Enabled = false;
                gp_cargo.Enabled = false;
                gp_cpf.Enabled = true;
                cmb_cargo.SelectedIndex = -1;
                txt_buscar_nome.Location = new Point(117, 19);
                txt_buscar_nome.Size = new Size(230, 23);
                lb_nome.Text = "Insira o nome:";
            }

            if (cmb_pesquisar_por.SelectedIndex == 2)
            {
                gp_cpf.Enabled = false;
                gp_nome.Enabled = false;
                gp_cargo.Enabled = false;
                gp_status.Enabled = true;
                rb_ativo.Checked = true;
                cmb_cargo.SelectedIndex = -1;
                txt_buscar_nome.Location = new Point(117, 19);
                txt_buscar_nome.Size = new Size(230, 23);
                lb_nome.Text = "Insira o nome:";
            }
            if (cmb_pesquisar_por.SelectedIndex == 3)
            {
                gp_cpf.Enabled = false;
                gp_status.Enabled = false;
                gp_cargo.Enabled = false;
                gp_nome.Enabled = true;
                rb_inicio.Checked = true;
                cmb_cargo.SelectedIndex = -1;
                txt_buscar_nome.Size = new Size(222, 23);
                txt_buscar_nome.Location = new Point(125, 19);
                lb_nome.Text = "Insira a cidade:";

            }
            if(cmb_pesquisar_por.SelectedIndex == 4)
            {
                gp_cpf.Enabled = false;
                gp_status.Enabled = false;
                gp_nome.Enabled = false;
                rb_inicio.Checked = false;
                gp_cargo.Enabled = true;
                txt_buscar_nome.Location = new Point(117, 19);
                txt_buscar_nome.Size = new Size(230, 23);
                lb_nome.Text = "Insira o nome:";

            }
        }

        private void form_consulta_funcionario_Load(object sender, EventArgs e)
        {
            cmb_pesquisar_por.Items.Add("Nome");
            cmb_pesquisar_por.Items.Add("CPF");
            cmb_pesquisar_por.Items.Add("Status");
            cmb_pesquisar_por.Items.Add("Cidade");
            cmb_pesquisar_por.Items.Add("Cargo");
            cmb_pesquisar_por.SelectedIndex = 0;


            class_cargo ccargo = new class_cargo();
            cmb_cargo.DataSource = ccargo.buscar_cargo();
            cmb_cargo.DisplayMember = "nome";
            cmb_cargo.ValueMember = "cod_cargo";
            cmb_cargo.SelectedIndex = -1;

            


        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            //INSTANCIAR A CLASSE 
            class_funcionario ffuncionario = new class_funcionario();
            //VARIAVEL PRA FAZER A CONDIÇÃO E PUXAR A INFORMAÇÃO DEPENDENDO DO ITEM SELECIONADO
            string consulta = cmb_pesquisar_por.SelectedItem.ToString();

            switch(consulta)
            {
                case "Nome":
                    if(txt_buscar_nome.Text != "")
                    {
                        if(rb_inicio.Checked == true)
                        {
                            dvg_consulta_funcionario.DataSource = ffuncionario.consultar_funcionario_nomei(txt_buscar_nome.Text);
                        }
                        else
                        {
                            dvg_consulta_funcionario.DataSource = ffuncionario.consultar_funcionario_nomec(txt_buscar_nome.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Favor informar um nome", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    break;

                case "CPF":
                    {
                        if(msk_cpf.Text != "   .   .   -")
                        {
                            dvg_consulta_funcionario.DataSource = ffuncionario.consultar_funcionario_cpf(msk_cpf.Text);
                        }
                        else
                        {
                            MessageBox.Show("Favor preencher o campo CPF corretamente","Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
  
                    }

                case "Status":
                    {
                        if(rb_ativo.Checked == true)
                        {
                            dvg_consulta_funcionario.DataSource = ffuncionario.consultar_funcionario_status(1);
                        }
                        else
                        {
                            dvg_consulta_funcionario.DataSource = ffuncionario.consultar_funcionario_status(0);
                        }

                        break;
                    }

                case "Cidade":
                    {
                        if(txt_buscar_nome.Text != "")
                        {
                            if(rb_inicio.Checked == true)
                            {
                                dvg_consulta_funcionario.DataSource = ffuncionario.consultar_funcionario_cidadei(txt_buscar_nome.Text);
                            }
                            else
                            {
                                dvg_consulta_funcionario.DataSource = ffuncionario.consultar_funcionario_cidadec(txt_buscar_nome.Text);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Favor informar o nome cidade", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    }

                case "Cargo":
                    {
                        if(cmb_cargo.SelectedIndex != -1)
                        {
                            dvg_consulta_funcionario.DataSource = ffuncionario.consultar_funcionario_cargo(Convert.ToInt32(cmb_cargo.SelectedValue));
                        }
                        else
                        {
                            MessageBox.Show("Favor selecionar um cargo", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                        
                    }
                    break;
            
            
            }

       
        
        
        
        
        
        
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja alterar o funcionário selecionado?", "Cat InfoGames", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //INSTANCIAR CLASSE FUNCIONAR E FORMS 
                class_funcionario cfuncionario = new class_funcionario();
                form_funcionario ffuncionario = new form_funcionario();

                //CHAMAR O SELECT ALL E DEFINIR A LINHA E CELULA COMO 0 JÁ QUE O CLIENTE VAI SELECIONAR
                cfuncionario.consultar_funcionario(Convert.ToInt32(dvg_consulta_funcionario.SelectedRows[0].Cells[0].Value));

                //PASSAR OS DADOS DO BANCO DE DADOS PARA OS CONTROLES NO FORMS

                ffuncionario.txt_codigo.Text = cfuncionario.cod_funcionario.ToString();
                //EX: A CAIXA TXT_CODIGO TA RECEBENDO O COD_FUNCIONARIO DA CLASSE FUNCIONARIO(A INFORMAÇÃO DO BD)
                ffuncionario.txt_nome.Text = cfuncionario.nome.ToString();
                ffuncionario.txt_nome_social.Text = cfuncionario.nome_social.ToString();
                ffuncionario.msk_cpf.Text = cfuncionario.cpf.ToString();
                ffuncionario.msk_data_nascimento.Text = cfuncionario.data_nascimento.ToString();
                ffuncionario.datacad = cfuncionario.data_cadastro;
                ffuncionario.msk_telefone.Text = cfuncionario.telefone.ToString();
                ffuncionario.msk_celular.Text = cfuncionario.celular.ToString();
                ffuncionario.txt_email.Text = cfuncionario.email.ToString();
                ffuncionario.txt_login.Text = cfuncionario.login.ToString();
                ffuncionario.txt_senha.Text = cfuncionario.senha.ToString();
                ffuncionario.tipo_acesso = cfuncionario.tipo_acesso.ToString();
                ffuncionario.msk_cep.Text = cfuncionario.cep.ToString();
                ffuncionario.estado = cfuncionario.estado.ToString();
                ffuncionario.txt_rua.Text = cfuncionario.rua.ToString();
                ffuncionario.txt_numero.Text = cfuncionario.numero.ToString();
                ffuncionario.txt_complemento.Text = cfuncionario.complemento.ToString();
                ffuncionario.txt_bairro.Text = cfuncionario.bairro.ToString();
                ffuncionario.txt_cidade.Text = cfuncionario.cidade.ToString();
                ffuncionario.cargo = cfuncionario.cod_cargo.ToString();

                if(cfuncionario.status == 1)
                {
                    ffuncionario.cb_status.Checked = true;
                }
                else
                {
                    ffuncionario.cb_status.Checked = false;
                }

                ffuncionario.tipo = "Atualização";

                ffuncionario.ShowDialog();

                bt_pesquisar_Click(this, new EventArgs());


            }
               

            


        }





        private void msk_cpf_MouseUp(object sender, MouseEventArgs e)
        {
            if(msk_cpf.Text == "   .   .   -")
            
            SendKeys.Send("{HOME}");
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvg_consulta_funcionario_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            bt_editar.Enabled = true;
        }
    }
    
}
