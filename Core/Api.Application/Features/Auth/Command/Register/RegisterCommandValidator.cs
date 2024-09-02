using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Auth.Command.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommandRequest>
    {
        public RegisterCommandValidator()
        {
            
            RuleFor(x => x.Email)
                .NotEmpty()
                .MaximumLength(60)
                .EmailAddress()
                .MinimumLength(8)
                .WithName("E-mail Address");
            RuleFor(x => x.Password)
                .NotEmpty()
                .MinimumLength(6)
                .WithName("Password");
            RuleFor(x => x.ConfirmPassword)
              .NotEmpty()
              .MinimumLength(6)
              .WithName("Password Repeat");

        }
    }
}
