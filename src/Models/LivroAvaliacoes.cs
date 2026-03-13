namespace _03Blazor_Biblioteca.src.Models { 
using System.ComponentModel.DataAnnotations;

    public class LivroAvaliacoes    {

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public double Nota { get; set; }
               
        public string? Comentario { get; set; }
        

    }
}
