using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Produto : Base
    {
        [BaseOptions(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = false, UsarParaExcluir = true)]
        public int Id { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true, UsarParaBuscaLike = true)]
        public string Nome { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public decimal Valor { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public int Qtd { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public string Categoria { get; set; }

        public List<Produto> produtos { get; set; }

        public Produto()
        {

        }
        public Produto(int id, string nome, decimal valor, int qtd, int v, string categoria)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            Qtd = qtd;
            Categoria = categoria;
        }

        public new List<Produto> Todos()
        {
            var produto = new List<Produto>();
            foreach (var ibase in base.Todos())            
                produto.Add((Produto)ibase);            
            return produto;
        }       
      
        public List<Produto> BuscarNome()
        {                                 
            List<Produto> produtos = new List<Produto>();
            foreach (DataBase.IBase iBase in new Produto() { }.Busca())            
                produtos.Add((Produto)iBase);            
            return produtos;            
        }

        public List<Produto> BuscaCategoria()
        {
            List<Produto> produtos = new List<Produto>();
            foreach (DataBase.IBase iBase in new Produto() { }.Busca())            
                produtos.Add((Produto)iBase);            
            return produtos;
        }
    }
}
