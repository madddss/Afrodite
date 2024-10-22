using System.ComponentModel.DataAnnotations;

namespace afrodite.Models
{
    public class Cliente : Pessoa
    {
        [Key]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "Senha é obrigatório.")]
        private string Senha = string.Empty;

        public Cliente(int idCliente, string nome, string telefone, string email, string senha)
            : base (nome, telefone, email, senha)
        {
            IdCliente = idCliente;
            Senha = senha;
        }
    
        
        public void EditarSenha()
        {

        }
      //  public string AvaliarProfissionais()
        

       

    }
}
