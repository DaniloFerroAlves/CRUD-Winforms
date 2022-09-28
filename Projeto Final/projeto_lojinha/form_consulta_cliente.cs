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
    public partial class form_consulta_cliente : Form
    {
        public form_consulta_cliente()
        {
            InitializeComponent();

        }



        
        private void form_consulta_cliente_Load(object sender, EventArgs e)
        {

            //ALIMENTAR A COMBO DE CONSULTA
            cmb_pesquisar_por.Items.Add("Nome");
            cmb_pesquisar_por.Items.Add("CPF");
            cmb_pesquisar_por.Items.Add("Status");
            cmb_pesquisar_por.Items.Add("Cidade");
            cmb_pesquisar_por.SelectedIndex = 0;

        }

        //FILTRO
        private void cmb_pesquisar_por_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_pesquisar_por.SelectedIndex == 0)
            {
                gp_cpf.Enabled = false;
                gp_status.Enabled = false;
                gp_nome.Enabled = true;
                rb_inicio.Checked = true;
                txt_buscar_nome.Location = new Point(117, 19);
                txt_buscar_nome.Size = new Size(230, 23);
                lb_nome.Text = "Insira o nome:";

            }
            if (cmb_pesquisar_por.SelectedIndex == 1)
            {
                gp_nome.Enabled = false;
                gp_status.Enabled = false;
                gp_cpf.Enabled = true;
                txt_buscar_nome.Location = new Point(117, 19);
                txt_buscar_nome.Size = new Size(230, 23);
                lb_nome.Text = "Insira o nome:";
            }

            if (cmb_pesquisar_por.SelectedIndex == 2)
            {
                gp_cpf.Enabled = false;
                gp_nome.Enabled = false;
                gp_status.Enabled = true;
                rb_ativo.Checked = true;
                txt_buscar_nome.Location = new Point(117, 19);
                txt_buscar_nome.Size = new Size(230, 23);
                lb_nome.Text = "Insira o nome:";
            }
            if(cmb_pesquisar_por.SelectedIndex ==3)
            {
                gp_cpf.Enabled = false;
                gp_status.Enabled = false;
                gp_nome.Enabled = true;
                rb_inicio.Checked = true;
                txt_buscar_nome.Size = new Size(222, 23);
                txt_buscar_nome.Location = new Point(125, 19);
                lb_nome.Text = "Insira a cidade:";

            }







        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            //INSTANCIAR A CLASSE PARA USAR OS MÉTODOS DE CONSULTAS, (NOME INICIO/NOME CONTEM, CPF, STATUS, CIDADE INICIO/CIDADE CONTEM)

            class_cliente ccliente = new class_cliente();
            string consulta = cmb_pesquisar_por.SelectedItem.ToString();

            switch (consulta) //CONSULTA POR NOME
            {
                case "Nome":
                    if (txt_buscar_nome.Text != "") //VALIDAR CAMPO
                    {
                        if (rb_inicio.Checked == true) //SE TIVER MARCADO INICIO, ELE BUSCA NO BANCO(DATASOURCE) PRA TRAZER NO DATAGRID (TRAZENDO O MÉTODO DE CONSULTAR CRIADA NA CLASSE)
                        {
                            dvg_consulta_cliente.DataSource = ccliente.consultar_cliente_nomei(txt_buscar_nome.Text);
                        }
                        else
                        {
                            dvg_consulta_cliente.DataSource = ccliente.consultar_cliente_nomec(txt_buscar_nome.Text);
                        }
                    }
                    else  //ELSE DO VALIDAR CAMPO
                    {
                        MessageBox.Show("Favor informar um nome", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case "CPF":

                    if (msk_cpf.Text != "   .   .   -") //VALIDAR CAMPO DA MASCARA
                    {
                        dvg_consulta_cliente.DataSource = ccliente.consultar_cliente_cpf(msk_cpf.Text);
                    }
                    else
                    {
                        MessageBox.Show("Favor preencher o campo CPF corretamente", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case "Status":
                    if(rb_ativo.Checked == true)
                    {
                        dvg_consulta_cliente.DataSource = ccliente.consultar_cliente_status(1);
                    }
                    else
                    {
                        dvg_consulta_cliente.DataSource = ccliente.consultar_cliente_status(0);
                    }

                    break;

                case "Cidade":
                    if(txt_buscar_nome.Text != "")
                    {
                        if(rb_inicio.Checked == true)
                        {
                            dvg_consulta_cliente.DataSource = ccliente.consultar_cliente_cidadei(txt_buscar_nome.Text);
                        }
                        else
                        {
                            dvg_consulta_cliente.DataSource = ccliente.consultar_cliente_cidadec(txt_buscar_nome.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Favor informar um nome de cidade", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
            }



        }



        private void bt_editar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja alterar o cliente selecionado?", "Cat InfoGames", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {                                             
                //INSTANCIAR A CLASSE PARA USAR O MÉTODO ATUALIZAR
                class_cliente ccliente = new class_cliente();
                //INSTANCIAR O FORMS PARA USAR O CONTROLE DO FORMS
                form_cliente fcliente = new form_cliente();
                //CHAMAR O SELECT ALL
                ccliente.consultar_cliente(Convert.ToInt32(dvg_consulta_cliente.SelectedRows[0].Cells[0].Value));

                //PASSAR OS DADOS DO BANCO DE DADOS PARA OS CONTROLES DO FORMS CLIENTE

                fcliente.txt_codigo.Text = ccliente.cod_cliente.ToString();
                fcliente.txt_nome.Text = ccliente.nome.ToString();
                fcliente.txt_nome_social.Text = ccliente.nome_social.ToString();
                fcliente.msk_cpf.Text = ccliente.cpf.ToString();
                fcliente.msk_data_nascimento.Text = ccliente.data_nascimento.ToString();
                fcliente.datacad = ccliente.data_cadastro;
                fcliente.msk_telefone.Text = ccliente.telefone.ToString();
                fcliente.msk_celular.Text = ccliente.celular.ToString();
                fcliente.txt_email.Text = ccliente.email.ToString();
                fcliente.msk_cep.Text = ccliente.cep.ToString();
                fcliente.estado = ccliente.estado.ToString();
                fcliente.txt_rua.Text = ccliente.rua.ToString();
                fcliente.txt_numero.Text = ccliente.numero.ToString();
                fcliente.txt_complemento.Text = ccliente.complemento.ToString();
                fcliente.txt_bairro.Text = ccliente.bairro.ToString();
                fcliente.txt_cidade.Text = ccliente.cidade.ToString();


                if(ccliente.status == 1) //SE O STATUS DO CLIENTE ESTIVER ATIVO = 1, A CAIXA NO FORMS VAI VIR CHECADA
                {
                    fcliente.cb_status.Checked = true;
                }
                else
                {
                    fcliente.cb_status.Checked = false;
                }

                fcliente.tipo = "Atualização"; //VARIAVEL DEFINIDA NO LOAD DO FORM PARA CONTROLE DO FORMULARIO

                fcliente.ShowDialog(); //SHOWDIALOG = MOSTRAR EM MODO EXCLUSIVO 

                bt_pesquisar_Click(this, new EventArgs()); //O EVENTO DO BOTÃO CONSULTA É CHAMADO NOVAMENTE(F5)

            }




        }

        //FECHAR FORM


        private void msk_cpf_MouseUp(object sender, MouseEventArgs e)
        {
            if(msk_cpf.Text == "   .   .   -")
            
            SendKeys.Send("{HOME}");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvg_consulta_cliente_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            bt_editar.Enabled = true;
        }
    }
}
