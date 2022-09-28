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
    public partial class form_produto : Form
    {
        public form_produto()
        {
            InitializeComponent();
        }

        //variavel TIPO: guardar como o formulario deve ser aberto se para cadastro atualização ou exclusão
        //variavel ESTADO: informação é mostrada em uma combo
        public string tipo;
        public string tipo_consulta;
        public int categoria, plataforma, marca, genero;
        //variavel DATACAD: mostrar informaçao guardada no banco de dados e nao data atual como programado no load do form
        public DateTime datacad;

        private void limpar()
        {
            txt_desenvolvedor.Clear();
            txt_especificacoes.Clear();
            txt_faixa_etaria.Clear();
            txt_lucro.Clear();
            txt_nome_produto.Clear();
            txt_observacao.Clear();
            txt_preco_custo.Clear();
            txt_preco_diaria.Clear();
            txt_preco_venda.Clear();
            txt_quantidade.Clear();
            txt_sinopse.Clear();
            msk_data_lancamento.Clear();
            cmb_categoria.SelectedIndex = -1;
            cmb_genero.SelectedIndex = -1;
            cmb_marca.SelectedIndex = -1;
            cmb_plataforma.SelectedIndex = -1;
            cmb_tipo.SelectedIndex = -1;
        }

        private void form_produto_Load(object sender, EventArgs e)
        {
            lb_data_cad.Text = DateTime.Now.ToShortDateString();

            //COMBO TIPO
            cmb_tipo.Items.Add("Venda"); // 0
            cmb_tipo.Items.Add("Locação"); // 1
            cmb_tipo.SelectedIndex = -1;

            //COMBO MARCA


            // combo categoria é carregada direto no evento load da combo

            class_marca cmarca = new class_marca();

            cmb_marca.DataSource = cmarca.buscar_marca();

            cmb_marca.DisplayMember = "nome";
            cmb_marca.ValueMember = "cod_marca";
            cmb_marca.SelectedIndex = -1;

            //COMBO PLATAFORMA

            class_plataforma cplataforma = new class_plataforma();

            cmb_plataforma.DataSource = cplataforma.buscar_plataforma();
            cmb_plataforma.DisplayMember = "nome";
            cmb_plataforma.ValueMember = "cod_plataforma";
            cmb_plataforma.SelectedIndex = -1;

            //COMBO GÊNERO

            class_genero cgenero = new class_genero();
            cmb_genero.DataSource = cgenero.buscar_genero();
            cmb_genero.DisplayMember = "nome";
            cmb_genero.ValueMember = "cod_genero";
            cmb_genero.SelectedIndex = -1;


            if (tipo_consulta == "Atualização")
            {
                lb_titulo.Text = "Atualização Produto";
                painel_att.Enabled = true;
                painel_att.Visible = true;
                bt_cadastrar.Enabled = false;
                ck_produto.Enabled = true;
                bt_delete.Enabled = true;
                bt_update.Enabled = true;

                cmb_genero.SelectedValue = genero;
                cmb_marca.SelectedValue = marca;
                cmb_plataforma.SelectedValue = plataforma;
                cmb_tipo.SelectedItem = tipo;

                if (cmb_tipo.SelectedIndex == 0)
                {
                    cmb_categoria.SelectedValue = categoria;
                }
                else
                {
                    cmb_categoria.SelectedValue = categoria;
                    panel_alugado.Visible = true;
                }
                

                lb_data_cad.Text = datacad.ToString(); ;


            }
            else
            {
                ck_produto.Enabled = false;
                bt_delete.Enabled = false;
                bt_update.Enabled = false;
                painel_att.Enabled = false;
                painel_att.Visible = false;
            }


        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cmb_categoria.SelectedIndex == 0)
            {
                group_jogo.Enabled = true;
                cmb_marca.Enabled = false;
            }
            else
            {
                group_jogo.Enabled = false;
                cmb_marca.Enabled = true;
            }

        }

        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tipo.SelectedIndex == 0) // venda
            {
                lb_preco_custo.Enabled = true;
                lb_preco_venda.Enabled = false;
                lb_lucro.Enabled = true;
                lb_quantidade.Enabled = true;
                lb_especificacao.Enabled = true;

                txt_quantidade.Enabled = true;
                txt_quantidade.BackColor = Color.White;
                txt_preco_custo.Enabled = true;
                txt_preco_custo.BackColor = Color.White;
                txt_preco_diaria.Enabled = false;
                txt_preco_diaria.BackColor = Color.LightGray;
                txt_lucro.Enabled = true;
                txt_lucro.BackColor = Color.White;
                txt_preco_venda.Enabled = false;
                txt_preco_venda.BackColor = Color.White;
                txt_quantidade.Enabled = true;
                txt_quantidade.BackColor = Color.White;
                txt_especificacoes.Enabled = true;
                txt_especificacoes.BackColor = Color.White;

                lb_preco_diaria.Enabled = false;
                txt_preco_diaria.Enabled = false;

                class_categoria ccategoria = new class_categoria();
                cmb_categoria.DataSource = ccategoria.buscar_categoria();

                cmb_categoria.DisplayMember = "nome";
                cmb_categoria.ValueMember = "cod_categoria";
                cmb_categoria.SelectedIndex = -1;

                if (tipo_consulta == "Atualização")
                {
                    cmb_categoria.SelectedValue = categoria;
                }


            }
            else //locação
            {

                lb_preco_custo.Enabled = false;
                lb_preco_venda.Enabled = false;
                lb_lucro.Enabled = false;
                lb_quantidade.Enabled = true;
                lb_especificacao.Enabled = false;

                txt_quantidade.Enabled = false;
                txt_quantidade.BackColor = Color.LightGray;
                txt_lucro.Enabled = false;
                txt_lucro.BackColor = Color.LightGray;
                txt_preco_venda.Enabled = false;
                txt_preco_venda.BackColor = Color.LightGray;
                txt_preco_diaria.Enabled = true;
                txt_preco_diaria.BackColor = Color.White;
                txt_preco_custo.Enabled = false;
                txt_preco_custo.BackColor = Color.LightGray;
                txt_quantidade.Enabled = false;
                txt_quantidade.BackColor = Color.LightGray;
                txt_especificacoes.Enabled = false;
                txt_especificacoes.BackColor = Color.LightGray;
                lb_preco_diaria.Enabled = true;
                txt_preco_diaria.Enabled = true;

                class_categoria ccategoria = new class_categoria();

                cmb_categoria.DataSource = ccategoria.buscar_jogo();

                cmb_categoria.DisplayMember = "nome";
                cmb_categoria.ValueMember = "cod_categoria";
                cmb_categoria.SelectedIndex = -1;
            }

        }





        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //categoria
        {
            form_cadastro fcadastro = new form_cadastro();
            fcadastro.rb_categoriac.Checked = true;
            fcadastro.rb_generoc.Enabled = false;
            fcadastro.rb_marcac.Enabled = false;
            fcadastro.rb_plataformac.Enabled = false;
            fcadastro.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //marca
        {
            form_cadastro fcadastro = new form_cadastro();
            fcadastro.rb_marcac.Checked = true;
            fcadastro.rb_generoc.Enabled = false;
            fcadastro.rb_categoriac.Enabled = false;
            fcadastro.rb_plataformac.Enabled = false;
            fcadastro.Show();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //genero

        {
            form_cadastro fcadastro = new form_cadastro();
            fcadastro.rb_generoc.Checked = true;
            fcadastro.rb_categoriac.Enabled = false;
            fcadastro.rb_marcac.Enabled = false;
            fcadastro.rb_plataformac.Enabled = false;
            fcadastro.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //plataforma
        {
            form_cadastro fcadastro = new form_cadastro();
            fcadastro.rb_plataformac.Checked = true;
            fcadastro.rb_generoc.Enabled = false;
            fcadastro.rb_marcac.Enabled = false;
            fcadastro.rb_categoriac.Enabled = false;
            fcadastro.Show();
        }

        private void cmb_plataforma_Click(object sender, EventArgs e)
        {
            class_plataforma cplataforma = new class_plataforma();
            cmb_plataforma.DataSource = cplataforma.buscar_plataforma();
            cmb_plataforma.DisplayMember = "nome";
            cmb_plataforma.ValueMember = "cod_plataforma";
            cmb_plataforma.SelectedIndex = -1;
        }

        private void cmb_categoria_Click(object sender, EventArgs e)
        {
            if (cmb_tipo.SelectedIndex == 0) // venda
            {
                class_categoria ccategoria = new class_categoria();
                cmb_categoria.DataSource = ccategoria.buscar_categoria();
                cmb_categoria.DisplayMember = "nome";
                cmb_categoria.ValueMember = "cod_categoria";
                cmb_categoria.SelectedIndex = -1;

            }
            else
            {
                class_categoria ccategoria = new class_categoria();
                cmb_categoria.DataSource = ccategoria.buscar_jogo();
                cmb_categoria.DisplayMember = "nome";
                cmb_categoria.ValueMember = "cod_categoria";
                cmb_categoria.SelectedIndex = -1;
            }



        }

        private void cmb_genero_Click(object sender, EventArgs e)
        {
            class_genero cgenero = new class_genero();
            cmb_genero.DataSource = cgenero.buscar_genero();
            cmb_genero.DisplayMember = "nome";
            cmb_genero.ValueMember = "cod_genero";
            cmb_genero.SelectedIndex = -1;
        }

        private void cmb_marca_Click(object sender, EventArgs e)
        {
            class_marca cmarca = new class_marca();
            cmb_marca.DataSource = cmarca.buscar_marca();
            cmb_marca.DisplayMember = "nome";
            cmb_marca.ValueMember = "cod_marca";
            cmb_marca.SelectedIndex = -1;
        }

        private void link_categoria_MouseHover(object sender, EventArgs e)
        {
            link_categoria.VisitedLinkColor = Color.Blue;
            link_categoria.LinkColor = Color.Blue;
        }
        private void link_categoria_MouseLeave(object sender, EventArgs e)
        {
            link_categoria.VisitedLinkColor = Color.Black;
            link_categoria.LinkColor = Color.Black;
        }


        private void link_marca_MouseHover(object sender, EventArgs e)
        {
            link_marca.LinkColor = Color.Blue;
        }

        private void link_marca_MouseLeave(object sender, EventArgs e)
        {
            link_marca.LinkColor = Color.Black;
        }


        private void link_genero_MouseHover(object sender, EventArgs e)
        {
            link_genero.LinkColor = Color.Blue;
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            class_produto cproduto = new class_produto();

            if (cmb_tipo.SelectedIndex == 0) // venda
            {
                cproduto.preco_venda = Convert.ToDecimal(txt_preco_venda.Text);
                cproduto.preco_custo = Convert.ToDecimal(txt_preco_custo.Text);
                cproduto.lucro = Convert.ToInt32(txt_lucro.Text);
                cproduto.quantidade = Convert.ToInt32(txt_quantidade.Text);
            }
            if (cmb_tipo.SelectedIndex == 1) // locação
            {
                cproduto.preco_diaria = Convert.ToDecimal(txt_preco_diaria.Text);
            }
            if (cmb_categoria.SelectedIndex == 0) // jogo
            {
                cproduto.faixa_etaria = txt_faixa_etaria.Text;
            }
            else
            {
                txt_faixa_etaria.Text = null;
            }
            cproduto.nome = txt_nome_produto.Text;
            cproduto.especificacoes = txt_especificacoes.Text;
            cproduto.sinopse = txt_sinopse.Text;
            cproduto.observacao = txt_observacao.Text;
            cproduto.data_lancamento = Convert.ToDateTime(msk_data_lancamento.Text);
            cproduto.desenvolvedor = txt_desenvolvedor.Text;
            cproduto.tipo = Convert.ToString(cmb_tipo.SelectedItem.ToString());
            cproduto.cod_categoria = Convert.ToInt32(cmb_categoria.SelectedValue);

            if (cmb_categoria.SelectedIndex == 0) // jogo
            {
                cproduto.cod_plataforma = Convert.ToInt32(cmb_plataforma.SelectedValue);
                cproduto.cod_genero = Convert.ToInt32(cmb_genero.SelectedValue);

            }
            else // locação
            {
                cproduto.cod_marca = Convert.ToInt32(cmb_marca.SelectedValue);
            }

            if (ck_produto.Checked == true)
            {
                cproduto.status = 1;
            }
            else
            {
                cproduto.status = 0;
            }
            if(ck_alugado.Checked == true)
            {
                cproduto.alugado = 0;
            }
            else
            {
                cproduto.alugado = 1;
            }

            cproduto.cod_produto = Convert.ToInt32(txt_cod_produto.Text);

            bool resp = cproduto.update_produto();

            //EXEBIR MENSAGEM DE UPDATE REALIZADO 
            if (resp)
            {
                MessageBox.Show("Produto: " + cproduto.nome + " Atualizado com Sucesso", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                limpar();
            }
            else
            {
                MessageBox.Show("Erro ao Realizar a Atualização.", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o Produto?", "Cat InfoGames", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                class_produto cproduto = new class_produto();
                cproduto.cod_produto = Convert.ToInt32(txt_cod_produto.Text);

                bool resp = cproduto.delete_produto();

                if (resp == true)
                {
                    MessageBox.Show("Produto excluido com sucesso", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este Produto não pode ser excluido, há registros em outras tabelas.", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }


        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            if (cmb_tipo.SelectedIndex == -1)
            {
                MessageBox.Show("Favor escolher um Tipo", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (cmb_tipo.SelectedIndex == 0) // venda
                {

                    if (cmb_categoria.SelectedIndex == -1) //combo jogo ou perifericos e tals
                    {
                        MessageBox.Show("Favor escolher uma Categoria", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        if (cmb_categoria.SelectedIndex == 0) // jogo
                        {
                            if (txt_nome_produto.Text != "" && msk_data_lancamento.Text != "  /  /" && txt_desenvolvedor.Text != "" && txt_faixa_etaria.Text != "" && txt_sinopse.Text != "" && txt_preco_venda.Text != "" && txt_preco_custo.Text != "" && txt_lucro.Text != "" && txt_quantidade.Text != "")
                            {
                                if (cmb_genero.SelectedIndex == -1 && cmb_plataforma.SelectedIndex == -1)
                                {
                                    MessageBox.Show("Favor selecionar um Gênero e uma Plataforma", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else
                                {
                                    if (cmb_plataforma.SelectedIndex == -1)
                                    {
                                        MessageBox.Show("Favor selecionar um Gênero e uma Plataforma", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    }
                                    else
                                    {
                                        class_produto cproduto = new class_produto();

                                        cproduto.preco_venda = Convert.ToDecimal(txt_preco_venda.Text);
                                        cproduto.preco_custo = Convert.ToDecimal(txt_preco_custo.Text);
                                        cproduto.lucro = Convert.ToInt32(txt_lucro.Text);
                                        cproduto.quantidade = Convert.ToInt32(txt_quantidade.Text);
                                        cproduto.preco_diaria = 0;
                                        cproduto.faixa_etaria = txt_faixa_etaria.Text;
                                        cproduto.nome = txt_nome_produto.Text;
                                        cproduto.especificacoes = txt_especificacoes.Text;
                                        cproduto.sinopse = txt_sinopse.Text;
                                        cproduto.observacao = txt_observacao.Text;



                                        if (msk_data_lancamento.Text == "  /  /")
                                        {
                                            MessageBox.Show("Favor preencher com uma data de lançamento", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        }
                                        else
                                        {
                                            cproduto.data_lancamento = Convert.ToDateTime(msk_data_lancamento.Text);
                                        }
                                        cproduto.desenvolvedor = txt_desenvolvedor.Text;
                                        cproduto.tipo = Convert.ToString(cmb_tipo.SelectedItem.ToString());
                                        cproduto.cod_categoria = Convert.ToInt32(cmb_categoria.SelectedValue);
                                        cproduto.cod_plataforma = Convert.ToInt32(cmb_plataforma.SelectedValue);
                                        cproduto.cod_genero = Convert.ToInt32(cmb_genero.SelectedValue);
                                        cproduto.cod_marca = 1;

                                        int resp = cproduto.cadastro_produto();

                                        //EXEBIR MENSAGEM DE CADASTRO REALIZADO 
                                        if (resp == 1)
                                        {
                                            MessageBox.Show("Produto: " + cproduto.nome + " Cadastrado com Sucesso!!", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            limpar();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Erro ao Realizar o cadastro.", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }

                                    }





                                }
                            }
                            else
                            {
                                MessageBox.Show("Favor preencher os campos obrigatórios", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }

                        }
                        else // periféricos 
                        {
                            if (txt_nome_produto.Text != "" && txt_especificacoes.Text != "" && txt_preco_venda.Text != "" && txt_preco_custo.Text != "" && txt_lucro.Text != "" && txt_quantidade.Text != "" && txt_preco_venda.Text != "" && txt_preco_custo.Text != "" && txt_lucro.Text != "" && txt_quantidade.Text != "")
                            {
                                class_produto cproduto = new class_produto();
                                cproduto.preco_diaria = 0;

                                if (cmb_marca.SelectedIndex == -1)
                                {
                                    MessageBox.Show("Favor escolher uma marca", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else
                                {
                                    cproduto.preco_venda = Convert.ToDecimal(txt_preco_venda.Text);
                                    cproduto.preco_custo = Convert.ToDecimal(txt_preco_custo.Text);
                                    cproduto.lucro = Convert.ToInt32(txt_lucro.Text);
                                    cproduto.quantidade = Convert.ToInt32(txt_quantidade.Text);
                                    txt_faixa_etaria.Text = null;
                                    cproduto.nome = txt_nome_produto.Text;
                                    cproduto.especificacoes = txt_especificacoes.Text;
                                    cproduto.sinopse = txt_sinopse.Text;
                                    cproduto.observacao = txt_observacao.Text;
                                    cproduto.data_lancamento = Convert.ToDateTime("1900/01/01");
                                    txt_desenvolvedor.Text = null;
                                    cproduto.tipo = Convert.ToString(cmb_tipo.SelectedItem.ToString());
                                    cproduto.cod_categoria = Convert.ToInt32(cmb_categoria.SelectedValue);
                                    cproduto.cod_plataforma = 1;
                                    cproduto.cod_genero = 1;
                                    cproduto.cod_marca = Convert.ToInt32(cmb_marca.SelectedValue);
                                    int resp = cproduto.cadastro_produto();

                                    //EXEBIR MENSAGEM DE CADASTRO REALIZADO 
                                    if (resp == 1)
                                    {
                                        MessageBox.Show("Produto: " + cproduto.nome + " Cadastrado com Sucesso!!", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        limpar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Erro ao Realizar o cadastro.", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }



                            }
                            else
                            {
                                MessageBox.Show("Favor preencher os campos obrigatórios", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }

                        }

                    }
                }
                else // locação
                {
                    if (cmb_categoria.SelectedIndex == -1)
                    {
                        MessageBox.Show("Favor escolher uma Categoria", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        if (txt_nome_produto.Text != "" && msk_data_lancamento.Text != "" && txt_desenvolvedor.Text != "" && txt_faixa_etaria.Text != "" && txt_sinopse.Text != "" && txt_preco_diaria.Text != "")
                        {
                            class_produto cproduto = new class_produto();
                            cproduto.preco_diaria = Convert.ToDecimal(txt_preco_diaria.Text);
                            if (cmb_genero.SelectedIndex == -1 && cmb_plataforma.SelectedIndex == -1)
                            {
                                MessageBox.Show("Favor selecionar um Gênero e uma Plataforma", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            else
                            {
                                if (cmb_plataforma.SelectedIndex == -1)
                                {
                                    MessageBox.Show("Favor selecionar um Gênero e uma Plataforma", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else
                                {

                                    cproduto.preco_custo = 0;
                                    cproduto.preco_venda = 0;
                                    cproduto.lucro = 0;
                                    cproduto.quantidade = 1;
                                    cproduto.faixa_etaria = txt_faixa_etaria.Text;
                                    cproduto.nome = txt_nome_produto.Text;
                                    cproduto.especificacoes = txt_especificacoes.Text;
                                    cproduto.sinopse = txt_sinopse.Text;
                                    cproduto.observacao = txt_observacao.Text;
                                    if (msk_data_lancamento.Text == "  /  /")
                                    {
                                        MessageBox.Show("Favor preencher com uma data de lançamento", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    }
                                    else
                                    {
                                        cproduto.data_lancamento = Convert.ToDateTime(msk_data_lancamento.Text);
                                    }
                                    cproduto.desenvolvedor = txt_desenvolvedor.Text;
                                    cproduto.tipo = Convert.ToString(cmb_tipo.SelectedItem.ToString());
                                    cproduto.cod_categoria = Convert.ToInt32(cmb_categoria.SelectedValue);
                                    cproduto.cod_plataforma = Convert.ToInt32(cmb_plataforma.SelectedValue);
                                    cproduto.cod_genero = Convert.ToInt32(cmb_genero.SelectedValue);
                                    cproduto.cod_marca = 1;
                                    int resp = cproduto.cadastro_produto();

                                    //EXEBIR MENSAGEM DE CADASTRO REALIZADO 
                                    if (resp == 1)
                                    {
                                        MessageBox.Show("Produto: " + cproduto.nome + " Cadastrado com Sucesso!!", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        limpar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Erro ao Realizar o cadastro.", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                }




                            }

                        }
                        else
                        {
                            MessageBox.Show("Favor preencher os campos obrigatórios", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }




                    }



                }

            }
        }

        private void msk_data_lancamento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Preencha com uma data válida", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_data_lancamento.Clear();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_especificacoes_MouseDown(object sender, MouseEventArgs e)
        {
            panel_especifi.BackColor = Color.LawnGreen;
        }

        private void txt_especificacoes_Leave(object sender, EventArgs e)
        {
            panel_especifi.BackColor = Color.DimGray;
        }



        private void txt_sinopse_MouseDown(object sender, MouseEventArgs e)
        {
            panel_sinopse.BackColor = Color.LawnGreen;
        }

        private void txt_sinopse_Leave(object sender, EventArgs e)
        {
            panel_sinopse.BackColor = Color.DimGray;
        }

        private void txt_preco_custo_MouseDown(object sender, MouseEventArgs e)
        {
            panel_custo.BackColor = Color.LawnGreen;
        }

        private void txt_preco_custo_Leave(object sender, EventArgs e)
        {
            panel_custo.BackColor = Color.DimGray;
        }

        private void txt_lucro_MouseDown(object sender, MouseEventArgs e)
        {
            panel_lucro.BackColor = Color.LawnGreen;
        }

        private void txt_lucro_Leave(object sender, EventArgs e)
        {
            panel_lucro.BackColor = Color.DimGray;
        }

        private void txt_nome_produto_MouseDown(object sender, MouseEventArgs e)
        {
            panel_nome.BackColor = Color.LawnGreen;
        }

        private void txt_nome_produto_Leave(object sender, EventArgs e)
        {
            panel_nome.BackColor = Color.DimGray;
        }

        private void txt_faixa_etaria_MouseDown(object sender, MouseEventArgs e)
        {
            panel_faixa.BackColor = Color.LawnGreen;
        }

        private void txt_faixa_etaria_Leave(object sender, EventArgs e)
        {
            panel_faixa.BackColor = Color.DimGray;
        }

        private void txt_desenvolvedor_Leave(object sender, EventArgs e)
        {
            panel_desenvolvedor.BackColor = Color.DimGray;
        }

        private void txt_desenvolvedor_MouseDown(object sender, MouseEventArgs e)
        {
            panel_desenvolvedor.BackColor = Color.LawnGreen;
        }

        private void txt_preco_diaria_MouseDown(object sender, MouseEventArgs e)
        {
            panel_diaria.BackColor = Color.LawnGreen;
        }

        private void txt_preco_diaria_Leave(object sender, EventArgs e)
        {
            panel_diaria.BackColor = Color.DimGray;
        }

        private void txt_quantidade_MouseDown(object sender, MouseEventArgs e)
        {
            panel_qntia.BackColor = Color.LawnGreen;
        }

        private void txt_quantidade_Leave(object sender, EventArgs e)
        {
            panel_qntia.BackColor = Color.DimGray;
        }

        private void txt_lucro_TextChanged(object sender, EventArgs e)
        {

            
            
            if (txt_preco_custo.Text != "")
            {
                if (txt_lucro.Text != "")
                {
 
                    decimal lucro = Convert.ToDecimal(txt_lucro.Text);
                    decimal preco = Convert.ToDecimal(txt_preco_custo.Text);
                    decimal precof = (lucro * preco / 100) + preco;
                    txt_preco_venda.Text = precof.ToString();

                }

            }
            else
            {
                txt_lucro.Text = "0";
                txt_lucro.SelectAll();
            }




            if(txt_lucro.Text == "")
            {
                txt_lucro.Text = "0";
                txt_lucro.SelectAll();

                
                if(txt_preco_custo.Text != "")
                {
                    decimal preco = Convert.ToDecimal(txt_preco_custo.Text);
                    txt_preco_venda.Text = (preco).ToString();
                }

            }


        }

        private void txt_preco_custo_TextChanged(object sender, EventArgs e)
        {
            if (txt_preco_custo.Text != "")
            {

                decimal preco = Convert.ToDecimal(txt_preco_custo.Text);
                txt_preco_venda.Text = (preco).ToString();


            }
            if(txt_preco_custo.Text == "" )
            {
                
                txt_preco_venda.Clear();
                txt_lucro.Clear();
            }







        }

        private void msk_data_lancamento_Enter(object sender, EventArgs e)
        {
            if (msk_data_lancamento.Text == "  /  /")
            {
                SendKeys.Send("{HOME}");
            }
        }

        private void link_genero_MouseLeave(object sender, EventArgs e)
        {
            link_genero.LinkColor = Color.Black;
        }


        private void link_plataforma_MouseHover(object sender, EventArgs e)
        {
            link_plataforma.LinkColor = Color.Blue;
        }

        private void link_plataforma_MouseLeave(object sender, EventArgs e)
        {
            link_plataforma.LinkColor = Color.Black;
        }


    }
}
