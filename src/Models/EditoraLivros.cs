namespace _03Blazor_Biblioteca.src.Models { 
using System.ComponentModel.DataAnnotations;

    public class EditoraLivros    {

        
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Titulo { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Autor { get; set; }

        

    }
}
