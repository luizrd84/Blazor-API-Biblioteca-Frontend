namespace _03Blazor_Biblioteca.src.Models { 
using System.ComponentModel.DataAnnotations;

    public class AutorLivros    {

        //public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Nome { get; set; } //Autor. Deveria incluir mais dados nessa pesquisa.
        

    }
}
