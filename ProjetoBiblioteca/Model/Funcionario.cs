using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.Model
{
    [Table("Funcionarios")]
    class Funcionario
    {
        [Key]
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Funcao { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
