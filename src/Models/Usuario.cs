namespace _03Blazor_Biblioteca.src.Models { 
using System.ComponentModel.DataAnnotations;

    public class Usuario    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Email { get; set; }
        public DateTime Cadastro { get; set; }

    }
}
