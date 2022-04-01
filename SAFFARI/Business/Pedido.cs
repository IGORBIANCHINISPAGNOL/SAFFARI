using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Pedido : Base
    {
        [BaseOptions(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = false, UsarParaExcluir = true)]
        public int Id { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public string Cliente { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public string CPF { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public string Produto { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public DateTime Horario { get; set; }     
        [BaseOptions(UsarNoBancoDeDados = true)]
        public int Qtd { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarParaExcluir = true)]
        public int ClienteId { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public string ProdutoDescricao { get; set; }
    }
}
