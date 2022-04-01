using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataBase;

namespace Business
{
    public class Comanda : Base
    {
        [BaseOptions(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = false)]
        public int Id { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public string Nome { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public string CPF { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public string Pulseira { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public string Posicao { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true, UsarParaExcluir = true, UsarParaBuscar = true)]
        public int ClienteId { get; set; }
                   
        public new List<Comanda> Todos()
        {
            var comandas = new List<Comanda>();
            foreach (var ibase in base.Todos())            
                comandas.Add((Comanda)ibase);            
            return comandas;
        }
        public List<Comanda> BuscarComanda()
        {
            List<Comanda> comanda = new List<Comanda>();
            foreach (DataBase.IBase iBase in new Comanda() { ClienteId = this.ClienteId }.Busca())
                comanda.Add((Comanda)iBase);
            return comanda;
        }
    }
}
