using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechChallenge1.Core.DTO;
using TechChallenge1.Domain.Models;

namespace TechChallenge1.Domain.Validators
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator() 
        {
            RuleFor(c => c.Email).NotEmpty().WithMessage("Campo de preenchimento obrigatório.")
                .EmailAddress().WithMessage("Informe um endereço de e-mail válido. Ex.: nome@dominio.com.br");

            RuleFor(c => c.Phone).NotEmpty().WithMessage("Campo de preenchimento obrigatório.")
                .Must(IsOnlyNumberString).WithMessage("O telefone deve conter apenas números.")
                .Length(10, 11);

            RuleFor(c => c.Name).NotEmpty().WithMessage("Campo de preenchimento obrigatório.")
                .Length(4, 64).WithMessage("Campo com limite entre 4 e 64 caracteres.");
        }

        // Check if the string passed contains only numeric characters
        private bool IsOnlyNumberString(string numericString)
        {
            return long.TryParse(numericString, out _);
        }
    }
}
