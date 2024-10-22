using System.ComponentModel.DataAnnotations;

namespace afrodite.Models
{
    public class Profissional : Pessoa 
    {
        [Required(ErrorMessage = "Tipo de Serviço é obrigatório.")]
        public string TipoServico  { get; set; } = string.Empty;
        private decimal Salario { get; set; }   

        public Profissional(string tipoServico, decimal salario, string nome, string telefone, string email, string senha) 
          : base  (nome, telefone, email, senha)
        {
            TipoServico = tipoServico;
            Salario = salario;
        }
    }
}
