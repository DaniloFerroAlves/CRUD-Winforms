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
    public partial class form_report : Form
    {
        public form_report()
        {
            InitializeComponent();
        }




        private void rb_marca_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_marca.Checked == true)
            {
                reportv_marca.Visible = true;
            }
            else
            {
                reportv_marca.Visible = false;
            }
        }

        private void rb_genero_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_genero.Checked == true)
            {
                reportv_genero.Visible = true;
            }
            else
            {
                reportv_genero.Visible = false;
            }
        }

        private void rb_categoria_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_categoria.Checked == true)
            {
                reportv_categoria.Visible = true;
            }
            else
            {
                reportv_categoria.Visible = false;
            }
        }

        private void rb_plataforma_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_plataforma.Checked == true)
            {
                reportv_plataforma.Visible = true;
            }
            else
            {
                reportv_plataforma.Visible = false;
            }
        }

        private void bt_gerar_relatorio_Click(object sender, EventArgs e)
        {
           if(rb_categoria.Checked == true || rb_genero.Checked == true || rb_marca.Checked == true || rb_plataforma.Checked == true)
            {
                if (rb_marca.Checked == true)
                {
                    class_marca cmarca = new class_marca();
                    class_marcaBindingSource.DataSource = cmarca.realatorio_marca();
                    this.reportv_marca.RefreshReport();
                }
                else if (rb_genero.Checked == true)
                {
                    class_genero cgenero = new class_genero();
                    class_generoBindingSource.DataSource = cgenero.realatorio_genero();
                    this.reportv_genero.RefreshReport();
                }
                else if (rb_categoria.Checked == true)
                {
                    class_categoria ccategoria = new class_categoria();
                    class_categoriaBindingSource.DataSource = ccategoria.realatorio_categoria();
                    this.reportv_categoria.RefreshReport();
                }
                else
                {
                    class_plataforma cplataforma = new class_plataforma();
                    class_plataformaBindingSource.DataSource = cplataforma.realatorio_plataforma();
                    this.reportv_plataforma.RefreshReport();
                }

           }
           else
            {
                MessageBox.Show("Favor selecionar tipo de Relatório", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            


        }

        private void form_report_Load(object sender, EventArgs e)
        {


        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
