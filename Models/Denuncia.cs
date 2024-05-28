using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Denuncia
    {
        [Required]
        public int DenunciaId { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Informe a Descrição:")]
        [StringLength(200, ErrorMessage = "A Descrição deve ter no máximo 200 caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe a Localização:")]
        [StringLength(100, ErrorMessage = "A Localização deve ter no máximo 100 caracteres.")]
        public string Localizacao { get; set; }

        [StringLength(500, ErrorMessage = "As Evidências devem ter no máximo 500 caracteres.")]
        public string Evidencias { get; set; }

        [Required]
        public DateTime DataHora { get; set; }

        [Required]
        public string Status { get; set; } // "Pendente", "Revisada", "Encaminhada"

        [Required]
        public virtual Usuario Usuario { get; set; }
    }
}
