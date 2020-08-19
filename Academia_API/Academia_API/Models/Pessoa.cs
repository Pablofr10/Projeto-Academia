using System;
using System.Collections.Generic;

namespace Academia_API.Models
{
    public class Pessoa : Base
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime CriadoEm { get; set; }
        public int IdTelefone { get; set; }
        public ICollection<Telefone> Telefone { get; set; }
        public int IdEndereco { get; set; }
        public ICollection<Endereco> Endereco { get; set; }
    }
}