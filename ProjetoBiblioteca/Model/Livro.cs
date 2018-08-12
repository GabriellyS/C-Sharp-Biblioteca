using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.Model
{
    [Table("Livros")]
    class Livro
    {
        [Key]
        public int LivroId { get; set; }
        public String Nome { get; set; }
        public String Editora { get; set; }
        public String Escritor { get; set; }
        public String Ano { get; set; }
        public DateTime DataCadastro { get; set; }
        public String Genero { get; set; }
        public String Edicao { get; set; }
        public bool Status { get; set; }
        public Biblioteca Biblioteca { get; set; }

    }
}
