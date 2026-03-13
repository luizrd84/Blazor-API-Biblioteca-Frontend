namespace _03Blazor_Biblioteca.src.Models { 
using System.ComponentModel.DataAnnotations;

    public class Livro    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Titulo { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int Autor_id { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int Editora_id { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int ano { get; set; }


    }
}
