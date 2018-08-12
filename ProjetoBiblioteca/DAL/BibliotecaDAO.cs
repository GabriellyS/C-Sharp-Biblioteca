using ProjetoBiblioteca.Controller;
using ProjetoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.DAL
{
    class BibliotecaDAO
    {
        private static Context ctx = Singleton.Instance.Context;

        public static bool AdicionarBiblioteca(Biblioteca biblioteca)
        {
            if(BuscarBiblioteca(biblioteca) == null)
            {
                try
                {
                    ctx.Bibliotecas.Add(biblioteca);
                    ctx.SaveChanges();
                    return true;
                }
                catch(Exception)
                {
                    return false;
                }
            }
            return false;
        }

        public static Biblioteca BuscarBiblioteca(Biblioteca biblioteca)
        {
            return ctx.Bibliotecas.FirstOrDefault(x => x.Nome.Equals(biblioteca.Nome));
        }

        public static List<Biblioteca> RetornarLista()
        {
            return ctx.Bibliotecas.ToList();
        }
    }
}
