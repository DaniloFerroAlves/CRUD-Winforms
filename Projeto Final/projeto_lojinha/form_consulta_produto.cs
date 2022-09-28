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
    public partial class form_consulta_produto : Form
    {
        public form_consulta_produto()
        {
            InitializeComponent();
        }
        


        

        private void rb_venda_CheckedChanged(object sender, EventArgs e)
        {
            // venda
            cmb_consulta.Items.Clear();
            
            cmb_consulta.Items.Add("Nome"); // 0
            cmb_consulta.Items.Add("Status"); // 1 
            cmb_consulta.Items.Add("Categoria"); // 2
            cmb_consulta.Items.Add("Preço Jogo"); // 3 
            cmb_consulta.Items.Add("Marca"); //4
            cmb_consulta.Items.Add("Preço Periférico"); // 5
            cmb_consulta.Items.Add("Data Lançamento"); // 6

            gb_venda.Visible = true;

            gb_locacao.Visible = false;
        }

        private void rb_locacao_CheckedChanged(object sender, EventArgs e)
        {

            //locação
            cmb_consulta.Items.Clear();

            cmb_consulta.Items.Add("Nome"); // 0
            cmb_consulta.Items.Add("Status"); // 1
            cmb_consulta.Items.Add("Preço Diária"); // 2
            cmb_consulta.Items.Add("Desenvolvedor"); // 3
            cmb_consulta.Items.Add("Data Lançamento"); // 4
            cmb_consulta.Items.Add("Plataforma"); // 5
            cmb_consulta.Items.Add("Locação"); //6

            gb_venda.Visible = false;

            gb_locacao.Visible = true;
            

        }




        private void cmb_consulta_SelectedIndexChanged(object sender, EventArgs e)
        {

            // gb = group box
            // l = locação
            // v = venda

            // venda

            if (cmb_consulta.SelectedIndex == 0) // nome
            {
                gb_nome.Enabled = true;
            }
            else
            {
                gb_nome.Enabled = false;
            }

            if (cmb_consulta.SelectedIndex == 1) // status
            {
                gb_status_v.Enabled = true;
            }
            else
            {
                gb_status_v.Enabled = false;

            }
            
            if (cmb_consulta.SelectedIndex == 2) // categoria
            {
                gb_nome.Enabled = true;
            }
           
            if (cmb_consulta.SelectedIndex == 3) // preço jogo
            {
                gb_preco_jogo_v.Enabled = true;
            }
            else
            {
                gb_preco_jogo_v.Enabled = false;
            }

            if (cmb_consulta.SelectedIndex == 4) // marca
            {
                gb_nome.Enabled = true;
            }

            if (cmb_consulta.SelectedIndex == 5) // preço periferico
            {
                gb_preco_periferico_v.Enabled = true;
            }
            else
            {
                gb_preco_periferico_v.Enabled = false;
            }
            if (cmb_consulta.SelectedIndex == 6)
            {
                gb_venda_data.Enabled = true;
            }


            //Nome 0
            //Status 1
            //Preço Diária  2
            //Desenvolvedor 3
            //Data Lançamento 4  
            //plataforma 5

            if (cmb_consulta.SelectedIndex == 0)
            {
                gb_nome_l.Enabled = true;
                                             
            }
            else
            {
                gb_nome_l.Enabled = false;
            }

            if (cmb_consulta.SelectedIndex == 1)
            {
                gb_status_l.Enabled = true;
            }
            else
            {
                gb_status_l.Enabled = false;
            }

            if (cmb_consulta.SelectedIndex == 2)
            {
                gb_preco_diaria.Enabled = true;
            }
            else
            {
                gb_preco_diaria.Enabled = false;
            }
            if (cmb_consulta.SelectedIndex == 3)
            {
                gb_nome_l.Enabled = true;
            }
            
            if (cmb_consulta.SelectedIndex == 4 )
            {
                gb_data_lancamento.Enabled = true;
            }
            else
            {
                gb_data_lancamento.Enabled = false;
            }

            if (cmb_consulta.SelectedIndex == 5)
            {
                gb_nome_l.Enabled = true;
            }
            if(cmb_consulta.SelectedIndex == 6)
            {
                gb_alugado.Enabled = true;
            }
            else
            {
                gb_alugado.Enabled = false;
            }

        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            if(rb_locacao.Checked != false || rb_venda.Checked != false)
            {
                if (rb_venda.Checked == true)
                {
                    //instanciar a classe produto para usar os métodos de consulta

                    class_produto cproduto = new class_produto();

                    //criar uma variável para receber a opção escolhida pelo usuário na combo
                    if(cmb_consulta.SelectedIndex == -1)
                    {
                        MessageBox.Show("Favor escolher um tipo de consulta", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                    }
                    
                    string consulta_venda = cmb_consulta.SelectedItem.ToString();

                    switch (consulta_venda)
                    {
                        case "Nome":
                            if (txt_nome_v.Text == "")
                            {
                                MessageBox.Show("Favor Informar um Nome", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {

                                if (rb_nomei_v.Checked == true)
                                {
                                    dt.DataSource = cproduto.consulta_produto_venda_nomei(txt_nome_v.Text);
                                }
                                else
                                {
                                    dt.DataSource = cproduto.consulta_produto_venda_nomec(txt_nome_v.Text);
                                }
                            }
                            break;

                        case "Status":
                            if (rb_statusatv_v.Checked == true)
                            {
                                dt.DataSource = cproduto.consulta_produto_venda_status(1);

                            }
                            else
                            {

                                dt.DataSource = cproduto.consulta_produto_venda_status(0);


                            }
                            break;

                        case "Categoria":
                            if (txt_nome_v.Text == "")
                            {
                                MessageBox.Show("Favor Informar um Nome", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                if (rb_nomei_v.Checked == true)
                                {
                                    dt.DataSource = cproduto.consulta_produto_venda_categoriai(txt_nome_v.Text);

                                }
                                else
                                {
                                    dt.DataSource = cproduto.consulta_produto_venda_categoriac(txt_nome_v.Text);
                                }


                            }
                            break;

                        case "Preço Jogo":
                            if (rb_precojogo_maior.Checked == true)
                            {
                                dt.DataSource = cproduto.consulta_produto_venda_preco_jogod();
                            }
                            else
                            {
                                dt.DataSource = cproduto.consulta_produto_venda_preco_jogoa();
                            }
                            break;
                        case "Marca":
                            if (txt_nome_v.Text == "")
                            {
                                MessageBox.Show("Favor Informar um Nome", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                if (rb_nomei_v.Checked == true)
                                {
                                    dt.DataSource = cproduto.consulta_produto_venda_marcai(txt_nome_v.Text);
                                }
                                else
                                {
                                    dt.DataSource = cproduto.consulta_produto_venda_marcac(txt_nome_v.Text);
                                }

                            }
                            break;

                        case "Preço Periférico":
                            if (rb_precojogo_maior.Checked == true)
                            {
                                dt.DataSource = cproduto.consulta_produto_venda_preco_perifericod();
                            }
                            else
                            {
                                dt.DataSource = cproduto.consulta_produto_venda_preco_perifericoa();
                            }
                            break;
                        case "Data Lançamento":
                            if (msk_data_i.Text == "" && msk_data_f.Text == "")
                            {
                                MessageBox.Show("Favor Informar uma Data", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                dt.DataSource = cproduto.consulta_venda_data(Convert.ToInt32(msk_data_i.Text), Convert.ToInt32(msk_data_f.Text));
                            }
                            break;

                    }
                }
                else
                {
                    //instanciar a classe produto para usar os métodos de consulta

                    class_produto c_produto_locacao = new class_produto();

                    //criar uma variável para receber a opção escolhida pelo usuário na combo

                    string consulta_locacao = cmb_consulta.SelectedItem.ToString();

                    switch (consulta_locacao)
                    {
                        // locação
                        //Nome 0
                        //Status 1
                        //Preço Diária  2
                        //Desenvolvedor 3
                        //Data Lançamento 4  
                        //plataforma 5
                        //locação 6


                        case "Nome":
                            if (txt_nomedev.Text == "")
                            {
                                MessageBox.Show("Favor Informar um Nome", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                if (rb_nomei_l.Checked == true)
                                {
                                    dt.DataSource = c_produto_locacao.consulta_locacao_nomei(txt_nomedev.Text);
                                }
                                else
                                {
                                    dt.DataSource = c_produto_locacao.consulta_locacao_nomec(txt_nomedev.Text);
                                }


                            }
                            break;
                        case "Status":
                            if (rb_statusatv_l.Checked == true)
                            {
                                dt.DataSource = c_produto_locacao.consulta_locacao_status(1);

                            }
                            else
                            {
                                dt.DataSource = c_produto_locacao.consulta_locacao_status(0);
                            }
                            break;
                        case "Preço Diária":
                            if (rb_precomaior_l.Checked == true)
                            {
                                dt.DataSource = c_produto_locacao.consulta_locacao_preco_diariad();
                            }
                            else
                            {
                                dt.DataSource = c_produto_locacao.consulta_locacao_preco_diariaa();
                            }
                            break;
                        case "Desenvolvedor":
                            if (txt_nomedev.Text == "")
                            {
                                MessageBox.Show("Favor Informar um Nome", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                if (rb_nomei_l.Checked == true)
                                {
                                    dt.DataSource = c_produto_locacao.consulta_locacao_desenvolvedori(txt_nomedev.Text);
                                }
                                else
                                {
                                    dt.DataSource = c_produto_locacao.consulta_locacao_desenvolvedorc(txt_nomedev.Text);
                                }
                            }
                            break;


                        case "Plataforma":
                            if (txt_nomedev.Text == "")
                            {
                                MessageBox.Show("Favor Informar um nome", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                if (rb_nomei_l.Checked == true)
                                {
                                    dt.DataSource = c_produto_locacao.consulta_locacao_plataformai(txt_nomedev.Text);
                                }
                                else
                                {
                                    dt.DataSource = c_produto_locacao.consulta_locacao_plataformac(txt_nomedev.Text);
                                }

                            }
                            break;
                        case "Data Lançamento":
                            if (msk_data_lancamento_inicio.Text == "" && msk_data_lancamento_fim.Text == "")
                            {
                                MessageBox.Show("Favor Informar uma Data", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                dt.DataSource = c_produto_locacao.consulta_locacao_data(Convert.ToInt32(msk_data_lancamento_inicio.Text), Convert.ToInt32(msk_data_lancamento_fim.Text));
                            }
                            break;
                        case "Locação":
                            if (ck_alugado.Checked == true)
                            {
                                dt.DataSource = c_produto_locacao.consulta_locacao_alugado(0);

                            }
                            else
                            {
                                dt.DataSource = c_produto_locacao.consulta_locacao_alugado(1);
                            }
                            break;

                    }




                }
            }
            else
            {
                MessageBox.Show("Favor selecionar Venda ou Locação", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

           

            

        
       

        private void bt_editar_Click(object sender, EventArgs e)
        {         
                if (MessageBox.Show("Deseja alterar o Produto Selecionado?", "Cat InfoGames", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //instanciar a classe produto para usar os metodos e propriedaddes
                    class_produto cproduto = new class_produto();
                    //instanciar o formulario de cadastro/atualização de produto para usar os constroles do form
                    form_produto fproduto = new form_produto();
                    //pegar o codigo do produto selecionado pelo usuario na grid
                    cproduto.consulta_produto(Convert.ToInt32(dt.SelectedRows[0].Cells[0].Value));
                    //passar os dados do BD para os controles do form de produto
                    fproduto.txt_cod_produto.Text = cproduto.cod_produto.ToString();
                    fproduto.txt_nome_produto.Text = cproduto.nome.ToString();
                    fproduto.txt_preco_diaria.Text = cproduto.preco_diaria.ToString();
                    fproduto.txt_especificacoes.Text = cproduto.especificacoes.ToString();
                    fproduto.txt_sinopse.Text = cproduto.sinopse.ToString();
                    fproduto.txt_quantidade.Text = cproduto.quantidade.ToString();
                    fproduto.txt_faixa_etaria.Text = cproduto.faixa_etaria.ToString();
                    fproduto.txt_preco_custo.Text = cproduto.preco_custo.ToString();
                    fproduto.txt_observacao.Text = cproduto.observacao.ToString();
                    fproduto.txt_preco_venda.Text = cproduto.preco_venda.ToString();
                    fproduto.msk_data_lancamento.Text = cproduto.data_lancamento.ToString();
                    fproduto.datacad = cproduto.data_cadastro;
                    fproduto.txt_desenvolvedor.Text = cproduto.desenvolvedor.ToString();
                    fproduto.tipo = cproduto.tipo.ToString();
                    fproduto.txt_lucro.Text = cproduto.lucro.ToString();
                    fproduto.genero = cproduto.cod_genero;
                    fproduto.plataforma = cproduto.cod_plataforma;
                    fproduto.marca = cproduto.cod_marca;
                    fproduto.categoria = cproduto.cod_categoria;

                    if (cproduto.status == 1)
                    {
                        fproduto.ck_produto.Checked = true;
                    }
                    else
                    {
                        fproduto.ck_produto.Checked = false;
                    }

                    // mandar a informação de update
                    fproduto.tipo_consulta = "Atualização";
                    // abrir o formulario de cadastro em modo exclusivo
                    fproduto.ShowDialog();
                    // chamar o método de pesquisa
                    bt_pesquisar_Click(this, new EventArgs());
                }

        }

        private void msk_data_i_MouseUp(object sender, MouseEventArgs e)
        {
            if (msk_data_i.Text == "    ")
            {
                SendKeys.Send("{HOME}");
            }
            
            
        }

        private void msk_data_f_MouseUp(object sender, MouseEventArgs e)
        {
            if (msk_data_f.Text == "    ")
            {
                SendKeys.Send("{HOME}");
            }
                
        }

        private void msk_data_lancamento_inicio_MouseUp(object sender, MouseEventArgs e)
        {
            if (msk_data_lancamento_inicio.Text == "    ")
            {
                SendKeys.Send("{HOME}");
            }
                
        }

        private void msk_data_lancamento_fim_MouseUp(object sender, MouseEventArgs e)
        {
            if (msk_data_lancamento_fim.Text == "    ")
            {
                SendKeys.Send("{HOME}");
            }
                
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dt_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            bt_editar.Enabled = true;
        }
    }
}
