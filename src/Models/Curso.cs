using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SisGerenciador.src.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Sigla")]
        [StringLength(25)]
        [Required(ErrorMessage = "Sigla é obrigatória", AllowEmptyStrings = false)]
        public string Sigla { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Descrição é obrigatória", AllowEmptyStrings = false)]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "A descrição deve conter no mínimo 4 e máximo 255 caracteres.")]
        public string Descricao { get; set; }

        [Display(Name = "Quantidade de períodos")]
        [Required(ErrorMessage = "A quantidade de períodos é obrigatória")]
        public int QtdPeriodo { get; set; }

        [Display(Name = "Limite de períodos")]
        [Required(ErrorMessage = "A quantidade de períodos é obrigatória")]
        public int LimiteQtdPeriodoCurricular { get; set; }

        public Instituicao Instituicao { get; set; }
        public int InstituicaoId { get; set; }

        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }

        public virtual ICollection<GradeCurricular> GradeCurriculares { get; set; }
    }
}


        
    
