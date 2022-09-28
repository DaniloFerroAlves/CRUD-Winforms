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
    public partial class form_report_produto : Form
    {
        public form_report_produto()
        {
            InitializeComponent();
        }

        private void form_report_produto_Load(object sender, EventArgs e)
        {
            cmb_tipo.Items.Add("Venda");
            cmb_tipo.Items.Add("Locação");


        }


        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tipo.SelectedIndex == 0)
            {
                gb_categoria.Enabled = true;
                report_venda.Visible = true;
                report_locacao.Visible = false;
                cmb_categoria.SelectedIndex = -1;
                cmb_report.SelectedIndex = -1;
                gb_plataforma.Enabled = false;
                gb_data.Enabled = false;
                gb_genero.Enabled = false;
                gb_marca.Enabled = false;
                gb_status.Enabled = false;
                
            }
            else
            {
                gb_categoria.Enabled = true;
                report_venda.Visible = false;
                report_locacao.Visible = true;
                cmb_categoria.SelectedIndex = -1;
                cmb_report.SelectedIndex = -1;
                gb_plataforma.Enabled = false;
                gb_data.Enabled = false;
                gb_genero.Enabled = false;
                gb_marca.Enabled = false;
                gb_status.Enabled = false;

            }

        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_categoria.SelectedIndex == 0)
            {
                gb_report.Enabled = true;
                cmb_report.Enabled = true;
            }
            else
            {
                gb_report.Enabled = true;
                cmb_report.Enabled = true;
            }

            if (cmb_categoria.SelectedIndex == 0) // jogo
            {
                cmb_report.Items.Clear();
                cmb_report.Items.Add("Plataforma"); // 0
                cmb_report.Items.Add("Data Lançamento"); // 1
                cmb_report.Items.Add("Gênero"); // 2
                cmb_report.Items.Add("Status"); // 3

            }
            else // periférico
            {
                cmb_report.Items.Clear();
                cmb_report.Items.Add("Marca"); // 0
                cmb_report.Items.Add("Status"); // 1

            }
        }

        private void cmb_report_SelectedIndexChanged(object sender, EventArgs e)
        {
           // venda jogo e locação


            if (cmb_categoria.SelectedIndex == 0 && cmb_report.SelectedIndex == 0) // plataforma
            {
                gb_plataforma.Enabled = true;

                gb_data.Enabled = false;
                gb_genero.Enabled = false;
                gb_marca.Enabled = false;
                gb_status.Enabled = false;
            }
            else
            {
                gb_plataforma.Enabled = false;
                cmb_plataforma.SelectedIndex = -1;
            }

            if (cmb_categoria.SelectedIndex == 0  && cmb_report.SelectedIndex == 1) // data lançamento
            {
                gb_data.Enabled = true;

                gb_plataforma.Enabled = false;
                gb_genero.Enabled = false;
                gb_marca.Enabled = false;
                gb_status.Enabled = false;
            }
            else
            {
                msk_data_i.Text = "    ";
                msk_data_f.Text = "    ";
            }

            if (cmb_categoria.SelectedIndex == 0  && cmb_report.SelectedIndex == 2) // Gênero
            {
                gb_genero.Enabled = true;

                gb_data.Enabled = false;
                gb_plataforma.Enabled = false;
                gb_marca.Enabled = false;
                gb_status.Enabled = false;
            }
            else
            {
                gb_genero.Enabled = false;
                cmb_genero.SelectedIndex = -1;
            }

            if (cmb_categoria.SelectedIndex == 0 && cmb_report.SelectedIndex == 3) // Status
            {
                gb_status.Enabled = true;

                gb_data.Enabled = false;
                gb_genero.Enabled = false;
                gb_marca.Enabled = false;
                gb_plataforma.Enabled = false;
            }
            else
            {
                gb_status.Enabled = false;
                rb_statusatv.Checked = false;
                rb_statusinatv.Checked = false;
            }
            

            // perifericos

            if (cmb_categoria.SelectedIndex == 1 && cmb_report.SelectedIndex == 0) // marca
            {
                gb_marca.Enabled = true;

                gb_data.Enabled = false;
                gb_genero.Enabled = false;
                gb_plataforma.Enabled = false;
                gb_status.Enabled = false;
            }
            else
            {
                gb_marca.Enabled = false;
                cmb_marca.SelectedIndex = -1;
            }

            if (cmb_categoria.SelectedIndex == 1 && cmb_report.SelectedIndex == 1) // status
            {
                gb_status.Enabled = true;

                gb_data.Enabled = false;
                gb_genero.Enabled = false;
                gb_marca.Enabled = false;
                gb_plataforma.Enabled = false;
            }
            else
            {
                rb_statusatv.Checked = false;
                rb_statusinatv.Checked = false;
            }



        }
        private void cmb_categoria_MouseClick(object sender, MouseEventArgs e)
        {
            if (cmb_tipo.SelectedIndex == 0) // venda
            {
                class_categoria ccategoria = new class_categoria();
                cmb_categoria.DataSource = ccategoria.buscar_categoria();
                cmb_categoria.DisplayMember = "nome";
                cmb_categoria.ValueMember = "cod_categoria";
                cmb_categoria.SelectedIndex = -1;

            }
            else // locação
            {
                class_categoria ccategoria = new class_categoria();
                cmb_categoria.DataSource = ccategoria.buscar_jogo();
                cmb_categoria.DisplayMember = "nome";
                cmb_categoria.ValueMember = "cod_categoria";
                cmb_categoria.SelectedIndex = -1;
            }
        }

        private void bt_report_Click(object sender, EventArgs e)
        {
            if (cmb_report.SelectedIndex != -1)
            {
                if (cmb_tipo.SelectedIndex == 0)
                {

                    class_produto cproduto = new class_produto();


                    string report = cmb_report.SelectedItem.ToString();
                    switch (report)
                    {
                        case "Plataforma":
                            if (cmb_plataforma.SelectedItem == null)
                            {
                                MessageBox.Show("Favor selecionar uma plataforma", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                class_produtoBindingSource.DataSource = cproduto.relatorio_produto_venda_jogo_plataforma(Convert.ToInt32(cmb_plataforma.SelectedValue));
                                this.report_venda.RefreshReport();
                                cmb_plataforma.SelectedItem = -1;
                            }
                            break;

                        case "Data Lançamento":
                            if (msk_data_i.Text == "" && msk_data_f.Text == "")
                            {
                                MessageBox.Show("Favor preencher com o ano de lançamento", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                class_produtoBindingSource.DataSource = cproduto.relatorio_produto_venda_jogo_data_lancamento(Convert.ToInt32(msk_data_i.Text), Convert.ToInt32(msk_data_f.Text));
                                this.report_venda.RefreshReport();
                            }
                            break;

                        case "Gênero":
                            if (cmb_genero.SelectedItem == null)
                            {
                                MessageBox.Show("Favor selecionar um gênero", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                class_produtoBindingSource.DataSource = cproduto.relatorio_produto_venda_jogo_genero(Convert.ToInt32(cmb_genero.SelectedValue));
                                this.report_venda.RefreshReport();
                                cmb_genero.SelectedIndex = -1;
                            }
                            break;

                        case "Status":
                            if (rb_statusatv.Checked == true)
                            {
                                class_produtoBindingSource.DataSource = cproduto.relatorio_produto_venda_jogo_status(1);
                                this.report_venda.RefreshReport();
                            }
                            else
                            {
                                class_produtoBindingSource.DataSource = cproduto.relatorio_produto_venda_jogo_status(0);
                                this.report_venda.RefreshReport();
                            }
                            break;
                    }

                    string reportp = cmb_report.SelectedItem.ToString();
                    switch (reportp)
                    {
                        case "Marca":
                            if (cmb_marca.SelectedItem == null)
                            {
                                MessageBox.Show("Favor selecionar uma marca", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                class_produtoBindingSource.DataSource = cproduto.relatorio_produto_venda_periferico_marca(Convert.ToInt32(cmb_marca.SelectedValue));
                                this.report_venda.RefreshReport();
                                cmb_marca.SelectedIndex = -1;
                            }
                            break;
                        case "Status":
                            if (rb_statusatv.Checked == true)
                            {
                                class_produtoBindingSource.DataSource = cproduto.relatorio_produto_venda_periferico_status(1);
                                this.report_venda.RefreshReport();
                            }
                            else
                            {
                                class_produtoBindingSource.DataSource = cproduto.relatorio_produto_venda_periferico_status(0);
                                this.report_venda.RefreshReport();
                            }
                            break;


                    }
                }
                else
                {

                    string reportl = cmb_report.SelectedItem.ToString();

                    class_produto cproduto = new class_produto();
                    switch (reportl)
                    {
                        case "Plataforma":
                            if (cmb_plataforma.SelectedItem == null)
                            {
                                MessageBox.Show("Favor selecionar uma plataforma", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                class_produtoBindingSource.DataSource = cproduto.relatorio_produto_locacao_plataforma(Convert.ToInt32(cmb_plataforma.SelectedValue));
                                this.report_locacao.RefreshReport();
                                cmb_plataforma.SelectedItem = -1;
                            }
                            break;

                        case "Data Lançamento":
                            if (msk_data_i.Text == null && msk_data_f.Text == null)
                            {
                                MessageBox.Show("Favor preencher com o ano de lançamento", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                class_produtoBindingSource.DataSource = cproduto.relatorio_produto_locacao_data_lancamento(Convert.ToInt32(msk_data_i.Text), Convert.ToInt32(msk_data_f.Text));
                                this.report_locacao.RefreshReport();
                            }
                            break;

                        case "Gênero":
                            if (cmb_genero.SelectedItem == null)
                            {
                                MessageBox.Show("Favor selecionar um gênero", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                class_produtoBindingSource.DataSource = cproduto.relatorio_produto_locacao_genero(Convert.ToInt32(cmb_genero.SelectedValue));
                                this.report_locacao.RefreshReport();
                                cmb_genero.SelectedIndex = -1;
                            }
                            break;

                        case "Status":
                            if (rb_statusatv.Checked == true)
                            {
                                class_produtoBindingSource.DataSource = cproduto.relatorio_produto_locacao_status(1);
                                this.report_locacao.RefreshReport();
                            }
                            else
                            {
                                class_produtoBindingSource.DataSource = cproduto.relatorio_produto_locacao_status(0);
                                this.report_locacao.RefreshReport();
                            }
                            break;
                    }


                }
            }
            else
            {
                MessageBox.Show("Preencher os campos necessários para realizar o Relatório", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }


        private void cmb_plataforma_DropDown(object sender, EventArgs e)
        {
            class_plataforma cplataforma = new class_plataforma();

            cmb_plataforma.DataSource = cplataforma.buscar_plataforma();
            cmb_plataforma.DisplayMember = "nome";
            cmb_plataforma.ValueMember = "cod_plataforma";
            cmb_plataforma.SelectedIndex = -1;
        }

        private void cmb_genero_DropDown(object sender, EventArgs e)
        {
            class_genero cgenero = new class_genero();
            cmb_genero.DataSource = cgenero.buscar_genero();
            cmb_genero.DisplayMember = "nome";
            cmb_genero.ValueMember = "cod_genero";
            cmb_genero.SelectedIndex = -1;
        }

        private void cmb_marca_DropDown(object sender, EventArgs e)
        {
            class_marca cmarca = new class_marca();

            cmb_marca.DataSource = cmarca.buscar_marca();

            cmb_marca.DisplayMember = "nome";
            cmb_marca.ValueMember = "cod_marca";
            cmb_marca.SelectedIndex = -1;
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
