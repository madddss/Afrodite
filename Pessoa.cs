using System.ComponentModel.DataAnnotations;

namespace afrodite.Models
{
    public class Pessoa : IServicos
    {
        [Required(ErrorMessage = "Nome é obrigatório.")]
        public string Nome { get; set; } = string.Empty;
        [Required(ErrorMessage = "Telefone é obrigatório.")]
        public string Telefone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Senha é obrigatório.")]
        private string Senha = string.Empty;

        public Pessoa(string nome, string telefone, string email, string senha)
        {
            this.Nome = nome;
            this.Telefone = telefone; 
            this.Email = email;
            this.Senha = senha;
        }
    }
}
