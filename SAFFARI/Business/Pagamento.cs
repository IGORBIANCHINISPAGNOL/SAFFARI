using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Pagamento : Base
    {
        [BaseOptions(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = false, UsarParaExcluir = true)]
        public int Id { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public string Descricao { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public string FormaPagt { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public decimal Entrada { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public decimal Saida { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarParaExcluir = true)]
        public int ClienteId { get; set; }

        public List<Pagamento> Pagamentos()
        {
            List<Pagamento> pagamentos = new List<Pagamento>();
            foreach (DataBase.IBase iBase in new Pagamento() { ClienteId = this.ClienteId }.Busca())            
                pagamentos.Add((Pagamento)iBase);            
            return pagamentos;
        }
    }
}
