using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SisGerenciador.src.Models
{
    public class PeriodoCurricular
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Número Ordinal")]
        [Required(ErrorMessage = "O número ordinal do período curricular é obrigatório")]
        public int NumOrdinal { get; set; }

        public virtual ICollection<GradeCurricular> GradeCurriculares { get; set; }
    }
}
