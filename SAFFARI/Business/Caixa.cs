using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Caixa : Base
    {
        [BaseOptions(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public int Id { get; set; }
        [BaseOptions(UsarNoBancoDeDados = true)]
        public DateTime Data { get; set; }

        public new List<Caixa> Todos()
        {
            var caixaaberto = new List<Caixa>();
            foreach (var ibase in base.Todos())
                caixaaberto.Add((Caixa)ibase);
            return caixaaberto;
        }

        public new bool Existe()
        {
            if (new Base().Existe())
                return true;
            else
                return false;
        }
    }
}
