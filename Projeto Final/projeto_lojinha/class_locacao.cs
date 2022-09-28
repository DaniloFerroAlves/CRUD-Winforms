using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace projeto_lojinha
{
    class class_locacao
    {
        public class_locacao()
        {
            cod_locacao = 0;
            data_retirada = DateTime.Now;
            data_devolucao = 0;
            dinheiro = 0;
            pix = 0;
            cartao_credito = 0;
            cartao_debito = 0;
            valor_total = 0;
            cod_cliente = 0;
            cod_funcionario = 0;

        }


        //PROPRIEDADES
        public  int cod_locacao { get; set; }

        public DateTime data_retirada { get; set; }

        public int data_devolucao { get; set; }

        public decimal dinheiro { get; set; }

        public  decimal pix { get; set; }

        public decimal cartao_credito { get; set; }

        public decimal cartao_debito { get; set; }

        public decimal valor_total { get; set; }

        public int cod_cliente { get; set; }

        public int cod_funcionario { get; set; }


        //INSERT LOCAÇÃO
        public bool cadastro_locacao()
        {
            string query = "INSERT INTO locacao VALUES(0,now()," + data_devolucao + ", " + dinheiro.ToString().Replace(",", ".") + "," + pix.ToString().Replace(",", ".") + "," + cartao_credito.ToString().Replace(",", ".") + "," + cartao_debito.ToString().Replace(",", ".") + ","+valor_total.ToString().Replace(",",".")+", " + cod_cliente + ", " + cod_funcionario + "); SELECT LAST_INSERT_ID()";

            class_conexao cconexao = new class_conexao();

            cod_locacao = 0;
            cod_locacao = cconexao.ExecutaQueryID(query);

            if (cod_locacao != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //N x N //BUSCAR NOME DO JOGO LOCAÇÃO
        public DataTable buscar_produto_locacao(string nome)
        {
            string query = "SELECT produto.cod_produto'Código', produto.nome'Nome', categoria.nome'Categoria', produto.preco_diaria'Preço Diária' FROM produto JOIN categoria on produto.cod_categoria = categoria.cod_categoria WHERE produto.status = 1 AND produto.tipo <>'Venda' AND produto.nome LIKE '%" + nome + "%' AND produto.alugado <> 1 AND produto.quantidade > 0";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

       




    }
}
