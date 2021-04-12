using FluentValidation;
using SisGerenciador.src.Models;
using System;

namespace SisGerenciador.Models.Validations
{
   
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
        
        }
    }
}
