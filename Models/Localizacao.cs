using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrimeWatch.Models
{
    public class Localizacao
    {
        [Required]
        public int LocalizacaoId { get; set; }

        [Required(ErrorMessage = "Informe o Endereço:")]
        [StringLength(200, ErrorMessage = "O Endereço deve ter no máximo 200 caracteres.")]
        public string Endereco { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public virtual ICollection<Denuncia> Denuncias { get; set; }
    }
}
