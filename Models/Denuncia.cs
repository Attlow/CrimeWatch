using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("Denuncia")]
    public class Denuncia
    {
        [Column("Denuncia_id")]
        [Display(Name = "N° Registro")]
        public int DenunciaId { get; set; }

        [Column("Id_usuario")]
        [Display(Name ="Id do Usuário")]
        public int  { get; set; }

        [Column("Descricao")]
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Informe a Descrição:")]
        [StringLength(200, ErrorMessage = "A Descrição deve ter no máximo 200 caracteres.")]
        public string Descricao { get; set; }

        [Column("Localizacao")]
        [Display(Name = "Localização da Denuncia")]
        [Required(ErrorMessage = "Informe a Localização:")]
        [StringLength(255, ErrorMessage = "A Localização deve ter no máximo 100 caracteres.")]
        public string Localizacao { get; set; }

        //[Column("Evidencia")]
        //[Display(Name = "Evidencia")]
        //[StringLength(500, ErrorMessage = "As Evidências devem ter no máximo 500 caracteres.")]
        //public string Evidencias { get; set; }

        //TALVEZ APAGAR

        [Column("Data")]
        [DataType(DataType.Date)]
        [Display(Name = "Data")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime DataHora { get; set; }

        [Column("Autorizado")]
        [MaxLength(1)]
        [Required]
        public string Autorizado { get; set; } // "Pendente", "Revisada", "Encaminhada"

        [Column("Usuario")]
        [Display(Name = "Usuario")]
        [Required]
        public virtual Usuario Usuario { get; set; }
    }
}
