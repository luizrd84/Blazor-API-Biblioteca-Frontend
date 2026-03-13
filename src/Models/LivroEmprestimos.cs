namespace _03Blazor_Biblioteca.src.Models { 
using System.ComponentModel.DataAnnotations;

    public class LivroEmprestimos    {

        [Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime? Data_emprestimo { get; set; }
        public DateTime? Data_devolucao { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Nome { get; set; }
        public bool? Emprestado {  get; set; }

    }
}
