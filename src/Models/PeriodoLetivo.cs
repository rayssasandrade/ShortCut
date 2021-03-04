using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SisGerenciador.src.Models
{
    public class PeriodoLetivo
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Descrição é obrigatória", AllowEmptyStrings = false)]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "A descrição deve conter no mínimo 4 e máximo 255 caracteres.")]
        public string Descricao { get; set; }

        [Display(Name = "Data de Início")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        [Required(ErrorMessage = "Data de início é obrigatória")]
        public DateTime DtInicio { get; set; }

        [Display(Name = "Data de Fim")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        [Required(ErrorMessage = "Data de fim é obrigatória")]
        public DateTime DtFim { get; set; }

        public virtual ICollection<DisciplinaOfertada> DisciplinaOfertadas { get; set; }
    }
}
