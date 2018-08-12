using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.Model
{
    [Table("Emprestimos")]
    class Emprestimo
    {
        [Key]
        public int EmprestimoId { get; set; }
        public Cliente Cliente { get; set; }
        public Livro Livro { get; set; }
        public Funcionario Funcionario { get; set; }
        public DateTime DataAlugada { get; set; }
    }
}
