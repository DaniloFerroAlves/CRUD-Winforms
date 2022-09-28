using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace projeto_lojinha
{
    class class_venda
    {
        public class_venda()
        {

            // método construto
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

            // propriedades
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


        public bool cadastro_venda()
        {
            string query = "INSERT INTO venda VALUES(0,now()," + total_venda.ToString().Replace(",",".") + ", " + desconto.ToString().Replace(",",".") + ", " + dinheiro.ToString().Replace(",", ".") + "," + pix.ToString().Replace(",", ".") + "," + cartao_credito.ToString().Replace(",", ".") + "," + cartao_debito.ToString().Replace(",", ".") + ", " + cod_funcionario + ", " + cod_cliente + "); SELECT LAST_INSERT_ID()";

            class_conexao cconexao = new class_conexao();

            cod_venda = 0;
            cod_venda = cconexao.ExecutaQueryID(query);

            if (cod_venda != 0)
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
        






 
