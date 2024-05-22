using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class UsuarioModel
    {
        [Required]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Informe seu Nome:")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe seu CPF:")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Informe o Email:")]
        [StringLength(50)]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe sua Senha:")]
        [StringLength(20)]
        public string Senha { get; set; }

        [Required]
        public string Role { get; set; } // "Usuario", "Operador" ou "Administrador"

        public virtual ICollection<Denuncia> Denuncias { get; set; }
    }
}
