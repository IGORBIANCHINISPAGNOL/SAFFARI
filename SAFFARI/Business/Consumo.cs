using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Consumo : Base
    {
        [BaseOptions(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = false, UsarParaExcluir = true)]
        public int Id { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public string Produto { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public decimal Valor { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public int Qtd { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public DateTime Horario { get; set; }              
        [BaseOptions(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarParaExcluir = true)]
        public int ClienteId { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public int ProdutoId { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public string ProdutoDescricao { get; set; }

        public List<Consumo> Consumos()
        {
            List<Consumo> consumos = new List<Consumo>();
            foreach (DataBase.IBase iBase in new Consumo() { ClienteId = this.ClienteId }.Busca())            
                consumos.Add((Consumo)iBase);            
            return consumos;
        }       

    }
}
