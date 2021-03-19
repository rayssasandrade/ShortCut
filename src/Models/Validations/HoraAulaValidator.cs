using FluentValidation;
using SisGerenciador.src.Models;
using System;

namespace SisGerenciador.Models.Validations
{
   
    public class HoraAula : AbstractValidator<HoraAula>
    {
        public HoraAula()
        {
            // RuleFor(c => c.DtFim)
            // .LessThan(customer => customer.DtInicio).WithMessage("O horário final tem que ser maior que horário inicial");
        }

    }
}
