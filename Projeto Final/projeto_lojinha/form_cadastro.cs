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
    public partial class form_cadastro : Form
    {
        public form_cadastro()
        {
            InitializeComponent();
        }


        public void limpar()
        {
            txt_nome.Clear();

        }
        public string tipo;
        public DateTime datacad;

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            if (rb_marcac.Checked == false && rb_generoc.Checked == false && rb_categoriac.Checked == false && rb_plataformac.Checked == false)
            {
                MessageBox.Show("Favor escolher um tipo de Cadastro", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (rb_marcac.Checked == true)
                {
                    if (txt_nome.Text == "")
                    {
                        MessageBox.Show("Favor preencher o Campo.", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        class_marca cmarca = new class_marca();

                        cmarca.nome = txt_nome.Text;

                        int resp = cmarca.cadastro_marca();

                        if (resp == 1)
                        {
                            MessageBox.Show("Marca: " + cmarca.nome + " Cadastrado com Sucesso", "Lojinha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpar();


                        }
                        else
                        {
                            MessageBox.Show("Erro ao Realizar o cadastro", "Lojinha", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }

                }
                else if (rb_generoc.Checked == true)
                {
                    if (txt_nome.Text == "")
                    {
                        MessageBox.Show("Favor preencher o Campo.", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        class_genero cgenero = new class_genero();

                        cgenero.nome = txt_nome.Text;

                        int resp = cgenero.cadastro_genero();

                        if (resp == 1)
                        {
                            MessageBox.Show(cgenero.nome + " Cadastrado com Sucesso", "Lojinha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpar();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao Realizar o cadastro", "Lojinha", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }

                }
                else if (rb_categoriac.Checked == true)
                {
                    if (txt_nome.Text == "")
                    {
                        MessageBox.Show("Favor preencher o Campo.", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        class_categoria ccategoria = new class_categoria();

                        ccategoria.nome = txt_nome.Text;

                        int resp = ccategoria.cadastro_categoria();

                        if (resp == 1)
                        {
                            MessageBox.Show(ccategoria.nome + " Cadastrado com Sucesso", "Lojinha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpar();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao Realizar o cadastro", "Lojinha", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }

                }
                else
                {
                    if (txt_nome.Text == "")
                    {
                        MessageBox.Show("Favor preencher o Campo.", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        class_plataforma cplataforma = new class_plataforma();

                        cplataforma.nome = txt_nome.Text;

                        int resp = cplataforma.cadastro_plataforma();

                        if (resp == 1)
                        {
                            MessageBox.Show(cplataforma.nome + " Cadastrada com Sucesso", "Lojinha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpar();

                        }
                        else
                        {
                            MessageBox.Show("Erro ao Realizar o cadastro", "Lojinha", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                }
            }



            
        }

        public string rb;



       

        private void bt_update_Click(object sender, EventArgs e)
        {
            if (rb_marcac.Checked == true)
            {
                rb_marcac.Checked = true;
                rb_categoriac.Enabled = false;
                rb_generoc.Enabled = false;
                rb_plataformac.Enabled = false;

                class_marca cmarca = new class_marca();

                cmarca.nome = txt_nome.Text;
                
                if (ck_status.Checked == true)
                {
                    cmarca.status = 1;
                }
                else
                {
                    cmarca.status = 0;
                }

                cmarca.cod_marca = Convert.ToInt32(txt_cod_cad.Text);
                bool resp = cmarca.update_marca();

                if (resp)
                {
                    MessageBox.Show("Marca: " + cmarca.nome + " Atualizada com Sucesso", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao Realizar a Atualização.", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else if (rb_generoc.Checked == true)
            {
                class_genero cgenero = new class_genero();

                cgenero.nome = txt_nome.Text;
                
                if (ck_status.Checked == true)
                {
                    cgenero.status = 1;
                }
                else
                {
                    cgenero.status = 0;
                }

                cgenero.cod_genero = Convert.ToInt32(txt_cod_cad.Text);
                bool resp = cgenero.update_genero();

                if (resp)
                {
                    MessageBox.Show("Gênero: " + cgenero.nome + " Atualizado com Sucesso", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao Realizar a Atualização.", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_categoriac.Checked == true)
            {

                class_categoria ccategoria = new class_categoria();

                ccategoria.nome = txt_nome.Text;
                
                if (ck_status.Checked == true)
                {
                    ccategoria.status = 1;
                }
                else
                {
                    ccategoria.status = 0;
                }

                ccategoria.cod_categoria = Convert.ToInt32(txt_cod_cad.Text);
                bool resp = ccategoria.update_categoria();

                if (resp)
                {
                    MessageBox.Show("Categoria: " + ccategoria.nome + " Atualizada com Sucesso", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    limpar();


                }
                else
                {
                    MessageBox.Show("Erro ao Realizar a Atualização.", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                        

            }
            else
            {
                class_plataforma cplataforma = new class_plataforma();

                cplataforma.nome = txt_nome.Text;
                
                if (ck_status.Checked == true)
                {
                    cplataforma.status = 1;
                }
                else
                {
                    cplataforma.status = 0;
                }
                cplataforma.cod_plataforma = Convert.ToInt32(txt_cod_cad.Text);

                bool resp = cplataforma.update_plataforma();

                if (resp)
                {
                    MessageBox.Show("Plataforma: " + cplataforma.nome + " Atualizada com Sucesso", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    limpar();

                }
                else
                {
                    MessageBox.Show("Erro ao Realizar a Atualização.", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void form_cadastro_Load(object sender, EventArgs e)
        {
            if (tipo == "Atualização Marca")
            {
                rb_marcac.Checked = true;
                rb_generoc.Enabled = false;
                rb_categoriac.Enabled = false;
                rb_plataformac.Enabled = false;

                lb_titulo.Text = "ATUALIZAÇÃO MARCA";
                txt_cod_cad.Enabled = false;
                painel_att.Enabled = true;
                painel_att.Visible = true;
                ck_status.Enabled = true;
                bt_delete.Enabled = true;
                bt_update.Enabled = true;
                bt_cadastrar.Enabled = false;
               

                lb_data_cad.Text = datacad.ToString(); ;


            }
            else
            {
                ck_status.Enabled = false;
                bt_delete.Enabled = false;
                bt_update.Enabled = false;
                painel_att.Enabled = false;
                painel_att.Visible = false;
            }

            if (tipo == "Atualização Gênero")
            {
                rb_generoc.Checked = true;
                rb_marcac.Enabled = false;
                rb_categoriac.Enabled = false;
                rb_plataformac.Enabled = false;

                lb_titulo.Text = "ATUALIZAÇÃO GÊNERO";
                painel_att.Enabled = true;
                txt_cod_cad.Enabled = false;
                painel_att.Visible = true;
                ck_status.Enabled = true;
                bt_delete.Enabled = true;
                bt_update.Enabled = true;

                lb_data_cad.Text = datacad.ToString(); ;


            }


            if (tipo == "Atualização Categoria")
            {
                rb_categoriac.Checked = true;
                rb_marcac.Enabled = false;
                rb_generoc.Enabled = false;
                rb_plataformac.Enabled = false;

                lb_titulo.Text = "ATUALIZAÇÃO CATEGORIA";
                painel_att.Enabled = true;
                txt_cod_cad.Enabled = false;
                painel_att.Visible = true;
                ck_status.Enabled = true;
                bt_delete.Enabled = true;
                bt_update.Enabled = true;

                lb_data_cad.Text = datacad.ToString(); ;


            }


            if (tipo == "Atualização Plataforma")               
            {
                rb_plataformac.Checked = true;
                rb_marcac.Enabled = false;
                rb_generoc.Enabled = false;
                rb_categoriac.Enabled = false;
                

                lb_titulo.Text = "ATUALIZAÇÃO PLATAFORMA";
                painel_att.Enabled = true;

                painel_att.Visible = true;
                txt_cod_cad.Enabled = false;
                ck_status.Enabled = true;
                bt_delete.Enabled = true;
                bt_update.Enabled = true;

                lb_data_cad.Text = datacad.ToString(); ;


            }           

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (rb_marcac.Checked == true)
            {
                rb_marcac.Checked = true;
                rb_categoriac.Enabled = false;
                rb_generoc.Enabled = false;
                rb_plataformac.Enabled = false;

                class_marca cmarca = new class_marca();

                cmarca.nome = txt_nome.Text;
                cmarca.cod_marca = Convert.ToInt32(txt_cod_cad.Text);
                bool resp = cmarca.delete_marca();

                if (resp)
                {
                    MessageBox.Show("Marca: " + cmarca.nome + " Deletada com Sucesso", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    limpar();
                }
                else
                {
                    MessageBox.Show("Esta Marca não pode ser excluida, há registros em outras tabelas", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else if (rb_generoc.Checked == true)
            {
                class_genero cgenero = new class_genero();

                cgenero.nome = txt_nome.Text;
                cgenero.cod_genero = Convert.ToInt32(txt_cod_cad.Text);
                bool resp = cgenero.delete_genero();

                if (resp)
                {
                    MessageBox.Show("Gênero: " + cgenero.nome + " Deletado com Sucesso", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    limpar();
                }
                else
                {
                    MessageBox.Show("Este Gênero não pode ser excluido, há registros em outras tabelas.", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_categoriac.Checked == true)
            {

                class_categoria ccategoria = new class_categoria();

                ccategoria.nome = txt_nome.Text;             
                ccategoria.cod_categoria = Convert.ToInt32(txt_cod_cad.Text);
                bool resp = ccategoria.delete_categoria();

                if (resp)
                {
                    MessageBox.Show("Categoria: " + ccategoria.nome + " Deletada com Sucesso", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    limpar();


                }
                else
                {
                    MessageBox.Show("Esta Categoria não pode ser excluida, há registros em outras tabelas", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                class_plataforma cplataforma = new class_plataforma();

                cplataforma.nome = txt_nome.Text;

                cplataforma.cod_plataforma = Convert.ToInt32(txt_cod_cad.Text);

                bool resp = cplataforma.delete_plataforma();

                if (resp)
                {
                    MessageBox.Show("Plataforma: " + cplataforma.nome + " Atualizada com Sucesso", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    limpar();

                }
                else
                {
                    MessageBox.Show("Esta Plataforma não pode ser excluida, há registros em outras tabelas", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }






        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
