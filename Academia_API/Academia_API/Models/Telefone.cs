namespace Academia_API.Models
{
    public class Telefone : Base
    {
        public int Codigo { get; set; }
        public string Numero { get; set; }
        public bool Main { get; set; }
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}