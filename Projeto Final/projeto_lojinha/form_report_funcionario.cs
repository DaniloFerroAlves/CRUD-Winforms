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
    public partial class form_report_funcionario : Form
    {
        public form_report_funcionario()
        {
            InitializeComponent();
        }

        private void form_relatorio_funcionario_Load(object sender, EventArgs e)
        {
            //COMBO TIPO DO RELATÓRIO

            cmb_tipo_relatorio.Items.Add("Intervalo de Idades");
            cmb_tipo_relatorio.Items.Add("Aniversariantes Maiores de");
            cmb_tipo_relatorio.Items.Add("Aniversariantes do mês");
            cmb_tipo_relatorio.Items.Add("Cidade");
            cmb_tipo_relatorio.Items.Add("Bairro");
            cmb_tipo_relatorio.Items.Add("Cargo");
            cmb_tipo_relatorio.Items.Add("Status");
            cmb_tipo_relatorio.SelectedIndex = 6;

            //CARREGAR COMBO MÊS
            cmb_mes.Items.Add("Meses:");
            cmb_mes.Items.Add("Janeiro");
            cmb_mes.Items.Add("Fevereiro");
            cmb_mes.Items.Add("Março");
            cmb_mes.Items.Add("Abril");
            cmb_mes.Items.Add("Maio");
            cmb_mes.Items.Add("Junho");
            cmb_mes.Items.Add("Julho");
            cmb_mes.Items.Add("Agosto");
            cmb_mes.Items.Add("Setembro");
            cmb_mes.Items.Add("Outubro");
            cmb_mes.Items.Add("Novembro");
            cmb_mes.Items.Add("Dezembro");
            cmb_mes.SelectedIndex = 0;


            //INSTANCIAR E USANDO O MÉTODO BUSCAR_CIDADE
            class_funcionario cfuncionario = new class_funcionario();
            cmb_cidade.DataSource = cfuncionario.buscar_cidade();
            cmb_cidade.DisplayMember = "cidade";
            cmb_cidade.ValueMember = "cidade";
            cmb_cidade.SelectedIndex = -1;
            //MÉTODO BUSCAR BAIRRO
            cmb_bairro.DataSource = cfuncionario.buscar_bairro();
            cmb_bairro.DisplayMember = "bairro";
            cmb_bairro.ValueMember = "bairro";
            cmb_bairro.SelectedIndex = -1;
            //MÉTODO PRA BUSCAR CARGO
            class_cargo ccargo = new class_cargo();
            cmb_cargo.DataSource = ccargo.buscar_cargo();
            cmb_cargo.DisplayMember = "nome";
            cmb_cargo.ValueMember = "cod_cargo";
            cmb_cargo.SelectedIndex = -1;



        }

        private void cmb_tipo_relatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //IDADE

            if(cmb_tipo_relatorio.SelectedIndex == 0)
            {
                gp_idade_if.Enabled = true;
                gp_bairro.Enabled = false;
                gp_cidade.Enabled = false;
                gp_maiores.Enabled = false;
                gp_status.Enabled = false;
                gp_cargo.Enabled = false;
                rb_ativo.Checked = false;
                gp_mes.Enabled = false;
            }
            if (cmb_tipo_relatorio.SelectedIndex == 1)
            {
                gp_idade_if.Enabled = false;
                gp_bairro.Enabled = false;
                gp_cidade.Enabled = false;
                gp_maiores.Enabled = true;
                gp_status.Enabled = false;
                gp_cargo.Enabled = false;
                rb_ativo.Checked = false;
                gp_mes.Enabled = false;
            }
            if(cmb_tipo_relatorio.SelectedIndex == 2)
            {
                gp_idade_if.Enabled = false;
                gp_bairro.Enabled = false;
                gp_cidade.Enabled = false;
                gp_maiores.Enabled = false;
                gp_status.Enabled = false;
                gp_cargo.Enabled = false;
                rb_ativo.Checked = false;
                gp_mes.Enabled = true;
            }
            if(cmb_tipo_relatorio.SelectedIndex == 3)
            {
                gp_idade_if.Enabled = false;
                gp_bairro.Enabled = false;
                gp_cidade.Enabled = true;
                gp_maiores.Enabled = false;
                gp_status.Enabled = false;
                gp_cargo.Enabled = false;
                rb_ativo.Checked = false;
                gp_mes.Enabled = false;
            }
            if(cmb_tipo_relatorio.SelectedIndex == 4)
            {
                gp_idade_if.Enabled = false;
                gp_bairro.Enabled = true;
                gp_cidade.Enabled = false;
                gp_maiores.Enabled = false;
                gp_status.Enabled = false;
                gp_cargo.Enabled = false;
                rb_ativo.Checked = false;
                gp_mes.Enabled = false;
            }
            if(cmb_tipo_relatorio.SelectedIndex == 5)
            {
                gp_idade_if.Enabled = false;
                gp_bairro.Enabled = false;
                gp_cidade.Enabled = false;
                gp_maiores.Enabled = false;
                gp_status.Enabled = false;
                gp_cargo.Enabled = true;
                rb_ativo.Checked = false;
                gp_mes.Enabled = false;
            }
            if (cmb_tipo_relatorio.SelectedIndex == 6)
            {
                gp_idade_if.Enabled = false;
                gp_bairro.Enabled = false;
                gp_cidade.Enabled = false;
                gp_maiores.Enabled = false;
                gp_status.Enabled = true;
                gp_cargo.Enabled = false;
                rb_ativo.Checked = true;
                gp_mes.Enabled = false;
            }

        }



        private void bt_gerar_relatorio_Click(object sender, EventArgs e)
        {
            //ISTANCIAR CLASSE PRA USAR OS MÉTODOS DE RELATÓRIO

            class_funcionario cfuncionario = new class_funcionario();

            string relatorio = cmb_tipo_relatorio.SelectedItem.ToString();



            switch(relatorio)
            {
                case "Intervalo de Idades":
                    {
                        int inicio = Convert.ToInt32(txt_idade_inicio.Text);
                        int final = Convert.ToInt32(txt_idade_final.Text);


                        if(inicio <= final)
                        {
                            if (txt_idade_inicio.Text != "" && txt_idade_final.Text != "")
                            {

                                class_funcionarioBindingSource.DataSource = cfuncionario.relatorio_funcionario_idade_intervalo(Convert.ToInt32(txt_idade_inicio.Text), Convert.ToInt32(txt_idade_final.Text));
                                this.report_viewer_funcionario.RefreshReport();

                            }
                            else
                            {
                                MessageBox.Show("Favor preencher os campos vazios", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Intervalo de idades invalída", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;

                    }

                case "Cidade":
                    if(cmb_cidade.SelectedItem != null)
                    {
                        class_funcionarioBindingSource.DataSource = cfuncionario.relatorio_funcionario_cidade(cmb_cidade.SelectedValue.ToString());
                        this.report_viewer_funcionario.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor selecionar um campo", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Status":
                    if(rb_ativo.Checked == true)
                    {
                        class_funcionarioBindingSource.DataSource = cfuncionario.relatorio_funcionario_status(1);
                        this.report_viewer_funcionario.RefreshReport();
                    }
                    else
                    {
                        class_funcionarioBindingSource.DataSource = cfuncionario.relatorio_funcionario_status(0);
                        this.report_viewer_funcionario.RefreshReport();
                    }
                    break;
                case "Aniversariantes Maiores de":
                    if(txt_maioresde.Text != "")
                    {
                        class_funcionarioBindingSource.DataSource = cfuncionario.relatorio_funcionario_idade_maior(Convert.ToInt32(txt_maioresde.Text));
                        this.report_viewer_funcionario.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor preencher campo vazio", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Bairro":
                    if(cmb_bairro.SelectedItem != null)
                    {
                        class_funcionarioBindingSource.DataSource = cfuncionario.relatorio_funcionario_bairro(cmb_bairro.SelectedValue.ToString());
                        this.report_viewer_funcionario.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor selecionar um campo", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Cargo":
                    if(cmb_cargo.SelectedItem != null)
                    {
                        class_funcionarioBindingSource.DataSource = cfuncionario.relatorio_funcionario_cargo(Convert.ToInt32(cmb_cargo.SelectedValue));
                        this.report_viewer_funcionario.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor selecionar um campo", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Aniversariantes do mês":
                    if(cmb_mes.SelectedIndex != 0)
                    {
                        class_funcionarioBindingSource.DataSource = cfuncionario.relatorio_funcionario_aniversariantes_mes(Convert.ToInt32(cmb_mes.SelectedIndex));
                        this.report_viewer_funcionario.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor selecionar um campo", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
                
        }

        private void txt_idade_inicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Você só pode digitar numeros", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txt_idade_final_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Você só pode digitar numeros", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txt_maioresde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Você só pode digitar numeros", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
