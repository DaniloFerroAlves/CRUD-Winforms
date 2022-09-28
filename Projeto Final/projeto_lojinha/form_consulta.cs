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
    public partial class form_consulta : Form
    {
        public form_consulta()
        {
            InitializeComponent();
        }



        public string rbmarca;

        

        private void form_consulta_Load(object sender, EventArgs e)
        {
            cmb_tipo.Items.Add("Nome");
            cmb_tipo.Items.Add("Status");
            rb_categoria.Checked = false; 
        }

        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tipo.SelectedIndex == 0)
            {
                gb_status.Enabled = false;
                gb_nome.Enabled = true;
                rb_inicio.Checked = true;
            }
            else
            {
                gb_status.Enabled = true;
                gb_nome.Enabled = false;
                rb_ativo.Checked = true;
            }
        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            if (rb_categoria.Checked == true)
            {
                class_categoria ccategoria = new class_categoria();

                string consulta_categoria = cmb_tipo.SelectedItem.ToString();


                switch (consulta_categoria)
                {
                    case "Nome":
                        if (txt_nome.Text == "")
                        {
                            MessageBox.Show("Favor Informar um Nome", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            if (rb_inicio.Checked == true)
                            {
                                dt.DataSource = ccategoria.consulta_categoria_nomei(txt_nome.Text);

                            }
                            else
                            {
                                dt.DataSource = ccategoria.consulta_categoria_nomec(txt_nome.Text);

                            }


                        }

                        break;
                    case "Status":
                        gb_status.Enabled = true;
                        gb_nome.Enabled = false;
                        if (rb_ativo.Checked == true)
                        {
                            dt.DataSource = ccategoria.consulta_categoria_status(1);

                        }
                        else
                        {
                            dt.DataSource = ccategoria.consulta_categoria_status(0);

                        }
                        break;

                }




            }
            else if (rb_plataforma.Checked == true)
            {
                class_plataforma cplataforma = new class_plataforma();

                string consulta_plataforma = cmb_tipo.SelectedItem.ToString();

                switch (consulta_plataforma)
                {
                    case "Nome":
                        if (rb_inicio.Checked == true)
                        {
                            dt.DataSource = cplataforma.consulta_plataforma_nomei(txt_nome.Text);

                        }
                        else
                        {
                            dt.DataSource = cplataforma.consulta_plataforma_nomec(txt_nome.Text);

                        }
                        break;

                    case "Status":
                        if (rb_ativo.Checked == true)
                        {
                            dt.DataSource = cplataforma.consulta_plataforma_status(1);

                        }
                        else
                        {
                            dt.DataSource = cplataforma.consulta_plataforma_status(0);

                        }
                        break;

                }

            }
            else if (rb_genero.Checked == true)
            {
                class_genero cgenero = new class_genero();

                string consulta_genero = cmb_tipo.SelectedItem.ToString();

                switch (consulta_genero)
                {
                    case "Nome":
                        if (rb_inicio.Checked == true)
                        {
                            dt.DataSource = cgenero.consulta_genero_nomei(txt_nome.Text);


                        }
                        else
                        {
                            dt.DataSource = cgenero.consulta_genero_nomec(txt_nome.Text);


                        }
                        break;
                    case "Status":
                        if (rb_ativo.Checked == true)
                        {

                            dt.DataSource = cgenero.consulta_genero_status(1);


                        }
                        else
                        {
                            dt.DataSource = cgenero.consulta_genero_status(0);


                        }
                        break;


                }



            }
            else
            {
                class_marca cmarca = new class_marca();

                string consulta_marca = cmb_tipo.SelectedItem.ToString();

                switch (consulta_marca)
                {
                    case "Nome":
                        if (rb_inicio.Checked == true)
                        {
                            dt.DataSource = cmarca.consulta_marca_nomei(txt_nome.Text);

                        }
                        else
                        {
                            dt.DataSource = cmarca.consulta_marca_nomec(txt_nome.Text);

                        }
                        break;

                    case "Status":
                        if (rb_ativo.Checked == true)
                        {
                            dt.DataSource = cmarca.consulta_marca_status(1);

                        }
                        else
                        {
                            dt.DataSource = cmarca.consulta_marca_status(0);

                        }
                        break;

                }





            }
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            if (rb_marca.Checked == true)
            {
                if (MessageBox.Show("Deseja alterar a Marca Selecionada?", "Cat InfoGames", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    class_marca cmarca = new class_marca();
                    form_cadastro fcadastro = new form_cadastro();

                    cmarca.consulta_marca(Convert.ToInt32(dt.SelectedRows[0].Cells[0].Value));

                    fcadastro.txt_cod_cad.Text = cmarca.cod_marca.ToString();
                    fcadastro.txt_nome.Text = cmarca.nome.ToString();
                    fcadastro.datacad = cmarca.data_cadastro;
                    if (cmarca.status == 1)
                    {
                        fcadastro.ck_status.Checked = true;
                    }
                    else
                    {
                        fcadastro.ck_status.Checked = false;
                    }
                    fcadastro.tipo = "Atualização Marca";
                    fcadastro.ShowDialog();
                    bt_pesquisar_Click(this, new EventArgs());
                }
                 

            }
            else if (rb_genero.Checked == true)
            {
                if (MessageBox.Show("Deseja alterar o Gênero Selecionado?", "Cat InfoGames", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    class_genero cgenero = new class_genero();
                    form_cadastro fcadastro = new form_cadastro();

                    cgenero.consulta_genero(Convert.ToInt32(dt.SelectedRows[0].Cells[0].Value));

                    fcadastro.txt_cod_cad.Text = cgenero.cod_genero.ToString();
                    fcadastro.txt_nome.Text = cgenero.nome.ToString();
                    fcadastro.datacad = cgenero.data_cadastro;

                    if (cgenero.status == 1)
                    {
                        fcadastro.ck_status.Checked = true;
                    }
                    else
                    {
                        fcadastro.ck_status.Checked = false;
                    }
                    fcadastro.tipo = "Atualização Gênero";
                    fcadastro.ShowDialog();
                    bt_pesquisar_Click(this, new EventArgs());
                }

            }
            else if (rb_categoria.Checked == true)
            {
                if (MessageBox.Show("Deseja alterar a Categoria Selecionada?", "Cat InfoGames", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    class_categoria ccategoria = new class_categoria();
                    form_cadastro fcadastro = new form_cadastro();

                    ccategoria.consulta_categoria(Convert.ToInt32(dt.SelectedRows[0].Cells[0].Value));

                    fcadastro.txt_cod_cad.Text = ccategoria.cod_categoria.ToString();
                    fcadastro.txt_nome.Text = ccategoria.nome.ToString();
                    fcadastro.datacad = ccategoria.data_cadastro;
                    if (ccategoria.status == 1)
                    {
                        fcadastro.ck_status.Checked = true;
                    }
                    else
                    {
                        fcadastro.ck_status.Checked = false;
                    }
                    fcadastro.tipo = "Atualização Categoria";
                    fcadastro.ShowDialog();
                    bt_pesquisar_Click(this, new EventArgs());
                }

            }
            else
            {
                if (MessageBox.Show("Deseja alterar a Plataforma Selecionada?", "Cat InfoGames", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    class_plataforma cplataforma = new class_plataforma();
                    form_cadastro fcadastro = new form_cadastro();

                    cplataforma.consulta_plataforma(Convert.ToInt32(dt.SelectedRows[0].Cells[0].Value));

                    fcadastro.txt_cod_cad.Text = cplataforma.cod_plataforma.ToString();
                    fcadastro.txt_nome.Text = cplataforma.nome.ToString();
                    fcadastro.datacad = cplataforma.data_cadastro;
                    if (cplataforma.status == 1)
                    {
                        fcadastro.ck_status.Checked = true;
                    }
                    else
                    {
                        fcadastro.ck_status.Checked = false;
                    }
                    fcadastro.tipo = "Atualização Plataforma";
                    fcadastro.ShowDialog();
                    bt_pesquisar_Click(this, new EventArgs());
                }

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
