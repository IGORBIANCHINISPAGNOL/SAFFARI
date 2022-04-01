using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public interface IBase
    {
        int Key { get; }
        void Salvar();
        void ExcluirId();
        void LimparConsumo();
        void CriarTabela(bool type);
        List<IBase> Todos();
        List<IBase> Busca();
        List<IBase> BuscaData(string diaE, string diaS);
        List<IBase> VerificarAbertura();
    }
}
