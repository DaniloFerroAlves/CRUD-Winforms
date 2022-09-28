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
    public partial class form_locacao : Form
    {
        public form_locacao()
        {
            InitializeComponent();
        }

        //VARIAVEL LISTA PRA SER USADA NA GRID DE ITENS VENDA
        private List<class_locacao_produto> carrinho_compras = new List<class_locacao_produto>();
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
            dt.Columns.Add(new DataColumn("Diária"));

            //ADICIONAR LINHAS NA GRID

            foreach (class_locacao_produto item in carrinho_compras)
            {
                dt.Rows.Add(item.cod_produto, cproduto.buscar_nome_produto(item.cod_produto), cproduto.buscar_nome_categoria(item.cod_produto), item.quantidade, item.preco);
                dt.AcceptChanges();
            }
            dt_itens.DataSource = dt;
        }



        private void cmb_funcionario_DropDown(object sender, EventArgs e)
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
                MessageBox.Show("Favor Informar o Nome de Cliente", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dt_cliente.DataSource = ccliente.buscar_cliente_venda(txt_cliente.Text);
            }
        }

        private void btBuscaProduto_Click(object sender, EventArgs e) //locação
        {
            class_locacao clocacao = new class_locacao();

            if (string.IsNullOrEmpty(txt_produto.Text))
            {
                MessageBox.Show("Favor Informar o nome de um Produto", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dt_produto.DataSource = clocacao.buscar_produto_locacao(txt_produto.Text);
            }
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dt_produto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            class_produto cproduto = new class_produto();

            bool resp = cproduto.consulta_produto(Convert.ToInt32(dt_produto.SelectedRows[0].Cells[0].Value));

            if (resp)
            {
                txt_nome_produto.Text = cproduto.nome;
                txt_estoque.Text = cproduto.quantidade.ToString();
                txt_valor_diaria.Text = cproduto.preco_diaria.ToString("n2");
                txt_quantidade.Text = "01";
                //txt_dias.Text = "01";
                txt_quantidade_TextChanged(this, new EventArgs());
                txt_quantidade.Select();
            }
        }

        private void txt_quantidade_TextChanged(object sender, EventArgs e)
        {
            if (txt_quantidade.Text == "")
            {
                MessageBox.Show("Favor informar uma Quantidade", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_quantidade.Text = "01";
                txt_quantidade.SelectAll();
            }
            int quantidade = Convert.ToInt32(txt_quantidade.Text);
            int estoque = Convert.ToInt32(txt_estoque.Text);

            // verificar se a quantidade é maior que a quantidade em estoque
            if (quantidade > estoque)
            {
                MessageBox.Show("A quantidade disponível no estoque é de " + estoque + "unidades", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_quantidade.Text = "01";
                txt_quantidade.SelectAll();
            }
            else
            {
                quantidade = Convert.ToInt32(txt_quantidade.Text);
                decimal valor = Convert.ToDecimal(txt_valor_diaria.Text);
                txt_total_diaria.Text = (quantidade * valor).ToString();
            }
        }

        private void btAddProduto_Click(object sender, EventArgs e)
        {
            class_locacao_produto cprodutolocacao = new class_locacao_produto();
            //SOMAR VALOR DO ITEM AO VALOR TOTAL DA VENDA
            decimal valor_item = 0;

            //VERIFICAR SE ALGUM PRODUTO FOI SELECIONADO
            if (txt_total_diaria.Text == "")
            {
                MessageBox.Show("Não há produto para ser inserido", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //SOMA VALOR DO ITEM SELECIONADO AO TOTAL DA VENDA
                valor_item = Convert.ToDecimal(txt_total_diaria.Text);
                venda_total = venda_total + valor_item;
                txt_valor_total.Text = venda_total.ToString("n2");

                //CONTAR ITENS DA VENDA (QUANTIDADE DE LINHAS DA GRID)
                itens_carrinho++;

                //INFORMAÇÕES DOS PRODUTOS VENDIDOS
                cprodutolocacao.cod_produto = Convert.ToInt32(dt_produto.SelectedRows[0].Cells[0].Value);
                cprodutolocacao.quantidade = Convert.ToInt32(txt_quantidade.Text);
                cprodutolocacao.preco = Convert.ToDecimal(txt_total_diaria.Text);

                //ADICIONAR NA LISTA
                carrinho_compras.Add(cprodutolocacao);

                //PEGAR DA LISTA A QUANTIDADE DE ITENS
                txt_quantidade_itens.Text = cprodutolocacao.ToString();
                txt_quantidade_itens.Text = carrinho_compras.Count.ToString();

                //CHAMAR MÉTODO QUE CRIA A GRID DE PRODUTOS VENDIDOS
                atualizar_grid();

                //LIMPAR OS CAMPOS DE PRODUTO APÓS ADICIONAR
                txt_nome_produto.Clear();
                txt_quantidade.Text = "01";
                txt_dias.Text = "01";
                txt_valor_diaria.Clear();
                txt_total_diaria.Clear();
                txt_estoque.Clear();
                
            }
        }

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
            txt_valor_diaria.Text = "0";
            txt_dias.Text = "0";
            venda_total = 0;


            txt_quantidade_itens.Clear();
            txt_pix.Clear();
            txt_dinheiro.Clear();
            txt_debito.Clear();
            txt_credito.Clear();
        }

        private void bt_fecha_venda_Click(object sender, EventArgs e)
        {
            //VERIFICAR CAMPOS OBRIGATÓRIOS

            if (cmb_funcionario.SelectedIndex != -1 && dt_cliente.DataSource != null && dt_itens.DataSource != null && (txt_credito.Text != "0" || txt_debito.Text != "0" || txt_dinheiro.Text != "0" || txt_pix.Text != "0"))
            {
                class_locacao clocacao = new class_locacao();

                //MANDAR INFORMAÇÕES DA TABELA VENDA
                clocacao.valor_total = Convert.ToDecimal(txt_total_venda.Text);
                clocacao.cod_cliente = Convert.ToInt32(dt_cliente.SelectedRows[0].Cells[0].Value);
                clocacao.cod_funcionario = Convert.ToInt32(cmb_funcionario.SelectedValue);
                clocacao.cartao_credito = Convert.ToDecimal(txt_credito.Text);
                clocacao.cartao_debito = Convert.ToDecimal(txt_debito.Text);
                clocacao.pix = Convert.ToDecimal(txt_pix.Text);
                clocacao.dinheiro = Convert.ToDecimal(txt_dinheiro.Text);
                clocacao.data_devolucao = Convert.ToInt32(txt_dias.Text);

                //VERIFICAÇÃO DE CAIXAS DE TIPO DE PAGAMENTO
                decimal dinheiro = Convert.ToDecimal(txt_dinheiro.Text);
                decimal credito = Convert.ToDecimal(txt_credito.Text);
                decimal debito = Convert.ToDecimal(txt_debito.Text);
                decimal pix = Convert.ToDecimal(txt_pix.Text);
                decimal totalv = Convert.ToDecimal(txt_valor_total.Text);


                decimal vtotal = dinheiro + credito + debito + pix;

                if (totalv == vtotal)
                {
                    bool resp = clocacao.cadastro_locacao();

                    if (resp == true)
                    {
                        foreach (class_locacao_produto item in carrinho_compras)
                        {
                            item.cod_locacao = clocacao.cod_locacao;
                            resp = item.cadastro_locacao_produto();

                            aluga_produto(item.quantidade, item.cod_produto);
                        }
                        if (resp == true)
                        {
                            MessageBox.Show("Locação realiza com Sucesso", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpar();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Erro ao realizar Locação", "Cat InfoGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void aluga_produto(int quantia, int cod)
        {
            class_produto cproduto = new class_produto();
            cproduto.consulta_produto(cod);
            cproduto.alugar_produto(cod);
        }

        private void txt_valor_total_TextChanged(object sender, EventArgs e)
        {            
            txt_total_venda.Text = txt_valor_total.Text;           
        }

        private void form_locacao_Load(object sender, EventArgs e)
        {
            

        }
        private void txt_dias_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_dias.Text != null && txt_valor_diaria.Text != null)
            {
                decimal diaria = Convert.ToDecimal(txt_valor_diaria.Text);
                int dias = Convert.ToInt32(txt_dias.Text);
                txt_total_diaria.Text = (diaria * dias).ToString();
                //btAddProduto.Enabled = true;

            }
            else
            {
                txt_dias.Text = "01";
                txt_valor_diaria.Text = "0";
                txt_dias.SelectAll();
            }
                
        }
    }
}

