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
    public partial class form_consulta_cargo : Form
    {
        public form_consulta_cargo()
        {
            InitializeComponent();
        }

        private void form_consulta_cargo_Load(object sender, EventArgs e)
        {
            cb_consulta_por_cargo.Items.Add("Nome");
            cb_consulta_por_cargo.Items.Add("Status");
            cb_consulta_por_cargo.SelectedIndex = 0;
        }

        private void cb_consulta_por_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_consulta_por_cargo.SelectedIndex == 0)
            {
                gp_nome.Enabled = true;
                gp_status.Enabled = false;
                rb_ativo_cargo.Checked = false;
                rb_inicio_cargo.Checked = true;
            }
            else
            {
                gp_nome.Enabled = false;
                gp_status.Enabled = true;
                rb_ativo_cargo.Checked = true;
                rb_inicio_cargo.Checked = false;
            }
        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            //INSTANCIAR CLASSE PRA USAR OS MÉTODOS DE CONSULTA
            class_cargo ccargo = new class_cargo();
            string consulta = cb_consulta_por_cargo.SelectedItem.ToString();

            switch (consulta) //NOME INICIO E CONTEM
            {
                case "Nome":
                    if (txt_nome_cargo.Text != "")
                    {
                        if (rb_inicio_cargo.Checked == true)
                        {
                            dgv_consulta_cargo.DataSource = ccargo.consulta_cargo_nomei(txt_nome_cargo.Text);
                        }
                        else
                        {
                            dgv_consulta_cargo.DataSource = ccargo.consulta_cargo_nomec(txt_nome_cargo.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Favor preencher o campo vazio", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "Status":
                    {
                        if (rb_ativo_cargo.Checked == true)
                        {
                            dgv_consulta_cargo.DataSource = ccargo.consulta_cargo_status(1);
                        }
                        else
                        {
                            dgv_consulta_cargo.DataSource = ccargo.consulta_cargo_status(0);
                        }
                        break;
                    }
            }

        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja editar o cargo selecionado?", "Cat InfoGames", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //INSTANCIAR FORMS E CLASSE
                class_cargo ccargo = new class_cargo();
                form_cargo fcargo = new form_cargo();

                ccargo.consultar_cargo(Convert.ToInt32(dgv_consulta_cargo.SelectedRows[0].Cells[0].Value));

                fcargo.txt_codigo_cargo.Text = ccargo.cod_cargo.ToString();
                fcargo.txt_nome_cargo.Text = ccargo.nome.ToString();
                fcargo.datacad = ccargo.data_cadastro;
                
                if(ccargo.status == 1)
                {
                    fcargo.cb_status.Checked = true;
                }
                else
                {
                    fcargo.cb_status.Checked = false;
                }

                fcargo.tipo = "Atualização";

                fcargo.ShowDialog();

                bt_pesquisar_Click(this, new EventArgs());
            }
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
