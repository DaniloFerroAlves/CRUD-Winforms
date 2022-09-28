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
    public partial class form_principal : Form
    {
        public form_principal()
        {
            InitializeComponent();
        }

        bool tick_menu, tick_produto, tick_funcionario, tick_cargo, tick_cliente, tick_subcat;











        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void form_principal_Load(object sender, EventArgs e)
        {
            timer_horario.Start();
        }

        private void button1_Click(object sender, EventArgs e) //BOTÃO MENU
        {
            timer.Start();
            timer.Interval = 10;


        }

        private void timer_Tick(object sender, EventArgs e)
        {


            if (tick_menu)
            {

                //painel_lateral.Width -= 10;
                painel_lateral.Height -= 10;

                // painel_lateral.Width == painel_lateral.MinimumSize.Width &&

                if (painel_lateral.Height == painel_lateral.MinimumSize.Height)
                {
                    tick_menu = false;
                    timer.Stop();


                }

            }
            else
            {
                // painel_lateral.Width += 10;
                painel_lateral.Height += 10;

                if (painel_lateral.Width == painel_lateral.MaximumSize.Width && painel_lateral.Height == painel_lateral.MaximumSize.Height)
                {
                    tick_menu = true;
                    timer.Stop();
                }





            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer.Start();
            timer.Interval = 10;
        }

        private void timer_produto_Tick(object sender, EventArgs e)
        {
            if (tick_produto)
            {

                // painel_produto.Width -= 10;
                painel_produto.Height -= 10;

                // painel_produto.Width == painel_produto.MinimumSize.Width &&

                if (painel_produto.Height == painel_produto.MinimumSize.Height)
                {
                    tick_produto = false;
                    timer_produto.Stop();

                }

            }
            else
            {
                //painel_produto.Width += 10;
                painel_produto.Height += 10;
                //painel_produto.Width == painel_produto.MaximumSize.Width &&
                if (painel_produto.Height == painel_produto.MaximumSize.Height)
                {
                    tick_produto = true;
                    timer_produto.Stop();

                }

            }
        }



        private void bt_cadastro_produto_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_produto>().Count() > 0)
            {
                MessageBox.Show("Cadastro Produto já está aberto", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                form_produto fproduto = new form_produto();
                //fproduto.MdiParent = this;
                fproduto.Show();
            }


        }

        private void bt_consulta_prod_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<form_consulta_produto>().Count() > 0)
            {
                MessageBox.Show("Consulta Produto já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                form_consulta_produto fconsulta_produto = new form_consulta_produto();
                // fconsulta_produto.MdiParent = this;

                fconsulta_produto.Show();


            }
        }


        private void timer_horario_Tick(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToLongTimeString();
            lb_data.Text = DateTime.Now.ToLongDateString();
        }













        private void bt_cadastro_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_cadastro>().Count() > 0)
            {
                MessageBox.Show("Cadastro SubCategoria já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                form_cadastro fcadastro = new form_cadastro();
                fcadastro.Show();
 
            }
        }


        private void bt_funcionario_Click(object sender, EventArgs e) //BT STARTAR BARRA VERTICAL
        {
            timer_funcionario.Start();
            timer_funcionario.Interval = 10;


        }

        private void bt_cadastro_funcionario_Click(object sender, EventArgs e) //FORMULARIO CADASTRO DE FUNC
        {
            if (Application.OpenForms.OfType<form_funcionario>().Count() > 0)
            {
                MessageBox.Show("Cadastro Funcionário ja está aberto", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                form_funcionario cfuncionario = new form_funcionario();
                cfuncionario.Show();
                button6_Click(this, new EventArgs());
            }

        }

        private void bt_cargo_Click(object sender, EventArgs e)
        {
            timer_cargo.Start();
            timer_cargo.Interval = 10;


        }

        private void timer_cliente_Tick(object sender, EventArgs e) //BARRA CLIENTE
        {
            if (tick_cliente)
            {

                // painel_produto.Width -= 10;
                painel_cliente.Height -= 10;

                // painel_produto.Width == painel_produto.MinimumSize.Width &&

                if (painel_cliente.Height == painel_cliente.MinimumSize.Height)
                {
                    tick_cliente = false;
                    timer_cliente.Stop();

                }

            }
            else
            {
                //painel_produto.Width += 10;
                painel_cliente.Height += 10;
                //painel_produto.Width == painel_produto.MaximumSize.Width &&
                if (painel_cliente.Height == painel_cliente.MaximumSize.Height)
                {
                    tick_cliente = true;
                    timer_cliente.Stop();
                }

            }
        }

        private void bt_cliente_Click(object sender, EventArgs e)
        {
            timer_cliente.Start();
            timer_cliente.Interval = 10;


        }

        private void bt_relatorio_prod_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_report_produto>().Count() > 0)
            {
                MessageBox.Show("Relatório Produto já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                form_report_produto rproduto = new form_report_produto();
                rproduto.Show();

            }


        }

        private void bt_subcategorias_Click(object sender, EventArgs e)
        {
            timer_subcategorias.Start();
            timer_subcategorias.Interval = 10;


        }

        private void bt_cadastro_cliente_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_cliente>().Count() > 0)
            {
                MessageBox.Show("Cadastro Cliente já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                form_cliente ccliente = new form_cliente();
                ccliente.Show();

            }

        }

        private void bt_consulta_cliente_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_consulta_cliente>().Count() > 0)
            {
                MessageBox.Show("Consulta Cliente já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                form_consulta_cliente ccliente = new form_consulta_cliente();
                ccliente.Show();

            }

        }

        private void bt_relatorio_cliente_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_report_cliente>().Count() > 0)
            {
                MessageBox.Show("Relatório Cliente já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                form_report_cliente rcliente = new form_report_cliente();
                rcliente.Show();

            }

        }

        private void bt_cadastro_cargo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_cargo>().Count() > 0)
            {
                MessageBox.Show("Cadastro Cargo já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                form_cargo ccargo = new form_cargo();
                ccargo.Show();

            }

        }

        private void bt_consulta_cargo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_consulta_cargo>().Count() > 0)
            {
                MessageBox.Show("Consulta Cargo já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                form_consulta_cargo ccargo = new form_consulta_cargo();
                ccargo.Show();

            }

        }

        private void bt_report_cargo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_report_cargo>().Count() > 0)
            {
                MessageBox.Show("Relatório Cargo já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                form_report_cargo rcargo = new form_report_cargo();
                rcargo.Show();

            }


        }

        private void bt_cadastro_subcate_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_cadastro>().Count() > 0)
            {
                MessageBox.Show("Subcategoria já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                form_cadastro fsubcate = new form_cadastro();
                fsubcate.Show();


            }
        }

        private void bt_consulta_subcate_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_consulta>().Count() > 0)
            {
                MessageBox.Show("Consulta Subcategoria já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                form_consulta csubcat = new form_consulta();
                csubcat.Show();

            }
        }

        private void bt_report_subcate_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_report>().Count() > 0)
            {
                MessageBox.Show("Relatório Subcategoria já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                form_report rsubcat = new form_report();
                rsubcat.Show();
 
            }
        }

        private void timer_subcategorias_Tick(object sender, EventArgs e)
        {
            if (tick_subcat)
            {

                // painel_produto.Width -= 10;
                painel_subcategorias.Height -= 10;

                // painel_produto.Width == painel_produto.MinimumSize.Width &&

                if (painel_subcategorias.Height == painel_subcategorias.MinimumSize.Height)
                {
                    tick_subcat = false;
                    timer_subcategorias.Stop();

                }

            }
            else
            {
                //painel_produto.Width += 10;
                painel_subcategorias.Height += 10;
                //painel_produto.Width == painel_produto.MaximumSize.Width &&
                if (painel_subcategorias.Height == painel_subcategorias.MaximumSize.Height)
                {
                    tick_subcat = true;
                    timer_subcategorias.Stop();
                }

            }
        }

        private void bt_venda_Click(object sender, EventArgs e)
        {
            form_venda fvenda = new form_venda();
            fvenda.Show();
            button6_Click(this, new EventArgs());
        }

        private void bt_locacao_Click(object sender, EventArgs e)
        {
            form_locacao flocacao = new form_locacao();
            flocacao.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form_report_venda rvenda = new form_report_venda();
            rvenda.Show();
        }

        private void bt_produto_Click(object sender, EventArgs e)
        {

                timer_produto.Start();
                timer_produto.Interval = 10;

        }

        private void bt_relatorio_funcionario_Click(object sender, EventArgs e) //FORM REPORT FUNC
        {
            if (Application.OpenForms.OfType<form_report_funcionario>().Count() > 0)
            {
                MessageBox.Show("Relatório Funcionário já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                form_report_funcionario rfuncionario = new form_report_funcionario();
                rfuncionario.Show();
                button6_Click(this, new EventArgs());
            }


        }

        private void timer_cargo_Tick(object sender, EventArgs e)
        {
            if (tick_cargo)
            {

                // painel_produto.Width -= 10;
                painel_cargo.Height -= 10;

                // painel_produto.Width == painel_produto.MinimumSize.Width &&

                if (painel_cargo.Height == painel_cargo.MinimumSize.Height)
                {
                    tick_cargo = false;
                    timer_cargo.Stop();

                }

            }
            else
            {
                //painel_produto.Width += 10;
                painel_cargo.Height += 10;
                //painel_produto.Width == painel_produto.MaximumSize.Width &&
                if (painel_cargo.Height == painel_cargo.MaximumSize.Height)
                {
                    tick_cargo = true;
                    timer_cargo.Stop();
                }

            }
        }

        private void bt_consulta_funcionario_Click(object sender, EventArgs e) //FORM CONSULTA FUNC
        {
            if (Application.OpenForms.OfType<form_consulta_funcionario>().Count() > 0)
            {
                MessageBox.Show("Consulta Funcionário já está aberto", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                form_consulta_funcionario cfuncionario = new form_consulta_funcionario();
                cfuncionario.Show();
                button6_Click(this, new EventArgs());
            }


        }



        //BARRA VERTICAL FUNCIONARIO
        private void timer_funcionario_Tick(object sender, EventArgs e)
        {
            if (tick_funcionario)
            {

                // painel_produto.Width -= 10;
                painel_funcionario.Height -= 10;

                // painel_produto.Width == painel_produto.MinimumSize.Width &&

                if (painel_funcionario.Height == painel_funcionario.MinimumSize.Height)
                {
                    tick_funcionario = false;
                    timer_funcionario.Stop();

                }

            }
            else
            {
                //painel_produto.Width += 10;
                painel_funcionario.Height += 10;
                //painel_produto.Width == painel_produto.MaximumSize.Width &&
                if (painel_funcionario.Height == painel_funcionario.MaximumSize.Height)
                {
                    tick_funcionario = true;
                    timer_funcionario.Stop();
                }

            }
        }



    }
}
