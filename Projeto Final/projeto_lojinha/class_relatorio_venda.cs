using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace projeto_lojinha
{
    class class_relatorio_venda
    {
        public class_relatorio_venda()
        {

            // método construtor da venda
            cod_venda = 0;
            data_venda = DateTime.Now;
            total_venda = 0;
            desconto = 0;
            dinheiro = 0;
            pix = 0;
            cartao_credito = 0;
            cartao_debito = 0;
            cod_funcionario = 0;
            cod_cliente = 0;

            
            //método construtor do produto venda
            cod_venda_produto = 0;
            cod_produto = 0;
            preco = 0;
            quantidade = 0;

        }


        public int cod_venda { get; set; }
        public DateTime data_venda { get; set; }
        public decimal total_venda { get; set; }
        public decimal desconto { get; set; }
        public decimal dinheiro { get; set; }
        public decimal pix { get; set; }
        public decimal cartao_credito { get; set; }
        public decimal cartao_debito { get; set; }
        public int cod_funcionario { get; set; }
        public int cod_cliente { get; set; }

        public int cod_venda_produto { get; set; }
        public int cod_produto { get; set; }
        public decimal preco { get; set; }
        public int quantidade { get; set; }

        //MÉTODO 
        public DataTable relatorio_venda_periodo(DateTime dinicio, DateTime dfinal)
        {
            string query = "SELECT venda.cod_venda, venda.data_venda, venda.total_venda, venda.desconto, venda.dinheiro, venda.pix, venda.cartao_credito, venda.cartao_debito, venda_produto.preco, venda_produto.quantidade, cliente.nome'cod_cliente', funcionario.nome'cod_funcionario', produto.nome'cod_produto' FROM cliente JOIN venda ON cliente.cod_cliente = venda.cod_cliente JOIN funcionario ON funcionario.cod_funcionario = venda.cod_funcionario JOIN venda_produto ON venda_produto.cod_venda = venda.cod_venda JOIN produto ON produto.cod_produto = venda_produto.cod_produto WHERE venda.data_venda BETWEEN '" + dinicio.ToString("yyyy-MM-dd") + "' AND '"+dfinal.ToString("yyyy-MM-dd")+"' ORDER BY venda.data_venda";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);


        }

        public DataTable relatorio_funcionario_venda(int mes)
        {
            string query = "SELECT venda.cod_venda , funcionario.nome'cod_funcionario', venda.total_venda FROM cliente JOIN venda ON cliente.cod_cliente = venda.cod_cliente JOIN funcionario ON funcionario.cod_funcionario = venda.cod_funcionario JOIN venda_produto ON venda_produto.cod_venda = venda.cod_venda JOIN produto ON produto.cod_produto = venda_produto.cod_produto WHERE month(venda.data_venda) = " + mes + "  ORDER BY venda.cod_venda ASC";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }


        //PRODUTO MAIS VENDIDO
        public DataTable relatorio_produto_mais_vendido(int mes)
        {
            string query = "SELECT venda.cod_venda , venda.total_venda, produto.nome'cod_produto'  FROM cliente JOIN venda ON cliente.cod_cliente = venda.cod_cliente JOIN funcionario ON funcionario.cod_funcionario = venda.cod_funcionario JOIN venda_produto ON venda_produto.cod_venda = venda.cod_venda JOIN produto ON produto.cod_produto = venda_produto.cod_produto WHERE month(venda.data_venda) = " + mes + " ORDER BY venda.cod_venda ASC";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        //CLIENTE 

        public DataTable relatorio_cliente_venda(int mes)
        {
            string query = "SELECT venda.cod_venda , cliente.nome'cod_cliente', venda.total_venda FROM cliente JOIN venda ON cliente.cod_cliente = venda.cod_cliente JOIN funcionario ON funcionario.cod_funcionario = venda.cod_funcionario JOIN venda_produto ON venda_produto.cod_venda = venda.cod_venda JOIN produto ON produto.cod_produto = venda_produto.cod_produto WHERE month(venda.data_venda) = " + mes + "   ORDER BY venda.total_venda ASC";
            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }



    }
}
