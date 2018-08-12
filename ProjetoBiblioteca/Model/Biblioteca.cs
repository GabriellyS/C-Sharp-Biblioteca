using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.Model
{
    [Table("Bibliotecas")]
    class Biblioteca
    {
        [Key]
        public int BibliotecaId { get; set; }
        public String Nome { get; set; }
        public String Endereco { get; set; }
        public String Telefone { get; set; }
    }
}
