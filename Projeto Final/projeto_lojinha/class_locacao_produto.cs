using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_lojinha
{
    class class_locacao_produto
    {
         //MÉTODO CONSTRUTOR

        public class_locacao_produto()
        {
            cod_locacao_produto = 0;
            cod_locacao = 0;
            cod_produto = 0;
            preco = 0;
            quantidade = 0;
                
        }

        //PROPRIEDADES
        public int cod_locacao_produto { get; set; }

        public int cod_locacao { get; set; }

        public int cod_produto { get; set; }

        public decimal preco { get; set; }

        public int quantidade { get; set; }

        //CADASTRO LOCAÇÃO PRODUTO
        public bool cadastro_locacao_produto()
        {
            string query = "INSERT INTO locacao_produto VALUES(0," + cod_locacao + "," + cod_produto + "," + preco.ToString().Replace(",", ".") + "," + quantidade + ")";
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
