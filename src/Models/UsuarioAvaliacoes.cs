namespace _03Blazor_Biblioteca.src.Models { 
using System.ComponentModel.DataAnnotations;

    public class UsuarioAvaliacoes    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public double Nota { get; set; }        
        public string Comentario { get; set; }        

    }
}
