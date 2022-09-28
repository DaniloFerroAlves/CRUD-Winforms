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
    public partial class form_venda : Form
    {
        public form_venda()
        {
            InitializeComponent();
        }


        //VARIAVEL LISTA PRA SER USADA NA GRID DE ITENS VENDA
        private List<class_produto_venda> carrinho_compras = new List<class_produto_venda>();
        //VARIAVEL PRA CALCULAR O VALOR TOTAL DA VENDA
        private decimal venda_total = 0;
        //VARIAVEL PRA CONTAR QUANTOS ITENS TEM NO CARRINHO
        private decimal itens_carrinho = 0;

        //MÉTODO ATUALIZAR ITENS_CARRINHO
        private void atualizar_grid()
        {
            //INSTANCIAR CLASSE PRODUTO PRA PEGAR O MÉTODO QUE TRAZ SÓ O NOME DO PRODUTO
            class_produto cproduto = new class_produto();


            //CRIAR UMA TABELA TEMPORÁRIA(SERVE COMO BASE)
            DataTable dt = new DataTable();

            //CRIAR AS COLUNAS DA GRID
            dt.Columns.Add(new DataColumn("Código"));
            dt.Columns.Add(new DataColumn("Nome"));
            dt.Columns.Add(new DataColumn("Categoria"));
            dt.Columns.Add(new DataColumn("Quantidade"));
            dt.Columns.Add(new DataColumn("Valor"));

            //ADICIONAR LINHAS NA GRID

            foreach(class_produto_venda item in carrinho_compras)
            {
                dt.Rows.Add(item.cod_produto, cproduto.buscar_nome_produto(item.cod_produto), cproduto.buscar_nome_categoria(item.cod_produto), item.quantidade, item.preco);
                dt.AcceptChanges();
            }
            dt_itens.DataSource = dt;
        }




        private void cbFuncionario_DropDown(object sender, EventArgs e)
        {
            class_funcionario cfuncionario = new class_funcionario();
            cmb_funcionario.DataSource = cfuncionario.combo_funcionario();
            cmb_funcionario.DisplayMember = "nome";
            cmb_funcionario.ValueMember = "cod_funcionario";
            cmb_funcionario.SelectedIndex = -1;
        }

        private void btBuscaCliente_Click(object sender, EventArgs e)
        {
            class_cliente ccliente = new class_cliente();


            if (string.IsNullOrEmpty(txt_cliente.Text))
            {
                MessageBox.Show("Favor Informar o Nome de Cliente","Cat InfoGames",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                dt_cliente.DataSource = ccliente.buscar_cliente_venda(txt_cliente.Text);
            }


        }

        private void btBuscaProduto_Click(object sender, EventArgs e)
        {
            class_produto cproduto = new class_produto();

            if (string.IsNullOrEmpty(txt_produto.Text))
            {
                MessageBox.Show("Favor Informar o nome de um Produto", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dt_produto.DataSource = cproduto.buscar_produto_venda(txt_produto.Text);
            }

            
        }

        // calcular valor total do produto selecionado pelo usuario de acordo com a quantidade digitada
        private void txt_quantidade_TextChanged(object sender, EventArgs e)
        {
            if (txt_quantidade.Text == "")
            {
                MessageBox.Show("Favor informar uma Quantidade","Cat InfoGames",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txt_quantidade.Text = "01";
                txt_quantidade.SelectAll();
            }
            int quantidade = Convert.ToInt32(txt_quantidade.Text);
            int estoque = Convert.ToInt32(txt_estoque.Text);

            // verificar se a quantidade é maior que a quantidade em estoque
            if (quantidade > estoque)
            {
                MessageBox.Show("A quantidade disponível no estoque é de " + estoque + "unidades","Cat InfoGames",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txt_quantidade.Text = "01";
                txt_quantidade.SelectAll();
            }
            else
            {
                quantidade = Convert.ToInt32(txt_quantidade.Text);
                decimal valor = Convert.ToDecimal(txt_valor.Text);
                txt_total.Text = (quantidade * valor).ToString();
            }


        }

        private void dt_produto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            class_produto cproduto = new class_produto();

            bool resp = cproduto.consulta_produto(Convert.ToInt32(dt_produto.SelectedRows[0].Cells[0].Value));

            if (resp)
            {
                txt_nome_produto.Text = cproduto.nome;
                txt_estoque.Text = cproduto.quantidade.ToString();
                txt_valor.Text = cproduto.preco_venda.ToString("n2");
                txt_quantidade.Text = "01";
                txt_quantidade_TextChanged(this, new EventArgs());
                txt_quantidade.Select();
            }

        }

        private void txtValorDesconto_TextChanged(object sender, EventArgs e)
        {
            if(txt_valor_desconto.Text == "")
            {
                txt_valor_desconto.Text = "0";
                txt_valor_desconto.Select();

                


            }
            
            if(txt_valor_desconto.Text != "0")
            {
                decimal valort = Convert.ToDecimal(txt_valor_total.Text);
                decimal desconto = Convert.ToDecimal(txt_valor_desconto.Text);
                decimal r = valort - (valort * desconto / 100); 
                decimal t = (valort * desconto / 100);
                txt_total_venda.Text = r.ToString("n2");
                txt_total_desconto.Text = t.ToString("n2");

            }
            else
            {
                txt_total_venda.Text = txt_valor_total.Text;
                decimal desconto = Convert.ToDecimal(txt_valor_desconto.Text);
                decimal valort = Convert.ToDecimal(txt_valor_total.Text);
                decimal r = valort * desconto;
                txt_total_desconto.Text = r.ToString();

            }
        }

        private void btAddProduto_Click(object sender, EventArgs e)
        {
            class_produto_venda cprodutovenda = new class_produto_venda();
            //SOMAR VALOR DO ITEM AO VALOR TOTAL DA VENDA
            decimal valor_item = 0;

            //VERIFICAR SE ALGUM PRODUTO FOI SELECIONADO
            if(txt_total.Text == "")
            {
                MessageBox.Show("Não há produto para ser inserido", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //SOMA VALOR DO ITEM SELECIONADO AO TOTAL DA VENDA
                valor_item = Convert.ToDecimal(txt_total.Text);
                venda_total = venda_total + valor_item;
                txt_valor_total.Text = venda_total.ToString("n2");

                //CONTAR ITENS DA VENDA (QUANTIDADE DE LINHAS DA GRID)
                itens_carrinho++;

                //INFORMAÇÕES DOS PRODUTOS VENDIDOS
                cprodutovenda.cod_produto = Convert.ToInt32(dt_produto.SelectedRows[0].Cells[0].Value);
                cprodutovenda.quantidade = Convert.ToInt32(txt_quantidade.Text);
                cprodutovenda.preco = Convert.ToDecimal(txt_total.Text);

                //ADICIONAR NA LISTA
                carrinho_compras.Add(cprodutovenda);

                //PEGAR DA LISTA A QUANTIDADE DE ITENS
                txt_quantidade_itens.Text = cprodutovenda.ToString();
                txt_quantidade_itens.Text = carrinho_compras.Count.ToString();

                //CHAMAR MÉTODO QUE CRIA A GRID DE PRODUTOS VENDIDOS
                atualizar_grid();

                //LIMPAR OS CAMPOS DE PRODUTO APÓS ADICIONAR
                txt_nome_produto.Clear();
                txt_quantidade.Text = "01";
                txt_valor.Clear();
                txt_total.Clear();
                txt_estoque.Clear();
                txt_valor_desconto.Text = "0";
                txtValorDesconto_TextChanged(this, new EventArgs());




            }
        }

        //MÉTODO ATUALIZAR ESTOQUE(FAZER CONTA PRA EXCLUIR DO ESTOQUE)
        private void calcula_estoque(int quantia, int cod)
        {
            class_produto cproduto = new class_produto();
            cproduto.consulta_produto(cod);
            int estoque = cproduto.quantidade;
            cproduto.update_quantidade(estoque - quantia, cod);
        }

        //MÉTODO LIMPAR - CHAMADO QUANDO VENDA FINALIZADA

        private void limpar()
        {
            cmb_funcionario.SelectedIndex = -1;
            txt_cliente.Clear();
            dt_cliente.DataSource = null;
            txt_produto.Clear();
            dt_produto.DataSource = null;
            
            carrinho_compras.Clear();
            atualizar_grid();
            dt_itens.Refresh();

            txt_valor_total.Text = "0";
            txt_total_venda.Text = "0";
            txt_valor_desconto.Text = "0";
            txt_total_desconto.Text = "0";

            txt_quantidade_itens.Clear();
            txt_pix.Clear();
            txt_dinheiro.Clear();
            txt_debito.Clear();
            txt_credito.Clear();
            venda_total = 0;




        }

        private void btRemoveProduto_Click(object sender, EventArgs e)
        {
            if(dt_itens.Rows.Count > 0)
            {
                if(MessageBox.Show("Deseja Remover o Produto Selecionado?","Cat InfoGames", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //RECALCULAR TOTAL DA VENDA
                    //PEGAR O VALOR DO ITEM SELECIONADO PELO USUARIO
                    decimal valor = Convert.ToDecimal(dt_itens.SelectedRows[0].Cells[4].Value);
                    venda_total = venda_total - valor;
                    txt_total_venda.Text = venda_total.ToString();
                    txt_valor_total.Text = venda_total.ToString();

                    //REMOVER O ITEM SELECIONADO DA LISTA E ATUALIZAR GRID
                    carrinho_compras.RemoveAt(dt_itens.CurrentRow.Index);
                    atualizar_grid();

                    //RECONTAR A LISTA DE PRODUTOS VENDIDOS
                    txt_quantidade_itens.Text = carrinho_compras.Count.ToString();
                    txtValorDesconto_TextChanged(this, new EventArgs());


                }
            }
            else
            {
                MessageBox.Show("Não há produtos para ser removido", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_fecha_venda_Click(object sender, EventArgs e)
        {
            //VERIFICAR CAMPOS OBRIGATÓRIOS

            if(cmb_funcionario.SelectedIndex != -1 && dt_cliente.DataSource != null && dt_itens.DataSource != null && (txt_credito.Text != "0" || txt_debito.Text != "0" || txt_dinheiro.Text != "0" || txt_pix.Text != "0"))
            {
                class_venda cvenda = new class_venda();

                //MANDAR INFORMAÇÕES DA TABELA VENDA
                cvenda.total_venda = Convert.ToDecimal(txt_total_venda.Text);
                cvenda.desconto = Convert.ToDecimal(txt_total_desconto.Text);
                cvenda.cod_cliente = Convert.ToInt32(dt_cliente.SelectedRows[0].Cells[0].Value);
                cvenda.cod_funcionario = Convert.ToInt32(cmb_funcionario.SelectedValue);
                cvenda.cartao_credito = Convert.ToDecimal(txt_credito.Text);
                cvenda.cartao_debito = Convert.ToDecimal(txt_debito.Text);
                cvenda.pix = Convert.ToDecimal(txt_pix.Text);
                cvenda.dinheiro = Convert.ToDecimal(txt_dinheiro.Text);

                //VERIFICAÇÃO DE CAIXAS DE TIPO DE PAGAMENTO

                decimal dinheiro = Convert.ToDecimal(txt_dinheiro.Text);
                decimal credito = Convert.ToDecimal(txt_credito.Text);
                decimal debito = Convert.ToDecimal(txt_debito.Text);
                decimal pix = Convert.ToDecimal(txt_pix.Text);
                decimal totalv = Convert.ToDecimal(txt_total_venda.Text);
                

                decimal vtotal = dinheiro + credito + debito + pix;

                if(totalv == vtotal)
                {
                    bool resp = cvenda.cadastro_venda();

                    if (resp == true)
                    {
                        foreach (class_produto_venda item in carrinho_compras)
                        {
                            item.cod_venda = cvenda.cod_venda;
                            resp = item.cadastro_produto_venda();

                            calcula_estoque(item.quantidade, item.cod_produto);
                        }
                        if (resp == true)
                        {
                            MessageBox.Show("Venda realiza com Sucesso", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpar();
                        }




                    }
                    else
                    {
                        MessageBox.Show("Erro ao realizar Venda", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Valor inserido na(s) forma(s) de pagamento não corresponde ao valor total da compra", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }




            }
            else
            {
                MessageBox.Show("Favor preencher todos campos", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
