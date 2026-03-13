namespace _03Blazor_Biblioteca.src.Models { 
using System.ComponentModel.DataAnnotations;

    public class UsuarioEmprestimos    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int Ano { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime Data_emprestimo { get; set; }
        public DateTime? Data_devolucao { get; set; }        

    }
}
