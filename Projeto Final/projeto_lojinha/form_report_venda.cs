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
    public partial class form_report_venda : Form
    {
        public form_report_venda()
        {
            InitializeComponent();
        }

        private void form_report_venda_Load(object sender, EventArgs e)
        {



            //COMBO TIPO RELATÓRIO VENDA
            cmb_tipo_relatorio.Items.Add("Periodo Venda");
            cmb_tipo_relatorio.Items.Add("Produto mais Vendido");
            cmb_tipo_relatorio.Items.Add("Funcionário mais Produtivo");
            cmb_tipo_relatorio.Items.Add("Melhores Clientes");
            


            //CARREGAR COMBO MÊS FUNCIONÁRIO
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


            //CARREGAR COMBO MÊS CLIENTE
            cmb_meses_cliente.Items.Add("Meses:");
            cmb_meses_cliente.Items.Add("Janeiro");
            cmb_meses_cliente.Items.Add("Fevereiro");
            cmb_meses_cliente.Items.Add("Março");
            cmb_meses_cliente.Items.Add("Abril");
            cmb_meses_cliente.Items.Add("Maio");
            cmb_meses_cliente.Items.Add("Junho");
            cmb_meses_cliente.Items.Add("Julho");
            cmb_meses_cliente.Items.Add("Agosto");
            cmb_meses_cliente.Items.Add("Setembro");
            cmb_meses_cliente.Items.Add("Outubro");
            cmb_meses_cliente.Items.Add("Novembro");
            cmb_meses_cliente.Items.Add("Dezembro");
            cmb_meses_cliente.SelectedIndex = 0;

            //CARREGAR COMBO MÊS PRODUTO
            cmb_meses_produto.Items.Add("Meses:");
            cmb_meses_produto.Items.Add("Janeiro");
            cmb_meses_produto.Items.Add("Fevereiro");
            cmb_meses_produto.Items.Add("Março");
            cmb_meses_produto.Items.Add("Abril");
            cmb_meses_produto.Items.Add("Maio");
            cmb_meses_produto.Items.Add("Junho");
            cmb_meses_produto.Items.Add("Julho");
            cmb_meses_produto.Items.Add("Agosto");
            cmb_meses_produto.Items.Add("Setembro");
            cmb_meses_produto.Items.Add("Outubro");
            cmb_meses_produto.Items.Add("Novembro");
            cmb_meses_produto.Items.Add("Dezembro");
            cmb_meses_produto.SelectedIndex = 0;
        }

        private void cmb_tipo_relatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_tipo_relatorio.SelectedIndex == 0)
            {
                gb_periodo_venda.Enabled = true;
                gb_funcionario.Enabled = false;
                gb_cliente.Enabled = false;
                gb_produto.Enabled = false;
                report_periodo.Visible = true;
                report_funcionario.Visible = false;
                report_cliente.Visible = false;
                report_produto.Visible = false;
            }
            if(cmb_tipo_relatorio.SelectedIndex == 1)
            {
                gb_periodo_venda.Enabled = false;
                gb_funcionario.Enabled = false;
                gb_cliente.Enabled = false;
                gb_produto.Enabled = true;
                report_periodo.Visible = false;
                report_funcionario.Visible = false;
                report_cliente.Visible = false;
                report_produto.Visible = true;
            }
            if(cmb_tipo_relatorio.SelectedIndex == 2)
            {
                gb_periodo_venda.Enabled = false;
                gb_funcionario.Enabled = true;
                gb_cliente.Enabled = false;
                gb_produto.Enabled = false;
                report_periodo.Visible = false;
                report_funcionario.Visible = true;
                report_cliente.Visible = false;
                report_produto.Visible = false;

            }
            if(cmb_tipo_relatorio.SelectedIndex == 3)
            {
                gb_periodo_venda.Enabled = false;
                gb_funcionario.Enabled = false;
                gb_cliente.Enabled = true;
                gb_produto.Enabled = false;
                report_periodo.Visible = false;
                report_funcionario.Visible = false;
                report_cliente.Visible = true;
                report_produto.Visible = false;
            }
        }

        private void bt_gerar_relatorio_Click(object sender, EventArgs e)
        {
            if(cmb_tipo_relatorio.SelectedIndex != -1)
            {
                class_relatorio_venda rvenda = new class_relatorio_venda();

                string report = cmb_tipo_relatorio.SelectedItem.ToString();

                switch(report)
                {
                    case "Periodo Venda":
                       
                            class_relatorio_vendaBindingSource.DataSource = rvenda.relatorio_venda_periodo(Convert.ToDateTime(dtp_inicio.Text), Convert.ToDateTime(dtp_final.Text));
                              this.report_periodo.RefreshReport();
                        

                        break;

                    case "Funcionário mais Produtivo":
                        if (cmb_mes.SelectedIndex != 0)
                        {
                            class_relatorio_vendaBindingSource.DataSource = rvenda.relatorio_funcionario_venda(cmb_mes.SelectedIndex);
                            this.report_funcionario.RefreshReport();
                        }
                        else
                        {
                            MessageBox.Show("Escolha um mês", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;
                    case "Melhores Clientes":
                        if(cmb_meses_cliente.SelectedIndex != 0)
                        {
                            class_relatorio_vendaBindingSource.DataSource = rvenda.relatorio_cliente_venda(cmb_meses_cliente.SelectedIndex);
                            this.report_cliente.RefreshReport();
                        }
                        else
                        {
                            MessageBox.Show("Escolha um mês", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;
                    case "Produto mais Vendido":
                        if(cmb_meses_produto.SelectedIndex != 0)
                        {
                            class_relatorio_vendaBindingSource.DataSource = rvenda.relatorio_produto_mais_vendido(cmb_meses_produto.SelectedIndex);
                            this.report_produto.RefreshReport();
                        }
                        else
                        {
                            MessageBox.Show("Escolha um mês", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;
                }



            }
            else
            {
                MessageBox.Show("Escolher um tipo de relatório", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
               
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
