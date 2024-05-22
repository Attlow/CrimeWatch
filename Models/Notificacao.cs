using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Notificacao
    {
        [Required]
        public int NotificacaoId { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [Required]
        public int DenunciaId { get; set; }


        [Required]
        [StringLength(50, ErrorMessage = "A Mensagem deve ter no máximo 50 caracteres.")]
        public string Mensagem { get; set; }

        [Required(ErrorMessage = "Informe a Data e Hora:")]
        public DateTime DataHora { get; set; }

        [Required]
        public virtual UsuarioModel Usuario { get; set; }

        [Required]
        public virtual Denuncia Denuncia { get; set; }
    }
}
