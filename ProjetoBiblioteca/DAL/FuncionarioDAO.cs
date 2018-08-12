using ProjetoBiblioteca.Controller;
using ProjetoBiblioteca.Model;
using System;
using System.Linq;

namespace ProjetoBiblioteca.DAL
{
    class FuncionarioDAO
    {
        private static Context ctx = Singleton.Instance.Context;


        public static bool AdicionarFuncionario(Funcionario funcionario)
        {
            if (Buscarfuncionario(funcionario) == null)
            {
                if (BuscarSenha(funcionario) == null)
                {
                    if (BuscarLogin(funcionario) == null)
                    {
                        try
                        {
                            ctx.Funcionarios.Add(funcionario);
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
                return false;
            }
            return false;

        }

        public static Funcionario BuscarLogin(Funcionario funcionario)
        {
            return ctx.Funcionarios.FirstOrDefault(x => x.Login.Equals(funcionario.Login));
        }

        public static Funcionario BuscarSenha(Funcionario funcionario)
        {
            return ctx.Funcionarios.FirstOrDefault(x => x.Senha.Equals(funcionario.Senha));
        }

        public static Funcionario Buscarfuncionario(Funcionario funcionario)
        {
            return ctx.Funcionarios.FirstOrDefault(x => x.Nome.Equals(funcionario.Nome));
        }

        /// <summary>
        /// ALTEREI AQUI
        /// </summary>
        /// <param name="login"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public static bool BuscarFuncionarioPorLogin(string login, string senha)
        {
            if (ctx.Funcionarios.FirstOrDefault(x => x.Login.Equals(login) && x.Senha.Equals(senha)) != null)
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

