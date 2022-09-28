using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_lojinha
{
    class class_produto_venda
    {


        public class_produto_venda()
        {
            // método construtor

            cod_venda_produto = 0;
            cod_venda = 0;
            cod_produto = 0;
            preco = 0;
            quantidade = 0;

        }
        // propriedades

        public int cod_venda_produto { get; set; }
        public int cod_venda { get; set; }
        public int cod_produto { get; set; }
        public decimal preco { get; set; }
        public int quantidade { get; set; }

        public bool cadastro_produto_venda()
        {
            string query = "INSERT INTO venda_produto VALUES(0," + cod_venda + "," + cod_produto + "," + preco.ToString().Replace(",",".") + "," + quantidade + ")";
            class_conexao cconexao = new class_conexao();

            int resp = cconexao.ExecutaQuery(query);

            if (resp == 1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


    }
}
