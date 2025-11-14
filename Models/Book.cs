using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome é um campo obrigatório")]
        [StringLength(100,ErrorMessage = "Nome precisa ter no máximo 100 caracteres")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Nome do Autor é um campo obrigatório")]
        [StringLength(100,ErrorMessage = "Nome do Autor precisa ter no máximo 100 caracteres")]
        public string Author { get; set; }
    }
}