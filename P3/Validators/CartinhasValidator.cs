using FluentValidation;
using P3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P3.Validators
{
    public class CartinhasValidator : AbstractValidator<Cartinhas>
    {
        public CartinhasValidator()
        {
            RuleFor(p => p.NomeDaCrianca)
                .NotEmpty().WithMessage("Obrigatorio")
                .NotNull().WithMessage("Obrigatorio")
                .Must(nomeValido).WithMessage("Nome contem numeros");

            RuleFor(p => p.Endereco)
                .NotEmpty().WithMessage("Obrigatorio")
                .NotNull().WithMessage("Obrigatorio");

            RuleFor(p => p.Idade)
                .NotEmpty().WithMessage("Obrigatorio")
                .NotNull().WithMessage("Obrigatorio");

            RuleFor(p => p.Texto)
                .NotEmpty().WithMessage("Obrigatorio")
                .NotNull().WithMessage("Obrigatorio");

        }

        private bool nomeValido(string nome)
        {
            return nome.All(Char.IsLetter);
        }
    }
}
