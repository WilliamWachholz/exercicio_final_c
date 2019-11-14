using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Models
{
    abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public Pessoa()
        {
            Id = 0;
            Nome = string.Empty;
            DataNascimento = DateTime.Now;
        }
    }
}
