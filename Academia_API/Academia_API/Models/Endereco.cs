namespace Academia_API.Models
{
    public class Endereco : Base
    {
        public int Cep { get; set; }
        public string Localidade { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string UF { get; set; }
        public string Complemento { get; set; }
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}