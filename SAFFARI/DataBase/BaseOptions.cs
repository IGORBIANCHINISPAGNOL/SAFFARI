using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class BaseOptions : Attribute
    {
        public bool UsarNoBancoDeDados { get; set; }
        public bool UsarParaBuscar { get; set; }
        public bool UsarParaBuscaLike { get; set; }
        public bool ChavePrimaria { get; set; }
        public bool AutoIncrementar { get; set; }
        public bool UsarParaExcluir { get; set; }       
    }
}
