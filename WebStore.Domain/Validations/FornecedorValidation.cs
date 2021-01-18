using FluentValidation;
using WebStore.Project.Backend.Domain.Entites;

namespace WebStore.Project.Backend.Domain.Validations
{
    public class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        private readonly string _stringRule = "^[0 - 9 a - zA - ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÊÍÏÓÔÕÖÚÇÑ] +$";
        private readonly string _numberStringRule = "^[0 - 9] + $";

        public FornecedorValidation()
        {
            RuleFor(f => f.RazaoSocial)
                .NotEmpty().WithMessage("Razão Social não pode estar vazia.")
                .Length(4, 50).WithMessage("Razão Social deve conter de 4 a 50 caracteres.")
                .Matches(_stringRule).WithMessage("Razão Social contém caracteres inválidos.");

            RuleFor(f => f.NomeFantasia)
                .NotEmpty().WithMessage("Nome Fantasia não pode estar vazio.")
                .Length(4, 50).WithMessage("Nome Fantasia deve conter de 4 a 50 caracteres.")
                .Matches(_stringRule).WithMessage("Nome Fantasia contém caracteres inválidos.");

            RuleFor(f => f.Email)
                .NotEmpty().WithMessage("Email não pode estar vazio.")
                .Length(12, 60).WithMessage("Email deve conter de 12 a 60 caracteres.")
                .EmailAddress().WithMessage("Email inválido. Exemplo: exemplo@exemplo.com");

            RuleFor(f => f.Cnpj)
                .NotEmpty().WithMessage("CNPJ não pode estar vazio.");

            RuleFor(f => f.Telefone)
                .NotEmpty().WithMessage("Telefone não pode estar vazio.")
                .Length(11, 11).WithMessage("Telefone deve conter 11 caracteres.")
                .Matches(_numberStringRule).WithMessage("Telefone contém caracteres inválidos.");
        }
    }
}
