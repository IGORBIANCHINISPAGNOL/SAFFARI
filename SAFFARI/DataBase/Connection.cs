using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Connection
    {
        //private static string ConnectionLounge = @"Data Source=DESKTOP-KQ2HLDN\SQLEXPRESS; Integrated Security=False;Initial Catalog=SAFFARI;User ID=LOUNGE;Password=31649782;Connect Timeout=200";
        private static string ConnectionLocal = @"Data Source=IGOR\SQLEXPRESS134679; Integrated Security=True;Initial Catalog=SAFFARI";


        public static string StrCon
        {
            get { return ConnectionLocal; }
        }
    }
}
