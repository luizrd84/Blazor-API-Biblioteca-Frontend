namespace _03Blazor_Biblioteca.src.Models { 
using System.ComponentModel.DataAnnotations;

    public class EditoraParceiros    {

        
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Autor { get; set; }
        

    }
}
