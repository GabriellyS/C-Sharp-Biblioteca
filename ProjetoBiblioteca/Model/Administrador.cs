using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.Model
{
    [Table("Administrador")]
    class Administrador
    {
        [Key]
        public int AdministradorId { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
