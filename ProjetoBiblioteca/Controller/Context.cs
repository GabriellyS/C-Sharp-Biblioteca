using ProjetoBiblioteca.Controller;
using ProjetoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.Controller
{
    class Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Biblioteca> Bibliotecas { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }

    }
}
