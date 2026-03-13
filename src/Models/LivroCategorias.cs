namespace _03Blazor_Biblioteca.src.Models { 
using System.ComponentModel.DataAnnotations;

    public class LivroCategorias    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Nome { get; set; }


    }
}
