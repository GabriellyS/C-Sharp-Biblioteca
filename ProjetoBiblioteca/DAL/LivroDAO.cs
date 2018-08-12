using ProjetoBiblioteca.Controller;
using ProjetoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.DAL
{
    class LivroDAO
    {
        private static Context ctx = Singleton.Instance.Context;

        public static bool AdicionarLivro(Livro livro)
        {
            try
            {
                ctx.Livros.Add(livro);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        public static List<Livro> RetornarLista()
        {
            return ctx.Livros.ToList();
        }
    }
}
