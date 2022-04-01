using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Financeiro : Base
    {
        [BaseOptions(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = false, UsarParaExcluir = true)]
        public int Id { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public DateTime Dia { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public DateTime Data { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public string Descrição { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public decimal Entrada { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public decimal Saida { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public string FormaPgto { get; set; }

        public new List<Financeiro> Busca()
        {
            var financeiro = new List<Financeiro>();
            foreach (var ibase in base.Busca())
                financeiro.Add((Financeiro)ibase);
            return financeiro;
        }

        public new List<Financeiro> BuscaData(string diaE, string diaS)
        {
            var financeiro = new List<Financeiro>();
            foreach (var ibase in base.BuscaData(diaE, diaS))
                financeiro.Add((Financeiro)ibase);
            return financeiro;
        }

        public new List<Financeiro> VerificarAbertura()
        {
            var financeiro = new List<Financeiro>();
            foreach (var ibase in base.VerificarAbertura())
                financeiro.Add((Financeiro)ibase);
            return financeiro;
        }
    }
}
