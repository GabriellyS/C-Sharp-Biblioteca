using ProjetoBiblioteca.Controller;
using ProjetoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.DAL
{
    class ClienteDAO
    {
        private static Context ctx = Singleton.Instance.Context;

        public static bool AdicionarCliente(Cliente cliente)
        {
            if(BuscarCiente(cliente) == null)
            {
                try
                {
                    ctx.Clientes.Add(cliente);
                    ctx.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }

        public static Cliente BuscarCiente(Cliente cliente)
        {
            return ctx.Clientes.FirstOrDefault(x => x.Nome.Equals(cliente.Nome));
        }

        public static List<Cliente> RetornarLista()
        {
            return ctx.Clientes.ToList();
        }

    }
}
