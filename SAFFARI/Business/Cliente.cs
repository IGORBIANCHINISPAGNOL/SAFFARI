using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataBase;

namespace Business
{
    public class Cliente : Base
    {
        [BaseOptions(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = false)]
        public int Id { get; set; }

        [BaseOptions(UsarNoBancoDeDados = true, UsarParaBuscaLike = true)]
        public string Nome { get; set; }

        [BaseOptions(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string CPF { get; set; }

        [BaseOptions(UsarNoBancoDeDados = true)]
        public string Telefone { get; set; }

        [BaseOptions(UsarNoBancoDeDados = true)]
        public string Nascimento { get; set; }
      

        public List<Cliente> Buscar()
        {
            List<Cliente> clientes = new List<Cliente>();
            foreach (var ibase in new Cliente() { Nome = this.Nome }.Busca())            
                clientes.Add((Cliente)ibase);            
            return clientes;
        }
        public Cliente BuscarCliente()
        {
            Cliente cliente = new Cliente();
            foreach (var ibase in new Cliente() { CPF = this.CPF }.Busca())
                cliente = (Cliente)ibase;
            return cliente;
        }

        public new List<Cliente> Todos()
        {
            var clientes = new List<Cliente>();
            foreach (var ibase in base.Todos())            
                clientes.Add((Cliente)ibase);            
            return clientes;
        }
        public override string ToString()
        {
            return this.Nome.ToUpper();
        }
    }
}
