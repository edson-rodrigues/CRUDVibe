using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using CRUDVibe.Models;

namespace CRUDVibe.Validators
{
    public class PessoaValidator : AbstractValidator<Pessoa>
    {
        public PessoaValidator()
        {
            RuleFor(pessoa => pessoa.nome).NotNull().WithMessage("O campo Nome é obrigatório");
            RuleFor(pessoa => pessoa.cpf).NotEmpty().WithMessage("O campo CPF é obrigatório").Length(11).WithMessage("O CPF deve ter 11 dígitos");
            RuleFor(pessoa => pessoa.telefone).MinimumLength(10).WithMessage("O telefone deve ter entre 10 e 11 dígitos").MaximumLength(11).WithMessage("O telefone deve ter entre 10 e 11 dígitos");
            RuleFor(pessoa => pessoa.email).EmailAddress().WithMessage("O campo deve conter um endereço de email válido");
        }

    }
}