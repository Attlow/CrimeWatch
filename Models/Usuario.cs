using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrimeWatch.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required]
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required]
        [Column("CPF")]
        [Display(Name = "CPF")]
        [MinLength(11, ErrorMessage = "O campo deve ter no mínimo 11 caracteres.")]
        [MaxLength(11, ErrorMessage = "O campo deve ter no máximo 11 caracteres")]
        [RegularExpression(@"^\d+$", ErrorMessage = "O campo deve conter apenas números.")]
        public string cpf { get; set; }

        [Required(ErrorMessage = "Insira seu E-mail.")]
        [Column("Email")]
        [Display(Name = "Email")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail inválido.")]
        public string email { get; set; }

        [Column("Senha")]
        [Required(ErrorMessage = "Insira sua senha")]
        [Display(Name = "Senha")]
        [MinLength(8, ErrorMessage = "O campo deve ter no mínimo 8 caracteres.")]
        public string senha { get; set; }

    }
}