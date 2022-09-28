using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace projeto_lojinha
{
    class class_produto
    {
        public class_produto()
        {

            //MÉTODO CONSTRUTOR
            cod_produto = 0;
            nome = null;
            preco_diaria = 0;            
            especificacoes = null;
            sinopse = null;
            status = 0;
            quantidade = 0;
            faixa_etaria = null;
            preco_custo = 0;
            observacao = null;
            preco_venda = 0;
            data_lancamento = DateTime.Now;
            data_cadastro = DateTime.Now;
            desenvolvedor = null;
            tipo = null;
            lucro = 0;
            alugado = 0;
            cod_genero = 0;
            cod_plataforma = 0;
            cod_marca = 0;
            cod_categoria = 0;
        }
        //PROPRIEDADES

        public int cod_produto { get; set; }
        public string nome { get; set; }
        public decimal preco_diaria { get; set; }        
        public string especificacoes { get; set; }
        public string sinopse { get; set; }
        public int status { get; set; }
        public int quantidade { get; set; }
        public string faixa_etaria { get; set; }
        public decimal preco_custo { get; set; }
        public string observacao { get; set; }
        public decimal preco_venda { get; set; }
        public DateTime data_lancamento { get; set; }
        public DateTime data_cadastro { get; set; }
        public string desenvolvedor { get; set; }
        public string tipo { get; set; }
        public int lucro { get; set; }
        public int alugado { get; set; }
        public int cod_genero { get; set; }
        public int cod_plataforma { get; set; }
        public int cod_marca { get; set; }
        public int cod_categoria { get; set; }

        //CRIAÇÃO DO MÉTODO


        public int cadastro_produto()
        {
            string query = "INSERT INTO produto VALUES(0, '" + nome + "'," + preco_diaria.ToString().Replace(",", ".") + ",'" + especificacoes + "','" + sinopse + "', 1," + quantidade + ", '" + faixa_etaria + "'," + preco_custo.ToString().Replace(",", ".") + ",'" + observacao + "'," + preco_venda.ToString().Replace(",", ".") + ",'" + data_lancamento.ToString("yyyy-MM-dd") + "',now(), '" + desenvolvedor + "', '" + tipo + "', " + lucro.ToString().Replace(",",".") + ", 0," + cod_genero + "," + cod_plataforma + ", " + cod_marca + "," + cod_categoria + ")";

            class_conexao cconexao = new class_conexao();
            return cconexao.ExecutaQuery(query);
        }


        
        

        public bool consulta_produto(int cod)
        {
            string query = "SELECT * FROM produto WHERE cod_produto = " + cod + "";
            class_conexao cconexao = new class_conexao();
            DataTable dt = cconexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                cod_produto = Convert.ToInt32(dt.Rows[0]["cod_produto"]);
                nome = dt.Rows[0]["nome"].ToString();
                preco_diaria = Convert.ToDecimal(dt.Rows[0]["preco_diaria"]);
                especificacoes = dt.Rows[0]["especificacoes"].ToString();
                sinopse = dt.Rows[0]["sinopse"].ToString();
                status = Convert.ToInt32(dt.Rows[0]["status"]);
                quantidade = Convert.ToInt32(dt.Rows[0]["quantidade"]);
                faixa_etaria = dt.Rows[0]["faixa_etaria"].ToString();
                preco_custo = Convert.ToDecimal(dt.Rows[0]["preco_custo"]);
                observacao = dt.Rows[0]["observacao"].ToString();
                preco_venda = Convert.ToInt32(dt.Rows[0]["preco_venda"]);
                data_lancamento = Convert.ToDateTime(dt.Rows[0]["data_lancamento"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                desenvolvedor = dt.Rows[0]["desenvolvedor"].ToString();
                tipo = dt.Rows[0]["tipo"].ToString();
                lucro = Convert.ToInt32(dt.Rows[0]["lucro"]);
                alugado = Convert.ToInt32(dt.Rows[0]["alugado"]);
                cod_genero = Convert.ToInt32(dt.Rows[0]["cod_genero"]);
                cod_plataforma = Convert.ToInt32(dt.Rows[0]["cod_plataforma"]);
                cod_marca = Convert.ToInt32(dt.Rows[0]["cod_marca"]);
                cod_categoria = Convert.ToInt32(dt.Rows[0]["cod_categoria"]);
                
                return true;
            }
            else
            {
                return false;
            }



        }

        // método update

        public bool update_produto()
        {
            string query = "UPDATE produto SET nome = '" + nome + "',preco_diaria = " + preco_diaria.ToString().Replace(",", ".") + ", especificacoes = '" + especificacoes + "', sinopse = '" + sinopse + "', status = " + status + ", quantidade = " + quantidade + ", faixa_etaria = '" + faixa_etaria + "', preco_custo = " + preco_custo.ToString().Replace(",", ".") + ", observacao = '" + observacao + "', preco_venda = " + preco_venda.ToString().Replace(",", ".") + ", data_lancamento = '" + data_lancamento.ToString("yyyy-MM-dd") + "', desenvolvedor = '" + desenvolvedor + "', tipo = '" + tipo + "', lucro = " + lucro.ToString().Replace(",", ".") + ", alugado = " + alugado + " WHERE cod_produto = " + cod_produto + "";

            class_conexao cconexao = new class_conexao();
            int resp = cconexao.ExecutaQuery(query);
            if (resp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        // método delete

        public bool delete_produto()
        {
            string query = "DELETE FROM produto WHERE cod_produto = " + cod_produto + "";
            class_conexao cconexao = new class_conexao();
            int resp = cconexao.ExecutaQuery(query);

            if (resp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // consulta de produto por nome

        public DataTable consulta_produto_venda_nomei(string nomei)
        {
            string query = "SELECT produto.cod_produto'Código', categoria.nome'Categoria',produto.nome'Produto',marca.nome'Marca', produto.quantidade'Quantidade', produto.preco_custo,produto'Preço'.lucro,produto'Lucro'.preco_venda'Preço Venda' FROM produto JOIN categoria ON categoria.cod_categoria = produto.cod_categoria JOIN marca ON produto.cod_marca = marca.cod_marca WHERE produto.status = 1 AND produto.nome LIKE '" + nomei + "%' AND produto.tipo <> 'Locação' ORDER BY produto.nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable consulta_produto_venda_nomec(string nomec)
        {
            string query = "SELECT produto.cod_produto'Código', categoria.nome'Categoria',produto.nome'Produto',marca.nome'Marca', produto.quantidade'Quantidade', produto.preco_custo,produto'Preço'.lucro,produto'Lucro'.preco_venda'Preço Venda' FROM produto JOIN categoria ON categoria.cod_categoria = produto.cod_categoria JOIN marca ON produto.cod_marca = marca.cod_marca WHERE produto.status = 1 AND produto.nome LIKE '%" + nomec + "%' AND produto.tipo <> 'Locação' ORDER BY produto.nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        // consulta de produto por status
        public DataTable consulta_produto_venda_status(int status)
        {
            string query = "SELECT produto.cod_produto'Código', categoria.nome'categoria',produto.nome'produto',marca.nome'marca', produto.quantidade, produto.preco_custo,produto.lucro,produto.preco_venda FROM produto JOIN categoria ON categoria.cod_categoria = produto.cod_categoria JOIN marca ON produto.cod_marca = marca.cod_marca WHERE produto.status =" + status + " AND produto.tipo <> 'Locação' ORDER BY produto.nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        // consulta de produto por marca
        public DataTable consulta_produto_venda_marcai(string marcai) // duvidas
        {
            string query = "SELECT produto.cod_produto'Código', categoria.nome'Categoria',produto.nome'Produto', marca.nome'Marca', produto.quantidade'Quantidade', produto.preco_custo'Preço',produto.lucro'Lucro',produto.preco_venda'Preço Venda' FROM produto JOIN categoria ON categoria.cod_categoria = produto.cod_categoria JOIN marca ON marca.cod_marca = produto.cod_marca WHERE produto.status = 1 AND categoria.nome <> 'Jogo' AND marca.nome LIKE '" + marcai + "%' AND categoria.nome <> 'Jogo' ORDER BY produto.nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable consulta_produto_venda_marcac(string marcac) // duvidas
        {
            string query = "SELECT produto.cod_produto'Código', categoria.nome'Categoria',produto.nome'Produto', marca.nome'Marca', produto.quantidade'Quantidade', produto.preco_custo'Preço',produto.lucro'Lucro',produto.preco_venda'Preço Venda' FROM produto JOIN categoria ON categoria.cod_categoria = produto.cod_categoria JOIN marca ON marca.cod_marca = produto.cod_marca WHERE produto.status = 1 AND categoria.nome <> 'Jogo' AND marca.nome LIKE '%" + marcac + "%'  ORDER BY produto.nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        // consulta de produto por categoria
        public DataTable consulta_produto_venda_categoriai(string categoriai)
        {
            string query = "SELECT produto.cod_produto'Código', categoria.nome'Categoria',produto.nome'Produto', marca.nome'Marca', produto.quantidade'Quantidade', produto.preco_custo'Preço',produto.lucro'Lucro',produto.preco_venda'Preço Venda' FROM produto JOIN categoria ON categoria.cod_categoria = produto.cod_categoria JOIN marca ON marca.cod_marca = produto.cod_marca WHERE produto.status = 1 AND categoria.nome LIKE '" + categoriai + "%' AND produto.tipo <> 'Locação' ORDER BY produto.nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable consulta_produto_venda_categoriac(string categoriac)
        {
            string query = "SELECT produto.cod_produto'Código', categoria.nome'Categoria',produto.nome'Produto', marca.nome'Marca', produto.quantidade'Quantidade', produto.preco_custo'Preço',produto.lucro'Lucro',produto.preco_venda'Preço Venda' FROM produto JOIN categoria ON categoria.cod_categoria = produto.cod_categoria JOIN marca ON marca.cod_marca = produto.cod_marca WHERE produto.status = 1 AND categoria.nome LIKE '%" + categoriac + "%' AND produto.tipo <> 'Locação' ORDER BY produto.nome;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        // consulta de produto por preço jogo asc
        public DataTable consulta_produto_venda_preco_jogoa() // duvidas // ascende
        {
            string query = "SELECT produto.cod_produto'Código', categoria.nome'Categoria',produto.nome'Produto', produto.quantidade'Quantidade', produto.preco_custo'Preço',produto.lucro'Lucro',produto.preco_venda'Preço Venda' FROM produto JOIN categoria ON categoria.cod_categoria = produto.cod_categoria WHERE produto.status = 1  AND categoria.nome = 'Jogo' AND produto.tipo <> 'Locação' ORDER BY produto.preco_custo ASC;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        // consulta de produto por preço jogo des
        public DataTable consulta_produto_venda_preco_jogod() // duvidas // descende
        {
            string query = "SELECT produto.cod_produto'Código', categoria.nome'Categoria',produto.nome'Produto', produto.quantidade'Quantidade', produto.preco_custo'Preço',produto.lucro'Lucro',produto.preco_venda'Preço Venda' FROM produto JOIN categoria ON categoria.cod_categoria = produto.cod_categoria WHERE produto.status = 1 AND categoria.nome = 'Jogo' AND produto.tipo <> 'Locação' ORDER BY produto.preco_custo DESC;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        // consulta de produto por preço periférico asc
        public DataTable consulta_produto_venda_preco_perifericoa()// ascende
        {
            string query = "SELECT produto.cod_produto'Código', categoria.nome'Categoria',produto.nome'Produto', marca.nome'Marca', produto.quantidade'Quantidade', produto.preco_custo'Preço',produto.lucro'Lucro',produto.preco_venda'Preço Venda' FROM produto JOIN categoria ON categoria.cod_categoria = produto.cod_categoria JOIN marca ON marca.cod_marca = produto.cod_marca WHERE produto.status = 1 AND categoria.nome <> 'Jogo' ORDER BY produto.preco_custo ASC;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        // consulta de produto por preço periférico desc
        public DataTable consulta_produto_venda_preco_perifericod()// descende
        {
            string query = "SELECT produto.cod_produto'Código', categoria.nome'Categoria',produto.nome'Produto', marca.nome'Marca', produto.quantidade'Quantidade', produto.preco_custo'Preço',produto.lucro'Lucro',produto.preco_venda'Preço Venda' FROM produto JOIN categoria ON categoria.cod_categoria = produto.cod_categoria JOIN marca ON marca.cod_marca = produto.cod_marca WHERE produto.status = 1 AND categoria.nome <> 'Jogo' ORDER BY produto.preco_custo DESC;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        //consulta venda data
        public DataTable consulta_venda_data(int data1, int data2) // data lançamento
        {
            string query = "SELECT produto.cod_produto'Código', categoria.nome'Categoria', produto.nome'Nome Jogo',produto.quantidade'Quantidade', produto.preco_custo'Preço Custo',produto.lucro'Lucro',produto.preco_venda'Preço Venda', produto.desenvolvedor'Desenvolvedor', produto.data_lancamento'Data Lançamento' FROM produto JOIN categoria ON categoria.cod_categoria = produto.cod_categoria WHERE produto.tipo <> 'Locaçao' AND YEAR(produto.data_lancamento) BETWEEN " + data1 + " AND " + data2 + " ORDER BY produto.data_lancamento;";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }


        //  -----------------------------------------------------------------------------------------------------------------------------------------------------                                         CONSULTAS LOCAÇÃO

        //nome
        public DataTable consulta_locacao_nomei(string nomei) // nome inicio
        {
            string query = "SELECT produto.cod_produto'Código', produto.nome'Nome Jogo', produto.preco_diaria'Preço Diária', produto.desenvolvedor'Desenvolvedor',produto.data_lancamento'Data Lançamento' FROM produto JOIN categoria ON categoria.cod_categoria = produto.cod_categoria WHERE produto.tipo <> 'Venda' AND produto.alugado = 0 AND produto.nome LIKE '" + nomei + "%'";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable consulta_locacao_nomec(string nomec) // nome contem
        {
            string query = "SELECT produto.cod_produto'Código', produto.nome'Nome Jogo', produto.preco_diaria'Preço Diária', produto.desenvolvedor'Desenvolvedor',produto.data_lancamento'Data Lançamento' FROM produto JOIN categoria ON categoria.cod_categoria = produto.cod_categoria WHERE produto.tipo <> 'Venda' AND produto.alugado = 0 AND produto.nome LIKE '%" + nomec + "%'";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        // status
            
        public DataTable consulta_locacao_status(int status) // status
        {
            string query = "SELECT produto.cod_produto'Código', produto.nome'Nome Jogo', produto.preco_diaria'Preço Diária', produto.desenvolvedor'Desenvolvedor',produto.data_lancamento'Data Lançamento' FROM produto JOIN categoria ON categoria.cod_categoria = produto.cod_categoria WHERE produto.status = " + status + " AND produto.tipo <> 'Venda' AND produto.alugado = 0";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        // preço diária
        public DataTable consulta_locacao_preco_diariaa() // preço diaria desc
        {
            string query = "SELECT produto.cod_produto'Código', produto.nome'Nome Jogo', produto.preco_diaria'Preço Diária', produto.desenvolvedor'Desenvolvedor',produto.data_lancamento'Data Lançamento' FROM produto WHERE produto.tipo <> 'Venda' AND produto.alugado = 0 ORDER by produto.preco_diaria ASC ";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        public DataTable consulta_locacao_preco_diariad() // preço diaria desc
        {
            string query = "SELECT produto.cod_produto'Código', produto.nome'Nome Jogo', produto.preco_diaria'Preço Diária', produto.desenvolvedor'Desenvolvedor',produto.data_lancamento'Data Lançamento' FROM produto WHERE produto.tipo <> 'Venda' AND produto.alugado = 0 ORDER by produto.preco_diaria DESC";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        //desenvolvedor

        public DataTable consulta_locacao_desenvolvedori(string devi) // nome inicio
        {
            string query = "SELECT produto.cod_produto'Código', produto.nome'Nome Jogo', produto.preco_diaria'Diária', produto.desenvolvedor'Desenvolvedor',produto.data_lancamento'Data de Lançamento' FROM produto JOIN categoria ON categoria.cod_categoria = produto.cod_categoria WHERE produto.tipo <> 'Venda' AND produto.alugado = 0 AND produto.desenvolvedor LIKE '" + devi + "%'";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable consulta_locacao_desenvolvedorc(string devc) // nome contem
        {
            string query = "SELECT produto.cod_produto'Código', produto.nome'Nome Jogo', produto.preco_diaria'Diária', produto.desenvolvedor'Desenvolvedor',produto.data_lancamento'Data de Lançamento' FROM produto JOIN categoria ON categoria.cod_categoria = produto.cod_categoria WHERE produto.tipo <> 'Venda' AND produto.alugado = 0 AND produto.desenvolvedor LIKE '%" + devc + "%'";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        //data lancamento
        public DataTable consulta_locacao_data(int data,int data2) // data lançamento
        {
            string query = "SELECT produto.cod_produto'Código', produto.nome'Nome Jogo', produto.preco_diaria'Preço Diária', produto.desenvolvedor'Desenvolvedor', produto.data_lancamento'Data Lançamento' FROM produto JOIN categoria ON categoria.cod_categoria = produto.cod_categoria WHERE produto.tipo <> 'Venda' AND produto.alugado = 0 AND YEAR(produto.data_lancamento) BETWEEN " + data + " AND " + data2 + " AND categoria.nome = 'Jogo' ORDER BY produto.data_lancamento";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        // plataforma
        public DataTable consulta_locacao_plataformai(string plataformai) // plataforma
        {
            string query = "SELECT produto.cod_produto'Código', produto.nome'Nome Jogo', produto.preco_diaria'Preço Diária', produto.desenvolvedor'Desenvolvedor', produto.data_lancamento'Data Lançamento' FROM produto JOIN plataforma ON plataforma.cod_plataforma = produto.cod_plataforma WHERE produto.tipo <> 'Venda' AND produto.alugado = 0 AND plataforma.nome LIKE '" + plataformai + "%' ORDER BY plataforma.nome";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable consulta_locacao_plataformac(string plataformac) // plataforma
        {
            string query = "SELECT produto.cod_produto'Código', produto.nome'Nome Jogo',plataforma.nome'Plataforma',produto.preco_diaria'Preço Diária', produto.desenvolvedor'Desenvolvedor', produto.data_lancamento'Data Lançamento' FROM produto JOIN plataforma ON plataforma.cod_plataforma = produto.cod_plataforma WHERE produto.tipo <> 'Venda' AND produto.alugado = 0 AND plataforma.nome LIKE '%" + plataformac + "%' ORDER BY plataforma.nome";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable consulta_locacao_alugado(int alugado) // alugado
        {
            string query = "SELECT produto.cod_produto'Código', produto.nome'Nome Jogo', produto.preco_diaria'Preço Diária', produto.desenvolvedor'Desenvolvedor', produto.data_lancamento'Data Lançamento' FROM produto WHERE produto.tipo <> 'Venda' AND produto.alugado = " + alugado + " ORDER BY produto.nome";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }


        // relatorios venda

        // venda jogo
        public DataTable relatorio_produto_venda_jogo_plataforma(int plataforma) // plataforma
        {
            string query = "SELECT produto.nome, produto.tipo, categoria.nome'cod_categoria', marca.nome'cod_marca', plataforma.nome'cod_plataforma', produto.preco_venda FROM produto JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN marca ON produto.cod_marca = marca.cod_marca JOIN plataforma ON produto.cod_plataforma = plataforma.cod_plataforma WHERE produto.tipo = 'Venda' AND produto.status = 1 AND plataforma.cod_plataforma = " + plataforma + " ORDER BY produto.nome";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable relatorio_produto_venda_jogo_data_lancamento(int data1, int data2) // data lançamento
        {
            string query = "SELECT produto.nome, produto.tipo, categoria.nome'cod_categoria', marca.nome'cod_marca', plataforma.nome'cod_plataforma', produto.preco_venda FROM produto JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN marca ON produto.cod_marca = marca.cod_marca JOIN plataforma ON produto.cod_plataforma = plataforma.cod_plataforma WHERE produto.tipo = 'Venda' AND produto.status = 1 AND YEAR(produto.data_lancamento) BETWEEN " + data1 + " AND " + data2 + " ORDER BY produto.nome";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        public DataTable relatorio_produto_venda_jogo_genero(int genero) // genero
        {
            string query = "SELECT produto.nome, produto.tipo, categoria.nome'cod_categoria', marca.nome'cod_marca', plataforma.nome'cod_plataforma', produto.preco_venda FROM produto JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN marca ON produto.cod_marca = marca.cod_marca JOIN plataforma ON produto.cod_plataforma = plataforma.cod_plataforma JOIN genero ON produto.cod_genero = genero.cod_genero WHERE produto.tipo = 'Venda' AND produto.status = 1 AND genero.cod_genero = " + genero + " ORDER BY produto.nome";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable relatorio_produto_venda_jogo_status(int status) // status
        {
            string query = "SELECT produto.nome, produto.tipo, categoria.nome'cod_categoria', marca.nome'cod_marca', plataforma.nome'cod_plataforma', produto.preco_venda FROM produto JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN marca ON produto.cod_marca = marca.cod_marca JOIN plataforma ON produto.cod_plataforma = plataforma.cod_plataforma WHERE produto.tipo = 'Venda' AND produto.status = " + status + " ORDER BY produto.nome";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        // fim venda jogo



        // venda periférico
        public DataTable relatorio_produto_venda_periferico_marca(int marca) // marca
        {
            string query = "SELECT produto.nome, produto.tipo, categoria.nome'cod_categoria', marca.nome'cod_marca', plataforma.nome'cod_plataforma', produto.preco_venda FROM produto JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN marca ON produto.cod_marca = marca.cod_marca JOIN plataforma ON produto.cod_plataforma = plataforma.cod_plataforma WHERE produto.tipo = 'Venda' AND produto.status = 1 AND marca.cod_marca = " + marca + " ORDER BY produto.nome";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable relatorio_produto_venda_periferico_status(int status) // status
        {
            string query = "SELECT produto.nome, produto.tipo, categoria.nome'cod_categoria', marca.nome'cod_marca', plataforma.nome'cod_plataforma', produto.preco_venda FROM produto JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN marca ON produto.cod_marca = marca.cod_marca JOIN plataforma ON produto.cod_plataforma = plataforma.cod_plataforma WHERE produto.tipo = 'Venda' AND produto.status = " + status + " ORDER BY produto.nome";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        // fim venda periférico


        // relatorios locacao
        public DataTable relatorio_produto_locacao_plataforma(int plataforma) // plataforma
        {
            string query = "SELECT produto.nome, produto.tipo, categoria.nome'cod_categoria',plataforma.nome'cod_plataforma', produto.preco_diaria FROM produto JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN plataforma ON produto.cod_plataforma = plataforma.cod_plataforma WHERE produto.tipo = 'Locação' AND produto.status = 1 AND plataforma.cod_plataforma = " + plataforma + " ORDER BY produto.nome";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        public DataTable relatorio_produto_locacao_data_lancamento(int data1, int data2) // data
        {
            string query = "SELECT produto.nome, produto.tipo, categoria.nome'cod_categoria',plataforma.nome'cod_plataforma', produto.preco_diaria FROM produto JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN plataforma ON produto.cod_plataforma = plataforma.cod_plataforma WHERE produto.tipo = 'Locação' AND produto.status = 1 AND YEAR(produto.data_lancamento) BETWEEN " + data1 + " AND " + data2 + " ORDER BY produto.nome";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable relatorio_produto_locacao_status(int status) // status
        {
            string query = "SELECT produto.nome, produto.tipo, categoria.nome'cod_categoria',plataforma.nome'cod_plataforma', produto.preco_diaria FROM produto JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN plataforma ON produto.cod_plataforma = plataforma.cod_plataforma WHERE produto.tipo = 'Locação' AND produto.status = " + status + " ORDER BY produto.nome";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable relatorio_produto_locacao_genero(int genero) // genero
        {
            string query = "SELECT produto.nome, produto.tipo, categoria.nome'cod_categoria',plataforma.nome'cod_plataforma', produto.preco_diaria FROM produto JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN plataforma ON produto.cod_plataforma = plataforma.cod_plataforma JOIN genero ON produto.cod_genero = genero.cod_genero WHERE produto.tipo = 'Locação' AND produto.status = 1 AND genero.nome = " + genero + " ORDER BY produto.nome";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }
        public DataTable relatorio_produto_locacao_alugado(int alugado) // alugado
        {
            string query = "SELECT produto.nome, produto.tipo, categoria.nome'cod_categoria',plataforma.nome'cod_plataforma', produto.preco_diaria FROM produto JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN plataforma ON produto.cod_plataforma = plataforma.cod_plataforma JOIN genero ON produto.cod_genero = genero.cod_genero WHERE produto.tipo = 'Locação' AND produto.status = 1 AND produto.alugado = " + alugado + " ORDER BY produto.nome";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }

        // fim relatorios locação




        // métodos NxN -- Nico


        public DataTable buscar_produto_venda(string nome)
        {
            string query = "SELECT produto.cod_produto'Código', produto.nome'Nome', categoria.nome'Categoria', produto.quantidade'Estoque', produto.preco_venda'Preço' FROM produto JOIN categoria on produto.cod_categoria = categoria.cod_categoria WHERE produto.status = 1 AND produto.tipo <>'Locação' AND produto.nome LIKE '%" + nome + "%'";

            class_conexao cconexao = new class_conexao();
            return cconexao.RetornaDataTable(query);
        }





        // levar nome do produto para a lista de itens 


        public string buscar_nome_produto(int cod)
        {
            string query = "SELECT nome FROM produto WHERE cod_produto = " + cod + "";

            class_conexao cconexao = new class_conexao();
            DataTable dt = cconexao.RetornaDataTable(query);
            if (dt.Rows.Count > 0)
            {
                nome = dt.Rows[0]["nome"].ToString();
            }
            return nome;

        }


        public string buscar_nome_categoria(int cod)
        {
            string query = "SELECT categoria.nome FROM produto JOIN categoria ON produto.cod_categoria = categoria.cod_categoria WHERE produto.cod_produto = " + cod + "";

            class_conexao cconexao = new class_conexao();
            DataTable dt = cconexao.RetornaDataTable(query);
            if (dt.Rows.Count > 0)
            {
                nome = dt.Rows[0]["nome"].ToString();
            }
            return nome;

        }




        // método de atualizar quantidade do estoque quando uma venda é finalizada

        public bool update_quantidade(int quantidade, int cod)
        {
            string query = "UPDATE produto SET quantidade = " + quantidade +" WHERE cod_produto = " + cod + "";
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
        public bool alugar_produto(int cod)
        {
            string query = "UPDATE produto SET alugado = 1 WHERE cod_produto = " + cod + "";
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
