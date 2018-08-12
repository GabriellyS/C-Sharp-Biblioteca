using ProjetoBiblioteca.Controller;
using ProjetoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.DAL
{
    class AdministradorDAO
    {
        private static Context ctx = Singleton.Instance.Context;

        public static bool AdicionarAdministrador(Administrador administrador)
        {
            if (BuscarAdministrador(administrador) == null)
            {
                try
                {
                    ctx.Administradores.Add(administrador);
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

        public static Administrador BuscarAdministrador(Administrador administrador)
        {
            return ctx.Administradores.FirstOrDefault(x => x.Nome.Equals(administrador.Nome));
        }

        public static List<Administrador> RetornarLista()
        {
            return ctx.Administradores.ToList();
        }

        /// <summary>
        /// ALTEREI AQUI
        /// </summary>
        /// <param name="login"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public static bool BuscarAdministradorPorLogin(string login, string senha)
        {
            if (ctx.Administradores.FirstOrDefault(x => x.Login.Equals(login) && x.Senha.Equals(senha)) != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
