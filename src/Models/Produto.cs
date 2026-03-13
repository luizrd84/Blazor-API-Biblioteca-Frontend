namespace _03Blazor_Biblioteca.src.Models { 
using System.ComponentModel.DataAnnotations;

    public class Produto    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Nome { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Informe um valor Adequado")]
        public int Quantidade { get; set; }
        [Range(0.01, int.MaxValue, ErrorMessage = "Informe um preço adequado")]
        public double Preco {  get; set; }

        public double ValorEstoqueTotal()
        {
            return Preco * Quantidade;
        }
    }
}
