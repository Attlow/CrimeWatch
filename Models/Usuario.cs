using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("CPF")]
        [Display(Name = "CPF")]
        [MinLength(11, ErrorMessage = "O campo deve ter no mínimo 11 caracteres.")]
        [MaxLength(11, ErrorMessage = "O campo deve ter no máximo 11 caracteres")]
        [RegularExpression(@"^\d+$", ErrorMessage = "O campo deve conter apenas números.")]
        public string cpf { get; set; }
    }
}