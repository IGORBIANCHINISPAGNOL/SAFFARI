using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Base : IBase
    {
        public int Key
        {
            get
            {
                foreach (PropertyInfo pi in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    BaseOptions pOpcoesBase = (BaseOptions)pi.GetCustomAttribute(typeof(BaseOptions));
                    if (pOpcoesBase != null && pOpcoesBase.ChavePrimaria)
                    {
                        return Convert.ToInt32(pi.GetValue(this));
                    }
                }
                return 0;
            }
        }

        private string tipoPropriedade(PropertyInfo pi)
        {
            switch (pi.PropertyType.Name)
            {
                case "Int32":
                    return "int";
                case "Int64":
                    return "bigint";
                case "Double":
                    return "decimal(10,2)";
                case "Single":
                    return "float";
                case "DateTime":
                    return "datetime";
                case "Boolean":
                    return "tinyint";
                case "Decimal":
                    return "decimal(10,2)";
                default:
                    return "varchar(255)";
            }
        }

        public virtual void CriarTabela(bool type)
        {
            using (SqlConnection connection = new SqlConnection(
                        Connection.StrCon))
            {
                string chavePrimaria = "";
                List<string> campos = new List<string>();

                foreach (PropertyInfo pi in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    BaseOptions pOpcoesBase = (BaseOptions)pi.GetCustomAttribute(typeof(BaseOptions));
                    if (pOpcoesBase != null && pOpcoesBase.UsarNoBancoDeDados && !pOpcoesBase.AutoIncrementar)
                    {
                        if (pOpcoesBase.ChavePrimaria)
                            chavePrimaria = pi.Name + " int identity, ";
                        else
                            campos.Add(pi.Name + " " + tipoPropriedade(pi) + " ");
                    }
                }
                string tabelaExiste = "IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[" + this.GetType().Name + "s]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)" +
                                    "DROP TABLE " + this.GetType().Name + "s";
                SqlCommand command = new SqlCommand(tabelaExiste, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
                string queryString = "";
                if (type)
                    queryString = $"CREATE TABLE {this.GetType().Name}s (";
                else
                    queryString = $"CREATE TABLE {this.GetType().Name} (";
                queryString += chavePrimaria;
                queryString += string.Join(",", campos.ToArray());
                queryString += "); ";

                command = new SqlCommand(queryString, connection);
                command.ExecuteNonQuery();
            }
        }
        public virtual void Salvar()
        {
            using (SqlConnection connection = new SqlConnection(
              Connection.StrCon))
            {
                List<string> campos = new List<string>();
                List<string> valores = new List<string>();
                foreach (PropertyInfo pi in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    BaseOptions pOpcoesBase = (BaseOptions)pi.GetCustomAttribute(typeof(BaseOptions));
                    if (pOpcoesBase != null && pOpcoesBase.UsarNoBancoDeDados && !pOpcoesBase.AutoIncrementar)
                    {
                        if (this.Key == 0)
                        {
                            if (!pOpcoesBase.ChavePrimaria)
                            {
                                campos.Add(pi.Name);
                                if (pi.PropertyType.Name == "Decimal" || pi.PropertyType.Name == "Double")
                                    valores.Add("'" + pi.GetValue(this).ToString().Replace(".", "").Replace(",", ".") + "'");
                                else
                                    valores.Add("'" + pi.GetValue(this) + "'");
                            }
                        }
                        else
                        {
                            if (!pOpcoesBase.ChavePrimaria)
                            {
                                if (pi.PropertyType.Name == "Decimal" || pi.PropertyType.Name == "Double")
                                    valores.Add(" " + pi.Name + " = '" + pi.GetValue(this).ToString().Replace(".", "").Replace(",", ".") + "'");
                                else
                                    valores.Add(" " + pi.Name + " = '" + pi.GetValue(this) + "'");
                            }
                        }
                    }
                }
                string queryString = string.Empty;
                if (this.Key == 0)
                    queryString = "insert into " + this.GetType().Name + "s (" + string.Join(", ", campos.ToArray()) + ")values(" + string.Join(", ", valores.ToArray()) + ");";
                else
                    queryString = "update " + this.GetType().Name + "s  set " + string.Join(", ", valores.ToArray()) + " where id = " + this.Key + ";";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public virtual void ExcluirId()
        {
            using (SqlConnection connection = new SqlConnection(
              Connection.StrCon))
            {
                string usarparaexcluir = string.Empty;
                var a = "";
                foreach (PropertyInfo pi in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {

                    BaseOptions pOpcoesBase = (BaseOptions)pi.GetCustomAttribute(typeof(BaseOptions));
                    if (pOpcoesBase != null && pOpcoesBase.UsarNoBancoDeDados && !pOpcoesBase.AutoIncrementar)
                    {
                        if (pOpcoesBase.UsarParaExcluir)
                        {
                            usarparaexcluir = pi.Name;
                            a = pi.GetValue(this).ToString();
                            if (usarparaexcluir == "Id")
                                break;
                        }
                    }
                }
                string queryString = "delete from " + this.GetType().Name + "s where " + usarparaexcluir + " ='" + a + "'; ";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public virtual void LimparConsumo()
        {
            using (SqlConnection connection = new SqlConnection(
              Connection.StrCon))
            {
                var a = "";
                string usarparaexcluir = string.Empty;
                foreach (PropertyInfo pi in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    BaseOptions pOpcoesBase = (BaseOptions)pi.GetCustomAttribute(typeof(BaseOptions));
                    if (pOpcoesBase != null && pOpcoesBase.UsarNoBancoDeDados && !pOpcoesBase.AutoIncrementar)
                    {
                        if (pOpcoesBase.UsarParaExcluir)
                        {
                            usarparaexcluir = pi.Name;
                            a = pi.GetValue(this).ToString();
                            if (usarparaexcluir == "ClienteId")
                                break;
                        }
                    }
                }
                string queryString = "delete from " + this.GetType().Name + "s where " + usarparaexcluir + " ='" + a + "'; ";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public virtual List<IBase> Todos()
        {
            var list = new List<IBase>();
            using (SqlConnection connection = new SqlConnection(
               Connection.StrCon))
            {
                string queryString = "select * from " + this.GetType().Name + "s";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var obj = (IBase)Activator.CreateInstance(this.GetType());
                    setProperty(ref obj, reader);
                    list.Add(obj);
                }
            }
            return list;
        }

        public virtual List<IBase> Busca()
        {
            var list = new List<IBase>();
            using (SqlConnection connection = new SqlConnection(
               Connection.StrCon))
            {
                List<string> where = new List<string>();
                string chavePrimaria = string.Empty;
                foreach (PropertyInfo pi in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    BaseOptions pOpcoesBase = (BaseOptions)pi.GetCustomAttribute(typeof(BaseOptions));
                    if (pOpcoesBase != null)
                    {
                        if (pOpcoesBase.ChavePrimaria)
                            chavePrimaria = pi.Name;

                        if (pOpcoesBase.UsarParaBuscar)
                        {
                            var valor = pi.GetValue(this);
                            if (valor != null)
                                where.Add(pi.Name + " = '" + valor + "'");
                        }
                        if (pOpcoesBase.UsarParaBuscaLike)
                        {
                            var valor = pi.GetValue(this);
                            if (valor != null)
                                where.Add(pi.Name + " like '%" + valor + "%'");
                        }
                    }
                }
                string queryString = "select * from " + this.GetType().Name + "s where " + chavePrimaria + " is not null";
                if (where.Count > 0)
                    queryString += " and " + string.Join(" and ", where.ToArray());
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var obj = (IBase)Activator.CreateInstance(this.GetType());
                    setProperty(ref obj, reader);
                    list.Add(obj);
                }
            }
            return list;
        }
        private void setProperty(ref IBase obj, SqlDataReader reader)
        {
            foreach (PropertyInfo pi in obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                BaseOptions pOpcoesBase = (BaseOptions)pi.GetCustomAttribute(typeof(BaseOptions));
                if (pOpcoesBase != null && pOpcoesBase.UsarNoBancoDeDados)
                    pi.SetValue(obj, reader[pi.Name]);
            }
        }
        public bool Existe()
        {
            string strCmd = null;
            SqlCommand sqlCmd = null;
            using (SqlConnection connection = new SqlConnection(Connection.StrCon))
            {
                strCmd = $"select case when exists(select * FROM SAFFARI.sys.tables WHERE name ='Caixas') then 1 else 0 end";
                sqlCmd = new SqlCommand(strCmd, connection);
                sqlCmd.Connection.Open();
                if ((int)sqlCmd.ExecuteScalar() == 1)
                    return true;
                else
                    return false;
            }
        }
        public virtual List<IBase> VerificarAbertura()
        {
            var list = new List<IBase>();
            using (SqlConnection connection = new SqlConnection(
               Connection.StrCon))
            {
                string queryString = "select * from " + this.GetType().Name + "s where Id=(Select max(id) from " + this.GetType().Name + "s)";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var obj = (IBase)Activator.CreateInstance(this.GetType());
                    setProperty(ref obj, reader);
                    list.Add(obj);
                }
            }
            return list;
        }
        public virtual List<IBase> BuscaData(string diaE, string diaS)
        {
            var list = new List<IBase>();
            using (SqlConnection connection = new SqlConnection(
               Connection.StrCon))
            {
                string queryString = "select * from " + this.GetType().Name + $"s where dia>='{diaE}' and dia <='{diaS.Insert(10, " 23:59:59")}' order by dia";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var obj = (IBase)Activator.CreateInstance(this.GetType());
                    setProperty(ref obj, reader);
                    list.Add(obj);
                }
            }
            return list;
        }
        public void FecharCaixa()
        {
            using (SqlConnection connection = new SqlConnection(Connection.StrCon))
            {
                var sql = $"DROP TABLE Caixas;";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
